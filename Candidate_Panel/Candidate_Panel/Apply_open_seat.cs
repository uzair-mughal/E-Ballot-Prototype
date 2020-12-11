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
    public partial class Apply_open_seat : Form
    {
        public string party;
        public int reg;
        public static String cnic;
        public int regionid=0;
        public Apply_open_seat(string temp,String temp1)
        {
            party = temp;
            cnic = temp1;
            InitializeComponent();
        }

        private void load_data()
        {
            if (desg_comboBox.Text == "MPA")
            {
                string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
                MySqlConnection con = new MySqlConnection(str);
                con.Open();
                String query = "select PA_REGION_ID,DISTRICT, REGION from locations l , pa_region pr where DISTRICT = '" + dist_comboBox.Text + "' and l.LOC_ID = pr.LOC_ID;";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                region_dataGridView.Rows.Clear();
                try
                {
                    while (reader.Read())
                    {
                        region_dataGridView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                    }
                }
                catch
                {
                    con.Close();
                }
            }
            if (desg_comboBox.Text == "MNA")
            {
                string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
                MySqlConnection con = new MySqlConnection(str);
                con.Open();
                String query = "select NA_REGION_ID,DISTRICT, REGION from locations l , na_region pr where DISTRICT = '" + dist_comboBox.Text + "' and l.LOC_ID = pr.LOC_ID;";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                region_dataGridView.Rows.Clear();
                try
                {
                    while (reader.Read())
                    {
                        region_dataGridView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                    }
                }
                catch
                {
                    con.Close();
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
            MySqlConnection con = new MySqlConnection(str);
            con.Open();
            String query = "select DISTRICT from locations where PROVINCE = '" + prov_comboBox.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            dist_comboBox.Items.Clear();
            try
            {
                while (reader.Read())
                {
                    dist_comboBox.Items.Add(reader.GetString(0));
                }
            }
            catch
            {
                con.Close();
            }
            load_data();
        }

        private void desg_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data();
        }

        private void region_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = region_dataGridView.Rows[rowIndex];
            regionid = Convert.ToInt32(row.Cells[0].Value);
            reg = Convert.ToInt32(row.Cells[2].Value);
            
        }

        private void dist_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data();
        }

        private void Apply_open_seat_Load(object sender, EventArgs e)
        {
            party_label.Text = party;
            cnic_label.Text = cnic;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Apply obj = new Apply();
            this.Hide();
            obj.Show();
        }


        private void apply_button_Click_1(object sender, EventArgs e)
        {
            if (regionid == 0)
            {
                MessageBox.Show("Please select a Region!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Apply for Province : " + prov_comboBox.Text + ", District: " + dist_comboBox.Text + "" +
                                                        ", Region ID: " + regionid + ", Region number: " + reg + "", "Confirmation!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
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
                        query = "insert into candidancy_request values(" + Convert.ToInt64(cnic) + "," + regionid + ",NULL," + party_id + ");";
                    else if (desg_comboBox.Text == "MNA")
                        query = "insert into candidancy_request values(" + Convert.ToInt64(cnic) + ",NULL," + regionid + "," + party_id + ");";
                    cmd = new MySqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteReader();
                    MessageBox.Show("Application is sent for approval!");
                    E_Ballot_1 obj = new E_Ballot_1();
                    this.Hide();
                    obj.Show();
                }
            }
            
        }

        private void back_button_Click_1(object sender, EventArgs e)
        {
            E_Ballot_1 obj = new E_Ballot_1();
            this.Hide();
            obj.Show();
        }

        private void cnic_label_Click(object sender, EventArgs e)
        {

        }
    }
}
