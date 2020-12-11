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
    public partial class Election_Commission : Form
    {
        //for open seats
        public string nic="NULL";
        public string na_reg;
        public string pa_reg;
        public string partyid;

        //for reserved seats
        public string nic1 = "NULL";
        public string na_prov;
        public string pa_prov;
        public string partyid1;
        public string seat_type;

        public Election_Commission()
        {
            InitializeComponent();
        }
        public void load_grid_open_seat()
        {
            string str = "server=localhost;port=3306;username=root;password=;database=e_ballot;";
            MySqlConnection con = new MySqlConnection(str);
            con.Open();
            string query = "select ni.NAME ,cr.PA_REGION_ID ,cr.NA_REGION_ID ,p.PARTY_NAME ,cr.CNIC ,p.PARTY_ID from candidancy_request cr,nadra_info ni,party p where cr.CNIC =ni.CNIC and cr.PARTY_ID =p.PARTY_ID ;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            open_seat_dataGridView.Rows.Clear();

            try
            {
                while (reader.Read())
                {
                    if (reader.IsDBNull(1))
                        pa_reg = "NULL";
                    else
                        pa_reg = reader.GetString(1);
                    if (reader.IsDBNull(2))
                        na_reg = "NULL";
                    else
                        na_reg = reader.GetString(2);

                    open_seat_dataGridView.Rows.Add(reader.GetString(0), pa_reg, na_reg, reader.GetString(3), reader.GetString(4), reader.GetString(5));
                }
            }
            catch
            {
                con.Close();
            }
        }

        public void load_grid_reserved()
        {
            string str = "server=localhost;port=3306;username=root;password=;database=e_ballot;";
            MySqlConnection con = new MySqlConnection(str);
            con.Open();
            string query = "select ni.NAME ,rcr.PA_PROVINCE ,rcr.NA_PROVINCE ,p.PARTY_NAME, rcr.SEAT_TYPE ,rcr.CNIC ,p.PARTY_ID from reserved_candidancy_request rcr ,nadra_info ni,party p where rcr.CNIC =ni.CNIC and rcr.PARTY_ID =p.PARTY_ID;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            reserved_dataGridView.Rows.Clear();

            try
            {
                while (reader.Read())
                {
                    if (reader.IsDBNull(1))
                        pa_prov = "NULL";
                    else
                        pa_prov = reader.GetString(1);
                    if (reader.IsDBNull(2))
                        na_prov = "NULL";
                    else
                        na_prov = reader.GetString(2);

                    reserved_dataGridView.Rows.Add(reader.GetString(0), pa_prov, na_prov, reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));

                }
            }
            catch
            {
                con.Close();
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Election_Commission_Load(object sender, EventArgs e)
        {
            load_grid_open_seat();
            load_grid_reserved();
        }

        private void approval_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = open_seat_dataGridView.Rows[rowIndex];
            nic = Convert.ToString(row.Cells[4].Value);
            pa_reg = Convert.ToString(row.Cells[1].Value);
            na_reg = Convert.ToString(row.Cells[2].Value);
            partyid = Convert.ToString(row.Cells[5].Value);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void approve_button_Click(object sender, EventArgs e)
        {
            if (nic != "NULL")
            {
                string str = "server=localhost;port=3306;username=root;password=;database=e_ballot;";
                MySqlConnection con = new MySqlConnection(str);
                con.Open();
                string query = "insert into approved_candidates values(" + nic + "," + pa_reg + "," + na_reg + "," + partyid + ");";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteReader();
                con.Close();
                query = "delete from candidancy_request where cnic=" + nic + ";";
                cmd = new MySqlCommand(query, con);
                con.Open();
                cmd.ExecuteReader();
                load_grid_open_seat();
                con.Close();
            }
            else
            {
                MessageBox.Show("Please select a candidate!");
            }
            
        }
        private void reject_button_Click(object sender, EventArgs e)
        {
            string str = "server=localhost;port=3306;username=root;password=;database=e_ballot;";
            MySqlConnection con = new MySqlConnection(str);
            con.Open();
            string query = "delete from candidancy_request where cnic=" + nic + ";";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteReader();
            load_grid_open_seat();
            con.Close();
        }

        private void reserved_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = reserved_dataGridView.Rows[rowIndex];
            nic1 = Convert.ToString(row.Cells[5].Value);
            pa_prov = Convert.ToString(row.Cells[1].Value);
            na_prov = Convert.ToString(row.Cells[2].Value);
            partyid1 = Convert.ToString(row.Cells[6].Value);
            seat_type = Convert.ToString(row.Cells[4].Value);
        }

        

        private void approve_button1_Click(object sender, EventArgs e)
        {
            if (nic1 != "NULL")
            {
                string str = "server=localhost;port=3306;username=root;password=;database=e_ballot;";
                MySqlConnection con = new MySqlConnection(str);
                con.Open();
                string query = "insert into reserved_approved_candidates values('" + nic1 + "'," + pa_prov + ",'" + na_prov + "','" + partyid1 + "','" + seat_type + "');";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteReader();
                con.Close();
                query = "delete from reserved_candidancy_request where cnic=" + nic1 + ";";
                cmd = new MySqlCommand(query, con);
                con.Open();
                cmd.ExecuteReader();
                load_grid_reserved();
                con.Close();
            }
            else
            {
                MessageBox.Show("Please select a candidate!");
            }
        }

        private void reject_button1_Click(object sender, EventArgs e)
        {
            string str = "server=localhost;port=3306;username=root;password=;database=e_ballot;";
            MySqlConnection con = new MySqlConnection(str);
            con.Open();
            string query = "delete from reserved_candidancy_request where cnic=" + nic1 + ";";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteReader();
            load_grid_reserved();
            con.Close();
        }
    }
}