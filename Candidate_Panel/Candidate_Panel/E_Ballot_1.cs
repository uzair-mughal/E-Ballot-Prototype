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
        public string pa_region = "NULL";
        public string na_region = "NULL";
        public string women_cnic = "NULL";
        public string nonmuslim_cnic = "NULL";
        public bool reserved_won_check = false;
        public string senate_cnic = "NULL";
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
                Seat_Type_Label.Text = "Open Seat";
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
                Seat_Type_Label.Text = "Open Seat";
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
                Seat_Type_Label.Text = "Reserved Seat";
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
                Seat_Type_Label.Text = "Reserved Seat";
                apply_button.Enabled = false;
                details_button.Enabled = true;
                con.Close();
            }
            catch
            {
                con.Close();
            }

            query = "select cnic from senate_candidancy_request where cnic = " + cnic + ";";
            cmd = new MySqlCommand(query, con);
            con.Open();
            reader = cmd.ExecuteReader();

            try
            {
                reader.Read();
                reader.GetString(0);
                status_label.Text = "Pending";
                Seat_Type_Label.Text = "Senate Seat";
                apply_button.Enabled = false;
                con.Close();
            }
            catch
            {
                con.Close();
            }

            query = "select cnic from senate_approved_candidates where cnic = " + cnic + ";";
            cmd = new MySqlCommand(query, con);
            con.Open();
            reader = cmd.ExecuteReader();

            try
            {
                reader.Read();
                reader.GetString(0);
                status_label.Text = "Approved";
                Seat_Type_Label.Text = "Senate Seat";
                apply_button.Enabled = false;
                details_button.Enabled = true;
                con.Close();
            }
            catch
            {
                con.Close();
            }
        }

        public void check_if_won_open_seat()
        {          
            string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
            MySqlConnection con = new MySqlConnection(str);
            con.Open();
            String query = "select * from approved_candidates ac where cnic = '" + cnic + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            string temp_cnic = "NULL";

            try
            {
                reader.Read();
                temp_cnic = reader.GetString(0);

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
            }
 
            if (temp_cnic != "NULL")
            {
                if (na_region != "NULL")
                {
                    str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
                    con = new MySqlConnection(str);
                    con.Open();
                    query = "select ni.CNIC,count(*) from voting_open_seat vos,approved_candidates ac,na_region nr,nadra_info ni where vos.NA_CANDIDATE_CNIC = ac.CNIC and ac.NA_REGION_ID = nr.NA_REGION_ID and ni.CNIC = vos.NA_CANDIDATE_CNIC and nr.NA_REGION_ID ="+na_region+" group by(NA_CANDIDATE_CNIC) order by count(*) desc;";
                    cmd = new MySqlCommand(query, con);
                    reader = cmd.ExecuteReader();
                    try
                    {
                        reader.Read();
                        if (temp_cnic == reader.GetString(0))
                        { 
                            tabPage2.Enabled = true;
                            tabPage3.Enabled = true;
                            status_label.Text = "MNA";
                        }
                        con.Close();
                    }
                    catch
                    {
                        con.Close();
                    }
                }

                if (pa_region != "NULL")
                {
                    str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
                    con = new MySqlConnection(str);
                    con.Open();
                    query = "select ni.CNIC ,count(*) from voting_open_seat vos,approved_candidates ac,pa_region pr,nadra_info ni where vos.PA_CANDIDATE_CNIC = ac.CNIC and ac.PA_REGION_ID = pr.PA_REGION_ID and ni.CNIC = vos.PA_CANDIDATE_CNIC and pr.PA_REGION_ID = "+pa_region+" group by(PA_CANDIDATE_CNIC) order by count(*) desc;";
                    cmd = new MySqlCommand(query, con);
                    reader = cmd.ExecuteReader();

                    try
                    {
                        reader.Read();
                        if (temp_cnic == reader.GetString(0))
                        {
                            tabPage2.Enabled = true;
                            tabPage3.Enabled = true;
                            status_label.Text = "MPA";
                        }
                        con.Close();
                    }
                    catch
                    {
                        con.Close();
                    }
                    
                }
                
            }        
        }

        public void find_prvince()
        {
            if (status_label.Text == "MPA")
            {
                string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
                MySqlConnection con = new MySqlConnection(str);
                con.Open();
                String query = "select l.PROVINCE from pa_region pr ,locations l where l.LOC_ID =pr.LOC_ID and pr.PA_REGION_ID = '" + pa_region + "';";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                seat_prov_label.Text = reader.GetString(0);
            }
            else if(status_label.Text == "MNA")
            {
                string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
                MySqlConnection con = new MySqlConnection(str);
                con.Open();
                String query = "select l.PROVINCE from na_region nr ,locations l where l.LOC_ID =nr.LOC_ID and nr.NA_REGION_ID = '" + na_region + "';";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                seat_prov_label.Text = reader.GetString(0);
            }
            

        }

        public void Load_grids_resereved()
        {
            if (status_label.Text == "MPA")
            {
                string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
                MySqlConnection con = new MySqlConnection(str);
                String query = "select ni.NAME,p.PARTY_NAME,rac.PA_PROVINCE,ni.CNIC from reserved_approved_candidates rac,nadra_info ni,party p where rac.CNIC =ni.CNIC and rac.PARTY_ID =p.PARTY_ID and SEAT_TYPE ='W';";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                women_dataGridView.Rows.Clear();

                while (reader.Read())
                {
                    try
                    {
                        women_dataGridView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    }
                    catch
                    {
                        con.Close();
                    }
                }

                str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
                con = new MySqlConnection(str);
                query = "select ni.NAME,p.PARTY_NAME,rac.PA_PROVINCE,ni.CNIC from reserved_approved_candidates rac,nadra_info ni,party p where rac.CNIC =ni.CNIC and rac.PARTY_ID =p.PARTY_ID and SEAT_TYPE ='NM';";
                con.Open();
                cmd = new MySqlCommand(query, con);
                reader = cmd.ExecuteReader();
                nonmuslim_dataGridView.Rows.Clear();
                
                while (reader.Read())
                {
                    try
                    {
                        nonmuslim_dataGridView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    }
                    catch
                    {
                        con.Close();
                    }
                }
            }
            else if (status_label.Text == "MNA")
            {
                string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
                MySqlConnection con = new MySqlConnection(str);
                String query = "select ni.NAME,p.PARTY_NAME,rac.NA_PROVINCE ,ni.CNIC from reserved_approved_candidates rac,nadra_info ni,party p where rac.CNIC =ni.CNIC and rac.PARTY_ID =p.PARTY_ID and SEAT_TYPE ='W';";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                women_dataGridView.Rows.Clear();

                while (reader.Read())
                {
                    try
                    {
                        women_dataGridView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    }
                    catch
                    {
                        con.Close();
                    }
                }

                str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
                con = new MySqlConnection(str);
                query = "select ni.NAME,p.PARTY_NAME,rac.NA_PROVINCE,ni.CNIC from reserved_approved_candidates rac,nadra_info ni,party p where rac.CNIC =ni.CNIC and rac.PARTY_ID = p.PARTY_ID and SEAT_TYPE ='NM';";
                con.Open();
                cmd = new MySqlCommand(query, con);
                reader = cmd.ExecuteReader();
                nonmuslim_dataGridView.Rows.Clear();

                while (reader.Read())
                {
                    try
                    {
                        
                        nonmuslim_dataGridView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    }
                    catch
                    {
                        con.Close();
                    }
                }
            }
            
        }

        public void find_province_reserved()
        {
            //checking in pa women category
            string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
            MySqlConnection con = new MySqlConnection(str);
            con.Open();
            String query = "select rac.PA_PROVINCE from reserved_approved_candidates rac where rac.SEAT_TYPE = 'W' and rac.CNIC = '" + cnic + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                reader.Read();
                seat_prov_label.Text = reader.GetString(0);
                con.Close();
                return;
            }
            catch
            {
                con.Close();
            }

            //checking in pa non muslim category
            str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
            con = new MySqlConnection(str);
            con.Open();
            query = "select rac.PA_PROVINCE from reserved_approved_candidates rac where rac.SEAT_TYPE = 'NM' and rac.CNIC = '" + cnic + "';";
            cmd = new MySqlCommand(query, con);
            reader = cmd.ExecuteReader();
            
            try
            {
                reader.Read();
                seat_prov_label.Text = reader.GetString(0);
                con.Close();
                return;
            }
            catch
            {
                con.Close();
            }


            //checking in na women category
            str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
            con = new MySqlConnection(str);
            con.Open();
            query = "select rac.NA_PROVINCE from reserved_approved_candidates rac where rac.SEAT_TYPE = 'W' and rac.CNIC ='" + cnic + "';";
            cmd = new MySqlCommand(query, con);
            reader = cmd.ExecuteReader();

            try
            {
                reader.Read();
                seat_prov_label.Text = reader.GetString(0);
                con.Close();
                return;
            }
            catch
            {
                con.Close();
            }

            //checking in na non muslim category
            str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
            con = new MySqlConnection(str);
            con.Open();
            query = "select rac.NA_PROVINCE from reserved_approved_candidates rac where rac.SEAT_TYPE = 'NM' and rac.CNIC ='" + cnic + "';";
            cmd = new MySqlCommand(query, con);
            reader = cmd.ExecuteReader();

            try
            {
                reader.Read();
                seat_prov_label.Text = reader.GetString(0);
                con.Close();
                return;
            }
            catch
            {
                con.Close();
            }
        }

        public void check_if_won_reserved_Seat()
        {

            //seats in province
            int seat_num=0;

            //checking in pa women category

            if (seat_prov_label.Text == "Sindh")
                seat_num = 29;
            else if (seat_prov_label.Text == "Punjab")
                seat_num = 66;
            else if (seat_prov_label.Text == "Balochistan")
                seat_num = 11;
            else if (seat_prov_label.Text == "Khyber Pakhtunkhawa")
                seat_num = 26;

            string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
            MySqlConnection con = new MySqlConnection(str);
            con.Open();
            String query = "select ni.CNIC, count(*) from voting_pa_reserved_seat vprs, reserved_approved_candidates rac, nadra_info ni where vprs.WOMAN_CANDIDATE_CNIC = rac.CNIC and vprs.WOMAN_CANDIDATE_CNIC = ni.CNIC and rac.SEAT_TYPE ='W' group by(WOMAN_CANDIDATE_CNIC) order by count(*) desc limit " + seat_num + ";";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    if (cnic == reader.GetString(0))
                    {
                        reserved_won_check = true;
                        status_label.Text = "MPA";
                        return;
                    }
                }
                catch
                {
                    con.Close();
                }
            }

            //checking in pa non muslim category

            if (seat_prov_label.Text == "Sindh")
                seat_num = 9;
            else if (seat_prov_label.Text == "Punjab")
                seat_num = 8;
            else if (seat_prov_label.Text == "Balochistan")
                seat_num = 3;
            else if (seat_prov_label.Text == "Khyber Pakhtunkhawa")
                seat_num = 4;

            str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
            con = new MySqlConnection(str);
            con.Open();
            query = "select ni.CNIC, count(*) from voting_pa_reserved_seat vprs, reserved_approved_candidates rac, nadra_info ni where vprs.NM_CANDIDATE_CNIC = rac.CNIC and vprs.NM_CANDIDATE_CNIC = ni.CNIC  and rac.SEAT_TYPE ='NM' group by(NM_CANDIDATE_CNIC) order by count(*) desc limit " + seat_num + ";";
            cmd = new MySqlCommand(query, con);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    if (cnic == reader.GetString(0))
                    {
                        reserved_won_check = true;
                        status_label.Text = "MPA";
                        return;
                    }
                }
                catch
                {
                    con.Close();
                }
            }

            //checking in na women category

            if (seat_prov_label.Text == "Sindh")
                seat_num = 14;
            else if (seat_prov_label.Text == "Punjab")
                seat_num = 32;
            else if (seat_prov_label.Text == "Balochistan")
                seat_num = 4;
            else if (seat_prov_label.Text == "Khyber Pakhtunkhawa")
                seat_num = 10;


            str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
            con = new MySqlConnection(str);
            con.Open();
            query = "select ni.CNIC, count(*) from voting_na_reserved_seat vnrs, reserved_approved_candidates rac, nadra_info ni where vnrs.WOMAN_CANDIDATE_CNIC = rac.CNIC and vnrs.WOMAN_CANDIDATE_CNIC = ni.CNIC and rac.SEAT_TYPE ='W' group by(WOMAN_CANDIDATE_CNIC) order by count(*) desc limit " + seat_num + ";";
            cmd = new MySqlCommand(query, con);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    if (cnic == reader.GetString(0))
                    {
                        reserved_won_check = true;
                        status_label.Text = "MNA";
                        return;
                    }
                }
                catch
                {
                    con.Close();
                }
            }

            //checking in na non muslim category
            str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
            con = new MySqlConnection(str);
            con.Open();
            query = "select ni.CNIC, count(*) from voting_na_reserved_seat vnrs, reserved_approved_candidates rac, nadra_info ni where vnrs.NM_CANDIDATE_CNIC = rac.CNIC and vnrs.NM_CANDIDATE_CNIC = ni.CNIC and rac.SEAT_TYPE ='NM'and rac.NA_PROVINCE ='ALL' group by(NM_CANDIDATE_CNIC) order by count(*) desc limit 10;";
            cmd = new MySqlCommand(query, con);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    if (cnic == reader.GetString(0))
                    {
                        reserved_won_check = true;
                        status_label.Text = "MNA";
                        return;
                    }

                }
                catch
                {
                    con.Close();
                }
            }
            
        }

        public void Load_grids_senate()
        {
            string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
            MySqlConnection con = new MySqlConnection(str);
            con.Open();
            String query = "select ni.NAME, p.PARTY_NAME,sac.PROVINCE ,ni.CNIC from senate_approved_candidates sac ,nadra_info ni ,party p where sac.CNIC =ni.CNIC and sac.PARTY_ID =p.PARTY_ID and sac.PROVINCE ='"+seat_prov_label.Text+"';";
            
            if(seat_prov_label.Text=="ALL")
                query = "select ni.NAME, p.PARTY_NAME,sac.PROVINCE ,ni.CNIC from senate_approved_candidates sac ,nadra_info ni ,party p where sac.CNIC =ni.CNIC and sac.PARTY_ID =p.PARTY_ID ;";
            
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            senate_dataGridView.Rows.Clear();
            
            while (reader.Read())
            {
                try
                {
                    senate_dataGridView.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                }
                catch
                {
                    con.Close();
                }
            }

        }

        public void find_province_senate()
        {
            string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
            MySqlConnection con = new MySqlConnection(str);
            con.Open();
            String query = "select sac.PROVINCE from senate_approved_candidates sac where cnic = '" + cnic + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                seat_prov_label.Text = reader.GetString(0);
;
            }
            catch
            {
                con.Close();
            }
        }

        public void check_if_won_senate_seat()
        {

            int req_vote=0;

            if (seat_prov_label.Text == "Sindh")
                req_vote = 241 / 25;
            else if(seat_prov_label.Text == "Punjab")
                req_vote = 540 / 25;
            else if (seat_prov_label.Text == "Balochistan")
                req_vote = 107 / 25;
            else if (seat_prov_label.Text == "Khyber Pakhtunkhawa")
                req_vote = 209 / 25;


            string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
            MySqlConnection con = new MySqlConnection(str);
            con.Open();
            String query = "select count(*) from voting_senate vs,senate_approved_candidates sac where vs.SENATE_CANDIDATE_CNIC = sac.CNIC and vs.SENATE_CANDIDATE_CNIC = '" + cnic + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                if (reader.GetInt32(0) > req_vote)
                    status_label.Text = "Member of Senate";

            }
            catch
            {
                con.Close();
            }
        }

        private void E_Ballot_1_Load(object sender, EventArgs e)
        {
            details_button.Enabled = false;
            tabPage2.Enabled = false;
            tabPage3.Enabled = false;

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

            if(Seat_Type_Label.Text == "Open Seat")
            {
                find_prvince();
                check_if_won_open_seat();
                if (tabPage2.Enabled == true)
                {                    
                    Load_grids_resereved();
                    check_voted();
                    Load_grids_senate();
                    check_voted_senate();
                }
            }
            else if(Seat_Type_Label.Text == "Reserved Seat")
            {
                find_province_reserved();
                check_if_won_reserved_Seat();
                if (reserved_won_check == true)
                {
                    tabPage3.Enabled = true;
                    Load_grids_senate();
                    check_voted_senate();
                }
            }
            else if(Seat_Type_Label.Text == "Senate Seat")
            {
                find_province_senate();
                check_if_won_senate_seat();
            }
        }

        private void quit_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            Apply obj = new Apply(cnic,gender_label.Text);
            this.Hide();
            obj.Show();
        }

        private void details_button_Click(object sender, EventArgs e)
        {
            string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
            MySqlConnection con = new MySqlConnection(str);
            String query = "select cnic from approved_candidates where cnic = " + cnic + ";";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                reader.GetString(0);
                con.Close();

                Show_Deatils obj = new Show_Deatils(cnic);
                this.Hide();
                obj.Show();              
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
                con.Close();

                Show_Deatils_Reserved obj = new Show_Deatils_Reserved(cnic);
                this.Hide();
                obj.Show();
            }
            catch
            {
                con.Close();
            }

            query = "select cnic from senate_approved_candidates where cnic = " + cnic + ";";
            cmd = new MySqlCommand(query, con);
            con.Open();
            reader = cmd.ExecuteReader();

            try
            {
                reader.Read();
                reader.GetString(0);
                con.Close();

                Show_Details_Senate obj = new Show_Details_Senate (cnic);
                this.Hide();
                obj.Show();
            }
            catch
            {
                con.Close();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nonmuslim_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = nonmuslim_dataGridView.Rows[rowIndex];
            nonmuslim_cnic = Convert.ToString(row.Cells[3].Value);
            MessageBox.Show("Candidate Selected : " + Convert.ToString(row.Cells[0].Value));
        }

        private void women_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = women_dataGridView.Rows[rowIndex];
            women_cnic = Convert.ToString(row.Cells[3].Value);
            MessageBox.Show("Candidate Selected : " + Convert.ToString(row.Cells[0].Value));
        }

        public void check_voted()
        {
            if (status_label.Text == "MPA")
            {
                string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
                MySqlConnection con = new MySqlConnection(str);
                String query = "select VOTER_CNIC from voting_pa_reserved_seat where VOTER_CNIC ='" + cnic + "';";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                try
                {
                    reader.GetString(0);
                    vote_button.Enabled = false;
                    voted_label.Text = "Already Voted!";
                }
                catch
                {
                    con.Close();
                }
            }
            else if(status_label.Text == "MNA")
            {
                string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
                MySqlConnection con = new MySqlConnection(str);
                String query = "select VOTER_CNIC from voting_na_reserved_seat where VOTER_CNIC ='" + cnic + "';";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                try
                {
                    reader.GetString(0);
                    vote_button.Enabled = false;
                    voted_label.Text = "Already Voted!";
                }
                catch
                {
                    con.Close();
                }
            }          
        }

        private void vote_button_Click(object sender, EventArgs e)
        {
            if(women_cnic!="NULL" && nonmuslim_cnic != "NULL")
            {
                if (status_label.Text == "MPA")
                {
                    string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
                    MySqlConnection con = new MySqlConnection(str);
                    String query = "insert into voting_pa_reserved_seat values('" + cnic + "','" + women_cnic + "','" + nonmuslim_cnic + "');";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteReader();
                    con.Close();
                    check_voted();
                }
                else if (status_label.Text == "MNA")
                {

                    string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
                    MySqlConnection con = new MySqlConnection(str);
                    String query = "insert into voting_na_reserved_seat values('" + cnic + "','" + women_cnic + "','" + nonmuslim_cnic + "');";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteReader();
                    con.Close();
                    check_voted();
                }
            }
            else
            {
                MessageBox.Show("Plesae select both candidates!");
            }
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        public void check_voted_senate()
        {
            string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
            MySqlConnection con = new MySqlConnection(str);
            String query = "select vs.VOTER_CNIC from voting_senate vs where vs.VOTER_CNIC = '" + cnic+"';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                if (cnic == reader.GetString(0))
                {
                    vote_button1.Enabled = false;
                    voted_label1.Text = "Already voted!";
                }                  
            }
            catch
            {
                con.Close();
            }
        }

        private void senate_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = senate_dataGridView.Rows[rowIndex];
            senate_cnic = Convert.ToString(row.Cells[3].Value);
            MessageBox.Show("Candidate Selected : " + Convert.ToString(row.Cells[0].Value));
        }

        private void vote_button1_Click(object sender, EventArgs e)
        {
            if (senate_cnic != "NULL")
            {
                string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
                MySqlConnection con = new MySqlConnection(str);
                String query = "insert into voting_senate values('" + cnic + "','" + senate_cnic + "');";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                cmd.ExecuteReader();
                con.Close();
                check_voted_senate();
            }
            else
            {
                MessageBox.Show("Plesae select both candidates!");
            }
        }
    }
}
