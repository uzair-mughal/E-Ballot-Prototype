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

namespace Voter_Panel
{
    public partial class E_Voting_1 : Form
    {
        public MySqlDataReader reader1;
        public string pa_cad_cnic="";
        public string na_cad_cnic="";
        public E_Voting_1(MySqlDataReader temp)
        {
            reader1 = temp;
            InitializeComponent();
        }
        public void Load_personal_info()
        {
            reader1.Read();
            cnic_label.Text = reader1.GetString(0);
            name_label.Text = reader1.GetString(1);
            fname_label.Text = reader1.GetString(2);
            gender_label.Text = reader1.GetString(3);
            dob_label.Text = reader1.GetString(4);
            add_label.Text = reader1.GetString(7);
            na_reg_label.Text = reader1.GetString(8);
            pa_reg_label.Text = reader1.GetString(9);
            dist_label.Text = reader1.GetString(10);
            prov_label.Text = reader1.GetString(11);
        }
        
        public void load_pa_grid()
        {
            string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
            MySqlConnection con = new MySqlConnection(str);
            String query = "select ac.PA_REGION_ID, NAME, PARTY_NAME,ac.CNIC from nadra_info ni ,approved_candidates ac ,party p where ni.CNIC = ac.CNIC and ac.PARTY_ID = p.PARTY_ID and ac.PA_REGION_ID = " + pa_reg_label.Text + ";";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            pa_dataGridView.Rows.Clear();
            while (reader.Read())
            {
                try
                {
                    pa_dataGridView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                }
                catch
                {
                    con.Close();
                }
            }
        }

        public void load_na_grid()
        {
            string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
            MySqlConnection con = new MySqlConnection(str);
            String query = "select ac.NA_REGION_ID, NAME, PARTY_NAME, ac.CNIC from nadra_info ni ,approved_candidates ac ,party p where ni.CNIC = ac.CNIC and ac.PARTY_ID = p.PARTY_ID and ac.NA_REGION_ID = " + na_reg_label.Text + ";";

            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            na_dataGridView.Rows.Clear();
            while (reader.Read())
            {
                try
                {
                    na_dataGridView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                }
                catch
                {
                    con.Close();
                }
            }
        }

        public void check_voted()
        {
            string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
            MySqlConnection con = new MySqlConnection(str);
            String query = "select VOTER_CNIC from voting_open_seat vos where VOTER_CNIC ='" + cnic_label.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            try
            {
                reader.GetString(0);
                vote_button.Enabled = false;
                vote_label.Text = "Already Voted!"; 
            }
            catch
            {
                con.Close();
            }
        }

        private bool voting_open()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=e_ballot");
            string query = "select closed from voting_time where seat_type = 'Open Seat';";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (!reader.HasRows)
            {
                vote_button.Enabled = false;
                vote_label.Text = "Voting has not started yet!";
            }
            else if (reader.GetString(0) == "False")
            {
                vote_label.Text = "Voting has started!";
                con.Close();
                return true;
            }
            else if (reader.GetString(0) == "True")
            {
                vote_button.Enabled = false;
                vote_label.Text = "Voting has closed!";
            }
            con.Close();
            return false;
        }

        private void E_Voting_1_Load(object sender, EventArgs e)
        {
            Load_personal_info();
            if (voting_open())
            {
                load_pa_grid();
                load_na_grid();
            }
            check_voted();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = pa_dataGridView.Rows[rowIndex];
            pa_cad_cnic = Convert.ToString(row.Cells[3].Value);
            MessageBox.Show("Candidate Selected: " + Convert.ToString(row.Cells[0].Value));
        }

        private void na_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = na_dataGridView.Rows[rowIndex];
            na_cad_cnic = Convert.ToString(row.Cells[3].Value);
            MessageBox.Show("Candidate Selected: " + Convert.ToString(row.Cells[0].Value));
        }

        private void vote_button_Click(object sender, EventArgs e)
        {
            if (na_cad_cnic == "" || pa_cad_cnic == "")
            {
                MessageBox.Show("Please Select Both Candidates who you want to vote!");
            }
            else
            {
                string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
                MySqlConnection con = new MySqlConnection(str);
                String query = "insert into voting_open_seat values('" + cnic_label.Text + "','" + pa_cad_cnic + "','" + na_cad_cnic + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Your have voted sucesfully!");
                check_voted();
            }
        }

        private void quit_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void quit_button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
