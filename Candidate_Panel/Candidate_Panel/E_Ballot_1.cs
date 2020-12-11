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

namespace Candidate_Panel
{
    public partial class E_Ballot_1 : Form
    {
        public static String cnic;
        public E_Ballot_1(String temp)
        {
            cnic = temp;
            InitializeComponent();
        }
        public E_Ballot_1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void check_apply()
        {

            string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
            MySqlConnection con = new MySqlConnection(str);
            String query = "select cnic from candidancy_request where cnic = " + cnic + ";";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                reader.Read();
                reader.GetString(0);
                status_label.Text = "Pending";
                apply_button.Enabled = false;
                con.Close();
            }
            catch
            {
                con.Close();
            }

            query = "select cnic from approved_candidates where cnic = " + cnic + ";";
            cmd = new MySqlCommand(query, con);
            con.Open();
            reader = cmd.ExecuteReader();

            try
            {
                reader.Read();
                reader.GetString(0);
                status_label.Text = "Approved";
                apply_button.Enabled = false;
                details_button.Enabled = true;
                con.Close();
            }
            catch
            {
                con.Close();
            }

            query = "select cnic from reserved_candidancy_request where cnic = " + cnic + ";";
            cmd = new MySqlCommand(query, con);
            con.Open();
            reader = cmd.ExecuteReader();

            try
            {
                reader.Read();
                reader.GetString(0);
                status_label.Text = "Pending";
                apply_button.Enabled = false;
                con.Close();
            }
            catch
            {
                con.Close();
            }

            query = "select cnic from reserved_approved_candidates where cnic = " + cnic + ";";
            cmd = new MySqlCommand(query, con);
            con.Open();
            reader = cmd.ExecuteReader();

            try
            {
                reader.Read();
                reader.GetString(0);
                status_label.Text = "Approved";
                apply_button.Enabled = false;
                details_button.Enabled = true;
                con.Close();
            }
            catch
            {
                con.Close();
            }
        }
        private void E_Ballot_1_Load(object sender, EventArgs e)
        {
            details_button.Enabled = false;

            string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
            MySqlConnection con = new MySqlConnection(str);
            con.Open();
            String query = "select * from nadra_info where cnic=" + cnic + "";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            cnic_label.Text = reader.GetString(0);
            name_label.Text = reader.GetString(1);
            fname_label.Text = reader.GetString(2);
            gender_label.Text = reader.GetString(3);
            dob_label.Text = reader.GetString(4);
            add_label.Text = reader.GetString(7);
            dist_label.Text = reader.GetString(10);
            prov_label.Text = reader.GetString(11);
            con.Close();

            check_apply();

        }

        private void quit_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            Apply obj = new Apply(cnic);
            this.Hide();
            obj.Show();
        }

        private void details_button_Click(object sender, EventArgs e)
        {
            Show_Deatils obj = new Show_Deatils(cnic);
            this.Hide();
            obj.Show();
        }
    }
}
