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
    public partial class E_Voting_1 : Form
    {
        public MySqlDataReader reader;
        public E_Voting_1(MySqlDataReader temp)
        {
            reader = temp;
            InitializeComponent();
        }

        private void E_Voting_1_Load(object sender, EventArgs e)
        {
            reader.Read();
            cnic_label.Text = reader.GetString(0);
            name_label.Text = reader.GetString(1);
            fname_label.Text = reader.GetString(2);
            gender_label.Text = reader.GetString(3);
            dob_label.Text = reader.GetString(4);
            add_label.Text = reader.GetString(7);
            reg_label.Text = reader.GetString(8);
            dist_label.Text = reader.GetString(9);
            prov_label.Text = reader.GetString(10);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
