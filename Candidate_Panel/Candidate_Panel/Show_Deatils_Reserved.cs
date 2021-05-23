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
    public partial class Show_Deatils_Reserved : Form
    {
        public string cnic;
        public Show_Deatils_Reserved(string temp)
        {

            cnic = temp;
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            E_Ballot_1 obj = new E_Ballot_1();
            this.Hide();
            obj.Show();
        }

        public void load_details()
        {

            string str = "server=localhost;port=3308;username=root;password=;database=e_ballot";
            MySqlConnection con = new MySqlConnection(str);
            con.Open();
            String query = "select * from reserved_approved_candidates where cnic = '" + cnic + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    cnic = reader.GetString(0);

                    if (!reader.IsDBNull(1))
                    {
                        prov_label.Text = reader.GetString(1);
                        desg_label.Text = "MPA";
                    }
                        

                    if (!reader.IsDBNull(2))
                    {
                        prov_label.Text = reader.GetString(2);
                        desg_label.Text = "MNA";
                    }

                    type_label.Text = reader.GetString(4);
                        
                }
                catch
                {
                    con.Close();
                    break;
                }
            }
        }

        public void load_grid()
        {
            if(desg_label.Text == "MPA" && type_label.Text == "W")
            {
                string str = "server=localhost;port=3308;username=root;password=;database=e_ballot";
                MySqlConnection con = new MySqlConnection(str);
                con.Open();
                String query = "select ni.NAME , p.PARTY_NAME , count(*),ni.CNIC from voting_pa_reserved_seat vprs, reserved_approved_candidates rac, nadra_info ni, party p where vprs.WOMAN_CANDIDATE_CNIC = rac.CNIC and vprs.WOMAN_CANDIDATE_CNIC = ni.CNIC and rac.PARTY_ID =p.PARTY_ID and rac.SEAT_TYPE ='W' group by(WOMAN_CANDIDATE_CNIC) order by count(*) desc;";
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
            else if(desg_label.Text == "MPA" && type_label.Text == "NM")
            {
                string str = "server=localhost;port=3308;username=root;password=;database=e_ballot";
                MySqlConnection con = new MySqlConnection(str);
                con.Open();
                String query = "select ni.NAME , p.PARTY_NAME , count(*),ni.CNIC from voting_pa_reserved_seat vprs, reserved_approved_candidates rac, nadra_info ni, party p where vprs.NM_CANDIDATE_CNIC = rac.CNIC and vprs.NM_CANDIDATE_CNIC = ni.CNIC and rac.PARTY_ID =p.PARTY_ID and rac.SEAT_TYPE ='NM' group by(NM_CANDIDATE_CNIC) order by count(*) desc;";
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
            else if(desg_label.Text == "MNA" && type_label.Text == "W")
            {
                string str = "server=localhost;port=3308;username=root;password=;database=e_ballot";
                MySqlConnection con = new MySqlConnection(str);
                con.Open();
                String query = "select ni.NAME , p.PARTY_NAME , count(*),ni.CNIC from voting_na_reserved_seat vnrs, reserved_approved_candidates rac, nadra_info ni, party p where vnrs.WOMAN_CANDIDATE_CNIC = rac.CNIC and vnrs.WOMAN_CANDIDATE_CNIC = ni.CNIC and rac.PARTY_ID =p.PARTY_ID and rac.SEAT_TYPE ='W' group by(WOMAN_CANDIDATE_CNIC) order by count(*) desc;";
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
            else if(desg_label.Text == "MNA" && type_label.Text == "NM")
            {
                string str = "server=localhost;port=3308;username=root;password=;database=e_ballot";
                MySqlConnection con = new MySqlConnection(str);
                con.Open();
                String query = "select ni.NAME , p.PARTY_NAME , count(*),ni.CNIC from voting_na_reserved_seat vnrs, reserved_approved_candidates rac, nadra_info ni, party p where vnrs.NM_CANDIDATE_CNIC = rac.CNIC and vnrs.NM_CANDIDATE_CNIC = ni.CNIC and rac.PARTY_ID =p.PARTY_ID and rac.SEAT_TYPE ='NM' group by(NM_CANDIDATE_CNIC) order by count(*) desc;";
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

        private bool check_won()
        {
            string designation = desg_label.Text[1].ToString() + desg_label.Text[2].ToString();
            string temp = designation.ToLower();
            string candidate;

            if (type_label.Text == "W")
            {
                designation += "_WOMEN_SEATS";
                candidate = "WOMAN_CANDIDATE_CNIC";
            }
            else
            {
                designation += "_NON_MUSLIMS_SEATS";
                candidate = "NON_MUSLIMS_CANDIDATE_CNIC";
            }

            MySqlConnection con = new MySqlConnection("server=localhost;port=3308;username=root;password=;database=e_ballot");
            string query = "select " + designation + " from reserved_seats where PROVINCE = '" + prov_label.Text + "';";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            int req_seats = reader.GetInt32(0);

            con.Close();
            con.Open();

            query = "select " + candidate + " from voting_" + temp + "_reserved_seat group by (" + candidate + ") order by count(*) desc limit " + req_seats + ";";
            cmd = new MySqlCommand(query, con);
            reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                try
                {
                    if (cnic == reader.GetString(0))
                        return true;
                }
                catch
                {
                    con.Close();
                    break;
                }
            }
            return false;
        }

        private bool voting_closed()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;port=3308;username=root;password=;database=e_ballot");
            string query = "select closed from voting_time where seat_type = 'Reserved Seat';";
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

        private void Show_Deatils_Reserved_Load(object sender, EventArgs e)
        {
            load_details();
            load_grid();
            check_won();

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
    }
}
