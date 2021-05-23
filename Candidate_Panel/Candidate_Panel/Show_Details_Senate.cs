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
    public partial class Show_Details_Senate : Form
    {
        public string cnic;
        public Show_Details_Senate(string temp)
        {
            cnic = temp;
            InitializeComponent();
        }

        private bool voting_closed()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;port=3308;username=root;password=;database=e_ballot");
            string query = "select closed from voting_time where seat_type = 'Senate Seat';";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                if (reader.GetString(0) == "True")
                {
                    con.Close();
                    return true;
                }
            }
            con.Close();
            return false;
        }

        public void load_details()
        {
            string str = "server=localhost;port=3308;username=root;password=;database=e_ballot";
            MySqlConnection con = new MySqlConnection(str);
            con.Open();
            String query = "select * from senate_approved_candidates where cnic = '" + cnic + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                reader.Read();
                prov_label.Text = reader.GetString(1);
            }
            catch
            {
                con.Close();
            }
        }

        public void Load_grid()
        {
            string str = "server=localhost;port=3308;username=root;password=;database=e_ballot";
            MySqlConnection con = new MySqlConnection(str);
            con.Open();
            String query = "select ni.NAME , p.PARTY_NAME , count(*) ,ni.CNIC from voting_senate vs , senate_approved_candidates sac , nadra_info ni, party p where vs.SENATE_CANDIDATE_CNIC = sac.CNIC and sac.CNIC = ni.CNIC and sac.PARTY_ID = p.PARTY_ID and sac.PROVINCE = '"+prov_label.Text+"' group by(vs.SENATE_CANDIDATE_CNIC) order by count(*) desc;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            comp_dataGridView.Rows.Clear();

            while (reader.Read())
            {
                try
                {
                    comp_dataGridView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                }
                catch
                {
                    con.Close();
                    break;
                }
            }
        }

        private bool check_won()
        {
            int req_vote = 0;

            if (prov_label.Text == "Sindh")
                req_vote = 241 / 25;
            else if (prov_label.Text == "Punjab")
                req_vote = 540 / 25;
            else if (prov_label.Text == "Balochistan")
                req_vote = 107 / 25;
            else if (prov_label.Text == "Khyber Pakhtunkhawa")
                req_vote = 209 / 25;

            MessageBox.Show(req_vote.ToString());

            while (true)
            {
                try
                {
                    int i = 0;
                    DataGridViewRow row = comp_dataGridView.Rows[i];
                    if (cnic == Convert.ToString(row.Cells[3].Value))
                    {
                        if (Convert.ToInt32(row.Cells[2].Value) >= req_vote)
                        {
                            return true;
                        }
                    }
                    i++;
                }
                catch
                {
                    break;
                }
            }
            return false;
        }

        private void Show_Details_Senate_Load(object sender, EventArgs e)
        {
            load_details();
            Load_grid();

            if (voting_closed())
            {
                if (check_won())
                {
                    status_label.Text = "Won!";
                }
                else
                {
                    status_label.Text = "Lost!";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            E_Ballot_1 obj = new E_Ballot_1();
            this.Hide();
            obj.Show();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            E_Ballot_1 obj = new E_Ballot_1();
            this.Hide();
            obj.Show();
        }
    }
}
