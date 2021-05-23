namespace Candidate_Panel
{
    partial class Show_Details_Senate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cnic_cand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.votes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.party_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidate_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comp_dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.status_label = new System.Windows.Forms.Label();
            this.prov_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comp_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 113);
            this.panel1.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(422, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Ballot System";
            // 
            // cnic_cand
            // 
            this.cnic_cand.HeaderText = "Cand NIC";
            this.cnic_cand.MinimumWidth = 6;
            this.cnic_cand.Name = "cnic_cand";
            this.cnic_cand.ReadOnly = true;
            this.cnic_cand.Visible = false;
            this.cnic_cand.Width = 125;
            // 
            // votes
            // 
            this.votes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.votes.HeaderText = "Votes";
            this.votes.MinimumWidth = 6;
            this.votes.Name = "votes";
            this.votes.ReadOnly = true;
            this.votes.Width = 95;
            // 
            // party_name
            // 
            this.party_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.party_name.HeaderText = "Party Name";
            this.party_name.MinimumWidth = 6;
            this.party_name.Name = "party_name";
            this.party_name.ReadOnly = true;
            this.party_name.Width = 143;
            // 
            // candidate_name
            // 
            this.candidate_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.candidate_name.HeaderText = "Candidate Name";
            this.candidate_name.MinimumWidth = 6;
            this.candidate_name.Name = "candidate_name";
            this.candidate_name.ReadOnly = true;
            // 
            // comp_dataGridView
            // 
            this.comp_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comp_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.candidate_name,
            this.party_name,
            this.votes,
            this.cnic_cand});
            this.comp_dataGridView.Location = new System.Drawing.Point(25, 33);
            this.comp_dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.comp_dataGridView.Name = "comp_dataGridView";
            this.comp_dataGridView.RowHeadersWidth = 51;
            this.comp_dataGridView.RowTemplate.Height = 24;
            this.comp_dataGridView.Size = new System.Drawing.Size(521, 408);
            this.comp_dataGridView.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comp_dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(559, 161);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(568, 473);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Competitors:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Province:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // back_button
            // 
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.back_button.Location = new System.Drawing.Point(32, 600);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(117, 34);
            this.back_button.TabIndex = 68;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(253, 128);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(89, 23);
            this.status_label.TabIndex = 20;
            this.status_label.Text = "Pending";
            // 
            // prov_label
            // 
            this.prov_label.AutoSize = true;
            this.prov_label.Location = new System.Drawing.Point(253, 61);
            this.prov_label.Name = "prov_label";
            this.prov_label.Size = new System.Drawing.Size(15, 23);
            this.prov_label.TabIndex = 16;
            this.prov_label.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(451, 23);
            this.label7.TabIndex = 69;
            this.label7.Text = "Reminder:Nic is hiden to find the winner in last";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.status_label);
            this.groupBox2.Controls.Add(this.prov_label);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(32, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 199);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seat Description:";
            // 
            // Show_Details_Senate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 655);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Show_Details_Senate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show_Details_Senate";
            this.Load += new System.EventHandler(this.Show_Details_Senate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comp_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnic_cand;
        private System.Windows.Forms.DataGridViewTextBoxColumn votes;
        private System.Windows.Forms.DataGridViewTextBoxColumn party_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidate_name;
        private System.Windows.Forms.DataGridView comp_dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label prov_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}