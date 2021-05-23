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
    public partial class Show_Deatils : Form
    {
        public string cnic;
        public Show_Deatils(string temp)
        {
            cnic = temp;
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            E_Ballot_1 obj = new E_Ballot_1();
            this.Hide();
            obj.Show();
        }

        private bool voting_closed()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;port=3308;username=root;password=;database=e_ballot");
            string query = "select closed from voting_time where seat_type = 'Open Seat';";
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

        private bool check_won()
        {
            DataGridViewRow row = comp_dataGridView.Rows[0];
            if(cnic == Convert.ToString(row.Cells[3].Value))
            {
                return true;
            }
            return false;
        }

        public void load_seat_desc()
        {
            string pa_region = "NULL";
            string na_region = "NULL";

            string str = "server=localhost;port=3308;username=root;password=;database=e_ballot";
            MySqlConnection con = new MySqlConnection(str);
            con.Open();
            String query = "select * from approved_candidates ac where cnic = '" + cnic + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    cnic = reader.GetString(0);

                    if (reader.IsDBNull(1))
                        pa_region = "NULL";
                    else
                        pa_region = reader.GetString(1);

                    if (reader.IsDBNull(2))
                        na_region = "NULL";
                    else
                        na_region = reader.GetString(2);
                }
                catch
                {
                    con.Close();
                    break;
                }
            }

            if (pa_region != "NULL")
            {
                desg_label.Text = "MPA";
                str = "server=localhost;port=3308;username=root;password=;database=e_ballot";
                con = new MySqlConnection(str);
                con.Open();
                query = "select l.PROVINCE ,l.DISTRICT, pr.REGION, pr.PA_REGION_ID from pa_region pr ,locations l where l.LOC_ID =pr.LOC_ID and pr.PA_REGION_ID = '" + pa_region + "';";
                cmd = new MySqlCommand(query, con);
                reader = cmd.ExecuteReader();
                reader.Read();
                prov_label.Text = reader.GetString(0);
                dist_label.Text = reader.GetString(1);
                reg_label.Text = reader.GetString(2);
                regid_label.Text = reader.GetString(3);
                con.Close();
            }
            else
            {
                desg_label.Text = "MNA";
                str = "server=localhost;port=3308;username=root;password=;database=e_ballot";
                con = new MySqlConnection(str);
                con.Open();
                query = "select l.PROVINCE ,l.DISTRICT, nr.REGION, nr.NA_REGION_ID from na_region nr ,locations l where l.LOC_ID =nr.LOC_ID and nr.NA_REGION_ID = '" + na_region + "';";
                cmd = new MySqlCommand(query, con);
                reader = cmd.ExecuteReader();
                reader.Read();
                prov_label.Text = reader.GetString(0);
                dist_label.Text = reader.GetString(1);
                reg_label.Text = reader.GetString(2);
                regid_label.Text = reader.GetString(3);
                con.Close();
            }
        }

        public void load_grid()
        {
            if (desg_label.Text == "MNA")
            {
                string str = "server=localhost;port=3308;username=root;password=;database=e_ballot";
                MySqlConnection con = new MySqlConnection(str);
                con.Open();
                String query = "select ni.NAME ,p.PARTY_NAME,count(*),ni.CNIC from voting_open_seat vos,approved_candidates ac,na_region nr, party p,nadra_info ni " +
                    "where vos.NA_CANDIDATE_CNIC = ac.CNIC and ac.NA_REGION_ID = nr.NA_REGION_ID and ac.PARTY_ID = p.PARTY_ID and ni.CNIC = vos.NA_CANDIDATE_CNIC and " +
                    "nr.NA_REGION_ID = '" + regid_label.Text + "' group by(NA_CANDIDATE_CNIC) order by count(*) desc;";
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
            else
            {
                string str = "server=localhost;port=3308;username=root;password=;database=e_ballot";
                MySqlConnection con = new MySqlConnection(str);
                con.Open();
                String query = "select ni.NAME ,p.PARTY_NAME,count(*),ni.CNIC from voting_open_seat vos,approved_candidates ac,pa_region pr, party p,nadra_info ni " +
                    "where vos.PA_CANDIDATE_CNIC = ac.CNIC and ac.PA_REGION_ID = pr.PA_REGION_ID and ac.PARTY_ID = p.PARTY_ID and ni.CNIC = vos.PA_CANDIDATE_CNIC and " +
                    "pr.PA_REGION_ID = '" + regid_label.Text + "' group by(PA_CANDIDATE_CNIC) order by count(*) desc;";
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

        }
        private void Show_Deatils_Load(object sender, EventArgs e)
        {
            
        }

        private void Show_Deatils_Load_1(object sender, EventArgs e)
        {
            load_seat_desc();
            load_grid();

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

        private void comp_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
