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
    public partial class Election_Commission_PM : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=e_ballot");

        public Election_Commission_PM()
        {
            InitializeComponent();
        }
        private void load_grid()
        {

            String query = "select ni.NAME , p.PARTY_NAME , count(vp.pm_candidate_cnic), ni.CNIC from nadra_info ni, party p left join voting_pm vp on p.party_leader = vp.pm_candidate_cnic where ni.CNIC = p.party_leader and p.PARTY_NAME <> 'Independent' group by(party_leader) order by count(vp.pm_candidate_cnic) desc;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            pmDataGridView1.Rows.Clear();

            while (reader.Read())
            {
                try
                {
                    pmDataGridView1.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                }
                catch
                {
                    con.Close();
                    break;
                }
            }
        }

        private void voting_open()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=e_ballot");
            string query = "select closed from voting_time where seat_type = 'PM Seat';";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (!reader.HasRows)
            {
                election_Label.Text = "PM Voting has not started yet!";
            }
            else if (reader.GetString(0) == "True")
            {
                DataGridViewRow row = pmDataGridView1.Rows[0];
                election_Label.Text = Convert.ToString(row.Cells[0].Value) + ", is elected as new Prime Minister of Pakistan";
            }
            else if (reader.GetString(0) == "False")
                election_Label.Text = "PM Voting is currently in progress!";

            con.Close();
        }

        private void Election_Commission_PM_Load(object sender, EventArgs e)
        {
            load_grid();
            voting_open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Election_Commission_Main obj = new Election_Commission_Main();
            obj.Show();
            this.Hide();
        }
    }
}
