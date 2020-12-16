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
    public partial class Apply_senate_seat : Form
    {
        public string cnic;
        public string party;
        public Apply_senate_seat(string temp, String temp1)
        {
            party = temp;
            cnic = temp1;
            InitializeComponent();
        }

        private void Apply_senate_seat_Load(object sender, EventArgs e)
        {
            cnic_label.Text = cnic;
            party_label.Text = party;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            E_Ballot_1 obj = new E_Ballot_1();
            this.Hide();
            obj.Show();
        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            if (prov_comboBox.Text != "")
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
                query = "insert into senate_candidancy_request values('"+cnic+"','"+prov_comboBox.Text+"',"+party_id+");";
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
                MessageBox.Show("Please select a province");
            }
        }
    }
}
