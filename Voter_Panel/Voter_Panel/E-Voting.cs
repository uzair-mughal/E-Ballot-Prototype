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
    public partial class E_Voting : Form
    {
        public E_Voting()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void login_button_Click(object sender, EventArgs e)
        {

            if (cnic_maskedTextBox.Text == "     -       -")
            {
                MessageBox.Show("Please type in CNIC!");
            }
            else
            {
                string str = "server=localhost;port=3306;username=root;password=;database=e_ballot";
                MySqlConnection con = new MySqlConnection(str);
                con.Open();
                string Text = cnic_maskedTextBox.Text;
                Text = Text.Replace("-", "");
                String query = "select * from nadra_info where cnic="+Text+"";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                try
                {
                    String cnic = reader.GetString(1);
                    E_Voting_1 obj = new E_Voting_1(reader);
                    this.Hide();
                    obj.Show();
                }
                catch
                {
                    MessageBox.Show("No Record Found!");
                }
            }

        }

        private void E_Voting_Load(object sender, EventArgs e)
        {

        }
    }
}
