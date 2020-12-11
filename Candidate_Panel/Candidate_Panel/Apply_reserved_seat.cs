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
    public partial class Apply_reserved_seat : Form
    {
        public static String cnic;
        public string party;
        public bool check = true;
        public Apply_reserved_seat(string temp, String temp1)
        {
            party = temp;
            cnic = temp1;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            E_Ballot_1 obj = new E_Ballot_1();
            this.Hide();
            obj.Show();
        }

        private void Apply_reserved_seat_Load(object sender, EventArgs e)
        {
            cnic_label.Text = cnic;
            party_label.Text = party;

        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            

            if (desg_comboBox.Text == "" || type_comboBox.Text == "" || prov_comboBox.Text == "")
                check = false;

            if (prov_comboBox.Enabled == false && desg_comboBox.Text != "" && type_comboBox.Text != "")
                check = true;

            if (prov_comboBox.Enabled == true && desg_comboBox.Text != "" && type_comboBox.Text != "" && prov_comboBox.Text != "")
                check = true;

            if (check)
            {
                string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
                MySqlConnection con = new MySqlConnection(str);
                String query = "select PARTY_ID from party where PARTY_NAME = '" + party + "';";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int party_id = Convert.ToInt32(reader.GetString(0));
                con.Close();
                if (desg_comboBox.Text == "MPA")
                    query = "insert into reserved_candidancy_request values('" + cnic + "','" + prov_comboBox.Text + "',NULL,'" + party_id + "','" + type_comboBox.Text + "');";
                else if (desg_comboBox.Text == "MNA")
                    if (type_comboBox.Text == "NM")
                        query = "insert into reserved_candidancy_request values('" + cnic + "',NULL,'ALL','" + party_id + "','" + type_comboBox.Text + "');";
                    else
                        query = "insert into reserved_candidancy_request values('" + cnic + "',NULL,'" + prov_comboBox.Text + "','" + party_id + "','" + type_comboBox.Text + "');";
                cmd = new MySqlCommand(query, con);
                con.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Application is sent for approval!");
                E_Ballot_1 obj = new E_Ballot_1();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Please fill all teh fields!");
            }
            
        }

        private void type_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (desg_comboBox.Text == "MNA" && type_comboBox.Text == "NM")
            {
                prov_comboBox.Enabled = false;
            }
            else
            {
                prov_comboBox.Enabled = true;
            }
        }

        private void desg_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (desg_comboBox.Text == "MNA" && type_comboBox.Text == "NM")
            {
                prov_comboBox.Enabled = false;
            }
            else
            {
                prov_comboBox.Enabled = true;
            }
        }
    }
}
