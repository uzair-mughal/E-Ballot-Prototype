using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Election_Commission_Panel
{
    public partial class Election_Commission_Main : Form
    {

        public MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=e_ballot;");
        private DateTime endDate, startDate;
        private string type;

        private void press_button(string start, string end)
        {
            con.Open();

            string query = "INSERT INTO voting_time values ('" + start + "', '" + end + "','" + type + "', 0)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteReader();

            con.Close();
        }

        private void set_check()
        {
            con.Open();
            string query = "update voting_time set closed = 1 where seat_type = '" + type + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteReader();
            con.Close();
        }

        private void reserved_voting()
        {
            // Closing open seat voting
            timer1.Stop();
            openLabel.Text = "Voting Ended!";
            
            type = "Reserved Seat";
            reservedStartDateTimePicker.Enabled = true;
            reservedEndDateTimePicker.Enabled = true;
            reservedButton.Enabled = true;

            reservedStartDateTimePicker.Format = DateTimePickerFormat.Custom;
            reservedStartDateTimePicker.MinDate = startDate;
            reservedStartDateTimePicker.CustomFormat = "yyyy-MM-dd";
            reservedEndDateTimePicker.Format = DateTimePickerFormat.Custom;
            reservedEndDateTimePicker.CustomFormat = "yyyy-MM-dd";
            reservedEndDateTimePicker.MinDate = reservedStartDateTimePicker.MinDate.AddDays(1);
        }

        private void senate_voting()
        {
            // Closing reserved seat voting
            timer1.Stop();
            reservedLabel.Text = "Voting Ended!";

            type = "Senate Seat";
            senateStartDateTimePicker.Enabled = true;
            senateEndDateTimePicker.Enabled = true;
            senateButton.Enabled = true;

            senateStartDateTimePicker.Format = DateTimePickerFormat.Custom;
            senateStartDateTimePicker.MinDate = startDate;
            senateStartDateTimePicker.CustomFormat = "yyyy-MM-dd";
            senateEndDateTimePicker.Format = DateTimePickerFormat.Custom;
            senateEndDateTimePicker.CustomFormat = "yyyy-MM-dd";
            senateEndDateTimePicker.MinDate = senateStartDateTimePicker.MinDate.AddDays(1);
        }

        private void pm_voting()
        {
            // Closing reserved seat voting
            timer1.Stop();
            senateLabel.Text = "Voting Ended!";

            type = "PM Seat";
            PMStartDateTimePicker.Enabled = true;
            PMEndDateTimePicker.Enabled = true;
            PMButton.Enabled = true;

            PMStartDateTimePicker.Format = DateTimePickerFormat.Custom;
            PMStartDateTimePicker.MinDate = startDate;
            PMStartDateTimePicker.CustomFormat = "yyyy-MM-dd";
            PMEndDateTimePicker.Format = DateTimePickerFormat.Custom;
            PMEndDateTimePicker.CustomFormat = "yyyy-MM-dd";
            PMEndDateTimePicker.MinDate = PMStartDateTimePicker.MinDate.AddDays(1);

        }

        private void check_inserted()
        {
            con.Open();
            string query = "select end_date from voting_time where seat_type = '" + type + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                timer1.Start();
                endDate = reader.GetDateTime(0);
                startDate = endDate;

                if (type == "Open Seat")
                {
                    openStartDateTimePicker.Enabled = false;
                    openEndDateTimePicker.Enabled = false;
                    openButton.Enabled = false;
                }
                else if (type == "Reserved Seat")
                {
                    reservedStartDateTimePicker.Enabled = false;
                    reservedEndDateTimePicker.Enabled = false;
                    reservedButton.Enabled = false;
                }
                else if (type == "Senate Seat")
                {
                    senateStartDateTimePicker.Enabled = false;
                    senateEndDateTimePicker.Enabled = false;
                    senateButton.Enabled = false;
                }
                else if (type == "PM Seat")
                {
                    PMStartDateTimePicker.Enabled = false;
                    PMEndDateTimePicker.Enabled = false;
                    PMButton.Enabled = false;
                }
            }
            con.Close();
        }

        private bool check_date()
        {
            con.Open();

            string query = "select end_date from voting_time where seat_type = '" + type + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (!reader.HasRows)
            {
                con.Close();
                return false;
            }

            DateTime dateTime = DateTime.Now;
            int num = dateTime.CompareTo(endDate);

            if (num > 0)
            {
                con.Close();
                set_check();               
                return true;
            }
            else
            {
                timer1.Start();
            }
                

            con.Close();
            return false;
        }

        public Election_Commission_Main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Election_Commission obj = new Election_Commission();
            this.Hide();
            obj.Show();
        }

        private void Election_Commission_Main_Load(object sender, EventArgs e)
        {
            type = "Open Seat";
            reservedStartDateTimePicker.Enabled = false;
            reservedEndDateTimePicker.Enabled = false;
            senateStartDateTimePicker.Enabled = false;
            senateEndDateTimePicker.Enabled = false;
            PMStartDateTimePicker.Enabled = false;
            PMEndDateTimePicker.Enabled = false;

            reservedButton.Enabled = false;
            senateButton.Enabled = false;
            PMButton.Enabled = false;

            DateTime dateTime = DateTime.UtcNow.Date;

            openStartDateTimePicker.Format = DateTimePickerFormat.Custom;
            openStartDateTimePicker.Value = dateTime;
            openStartDateTimePicker.MinDate = dateTime;
            openStartDateTimePicker.CustomFormat = "yyyy-MM-dd";
            
            openEndDateTimePicker.Format = DateTimePickerFormat.Custom;
            openEndDateTimePicker.Value = dateTime.AddDays(1);
            openEndDateTimePicker.MinDate = dateTime.AddDays(1);
            openEndDateTimePicker.CustomFormat = "yyyy-MM-dd";

            check_inserted();
            if (check_date())
            {
                reserved_voting();
                check_inserted();
                if (check_date())
                {
                    senate_voting();
                    check_inserted();
                    if (check_date())
                    {
                        pm_voting();
                        check_inserted();
                    }
                }
            }

            reservedStartDateTimePicker.Format = DateTimePickerFormat.Custom;
            reservedStartDateTimePicker.CustomFormat = "yyyy-MM-dd";
            reservedEndDateTimePicker.Format = DateTimePickerFormat.Custom;
            reservedEndDateTimePicker.CustomFormat = "yyyy-MM-dd";
            senateStartDateTimePicker.Format = DateTimePickerFormat.Custom;
            senateStartDateTimePicker.CustomFormat = "yyyy-MM-dd";
            senateEndDateTimePicker.Format = DateTimePickerFormat.Custom;
            senateEndDateTimePicker.CustomFormat = "yyyy-MM-dd";
            PMStartDateTimePicker.Format = DateTimePickerFormat.Custom;
            PMStartDateTimePicker.CustomFormat = "yyyy-MM-dd";
            PMEndDateTimePicker.Format = DateTimePickerFormat.Custom;
            PMEndDateTimePicker.CustomFormat = "yyyy-MM-dd";
        }

        private void openButton_Click(object sender, EventArgs e)
        { 
            press_button(openStartDateTimePicker.Text, openEndDateTimePicker.Text);
            check_inserted();
           
        }

        private void reservedButton_Click(object sender, EventArgs e)
        {
            press_button(reservedStartDateTimePicker.Text, reservedEndDateTimePicker.Text);
            check_inserted();
        }

        private void senateButton_Click(object sender, EventArgs e)
        {
            press_button(senateStartDateTimePicker.Text, senateEndDateTimePicker.Text);
            check_inserted();
        }

        private void PMButton_Click(object sender, EventArgs e)
        {
            press_button(PMStartDateTimePicker.Text, PMEndDateTimePicker.Text);
            check_inserted();
        }

        private void pm_button_Click(object sender, EventArgs e)
        {
            Election_Commission_PM obj = new Election_Commission_PM();
            obj.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime dt = DateTime.Now;
            TimeSpan value = endDate.Subtract(dt);

            int hours = (int)value.TotalHours;
            double minutes = (value.TotalHours - hours) * 60;
            double seconds = ((minutes - (int)minutes) * 60);

            if (type == "Open Seat")
            {
                openLabel.Text = hours + " : " + (int)minutes + " : " + (int)seconds;
                openLabel.Refresh();
                if (dt.CompareTo(endDate) > 0)
                {
                    set_check();
                    reserved_voting();
                }
            }
            else if (type == "Reserved Seat")
            {
                reservedLabel.Text = hours + " : " + (int)minutes + " : " + (int)seconds;
                reservedLabel.Refresh();
                if (dt.CompareTo(endDate) > 0)
                {
                    set_check();
                    senate_voting();
                }
            }
            else if (type == "Senate Seat")
            {
                senateLabel.Text = hours + " : " + (int)minutes + " : " + (int)seconds;
                senateLabel.Refresh();
                if (dt.CompareTo(endDate) > 0)
                {
                    set_check();
                    pm_voting();
                }
            }
            else if (type == "PM Seat")
            {
                PMLabel.Text = hours + " : " + (int)minutes + " : " + (int)seconds;
                PMLabel.Refresh();
                if (dt.CompareTo(endDate) > 0)
                {
                    set_check();
                    timer1.Enabled = false;
                    PMLabel.Text = "Voting Ended!";
                }
            }
        }
    }
}
