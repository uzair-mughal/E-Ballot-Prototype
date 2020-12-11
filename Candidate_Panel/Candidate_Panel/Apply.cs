using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candidate_Panel
{
    public partial class Apply : Form
    {
        public static String cnic;
        public Apply(String temp)
        {
            cnic = temp;
            InitializeComponent();
        }
        public Apply()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            E_Ballot_1 obj = new E_Ballot_1();
            this.Hide();
            obj.Show();
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            if(party_comboBox.Text=="" || seat_comboBox.Text == "")
            {
                MessageBox.Show("Please fill all the fields!");
            }
            else if(seat_comboBox.Text == "Open Seat")
            {
                Apply_open_seat obj = new Apply_open_seat(party_comboBox.Text,cnic);
                this.Hide();
                obj.Show();
            }
            else if(seat_comboBox.Text == "Reserved Seat")
            {
                Apply_reserved_seat obj = new Apply_reserved_seat(party_comboBox.Text, cnic);
                this.Hide();
                obj.Show();
            }
        }

        private void Apply_Load(object sender, EventArgs e)
        {

        }
    }
}
