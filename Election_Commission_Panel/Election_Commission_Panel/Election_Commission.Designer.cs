namespace Election_Commission_Panel
{
    partial class Election_Commission
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.open_seat_dataGridView = new System.Windows.Forms.DataGridView();
            this.can_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa_region_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.na_region_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.party_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cand_cnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.party_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reject_button = new System.Windows.Forms.Button();
            this.approve_button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reserved_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reject_button1 = new System.Windows.Forms.Button();
            this.approve_button1 = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.senate_dataGridView = new System.Windows.Forms.DataGridView();
            this.reject_button2 = new System.Windows.Forms.Button();
            this.approve_button2 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.open_seat_dataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reserved_dataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.senate_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, -13);
            this.panel1.Margin = new System.Windows.Forms.Padding(14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1538, 116);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(283, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Ballot System";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(17, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(941, 641);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(933, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Open Seat ";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.open_seat_dataGridView);
            this.groupBox1.Controls.Add(this.reject_button);
            this.groupBox1.Controls.Add(this.approve_button);
            this.groupBox1.Location = new System.Drawing.Point(24, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 557);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pending Approvals";
            // 
            // open_seat_dataGridView
            // 
            this.open_seat_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.open_seat_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.can_name,
            this.pa_region_id,
            this.na_region_id,
            this.party_name,
            this.cand_cnic,
            this.party_id});
            this.open_seat_dataGridView.Location = new System.Drawing.Point(20, 40);
            this.open_seat_dataGridView.Name = "open_seat_dataGridView";
            this.open_seat_dataGridView.RowHeadersWidth = 51;
            this.open_seat_dataGridView.RowTemplate.Height = 24;
            this.open_seat_dataGridView.Size = new System.Drawing.Size(845, 447);
            this.open_seat_dataGridView.TabIndex = 0;
            this.open_seat_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.approval_dataGridView_CellContentClick);
            // 
            // can_name
            // 
            this.can_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.can_name.HeaderText = "Candidate Name";
            this.can_name.MinimumWidth = 6;
            this.can_name.Name = "can_name";
            this.can_name.ReadOnly = true;
            // 
            // pa_region_id
            // 
            this.pa_region_id.HeaderText = "PA Region ID";
            this.pa_region_id.MinimumWidth = 6;
            this.pa_region_id.Name = "pa_region_id";
            this.pa_region_id.ReadOnly = true;
            this.pa_region_id.Width = 150;
            // 
            // na_region_id
            // 
            this.na_region_id.HeaderText = "NA Region ID";
            this.na_region_id.MinimumWidth = 6;
            this.na_region_id.Name = "na_region_id";
            this.na_region_id.ReadOnly = true;
            this.na_region_id.Width = 164;
            // 
            // party_name
            // 
            this.party_name.HeaderText = "Party Name";
            this.party_name.MinimumWidth = 6;
            this.party_name.Name = "party_name";
            this.party_name.ReadOnly = true;
            this.party_name.Width = 157;
            // 
            // cand_cnic
            // 
            this.cand_cnic.HeaderText = "Cand CNIC";
            this.cand_cnic.MinimumWidth = 6;
            this.cand_cnic.Name = "cand_cnic";
            this.cand_cnic.ReadOnly = true;
            this.cand_cnic.Visible = false;
            this.cand_cnic.Width = 125;
            // 
            // party_id
            // 
            this.party_id.HeaderText = "Party ID";
            this.party_id.MinimumWidth = 6;
            this.party_id.Name = "party_id";
            this.party_id.ReadOnly = true;
            this.party_id.Visible = false;
            this.party_id.Width = 125;
            // 
            // reject_button
            // 
            this.reject_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.reject_button.Location = new System.Drawing.Point(748, 503);
            this.reject_button.Name = "reject_button";
            this.reject_button.Size = new System.Drawing.Size(117, 34);
            this.reject_button.TabIndex = 2;
            this.reject_button.Text = "Reject";
            this.reject_button.UseVisualStyleBackColor = true;
            this.reject_button.Click += new System.EventHandler(this.reject_button_Click);
            // 
            // approve_button
            // 
            this.approve_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.approve_button.Location = new System.Drawing.Point(611, 503);
            this.approve_button.Name = "approve_button";
            this.approve_button.Size = new System.Drawing.Size(117, 34);
            this.approve_button.TabIndex = 1;
            this.approve_button.Text = "Approve";
            this.approve_button.UseVisualStyleBackColor = true;
            this.approve_button.Click += new System.EventHandler(this.approve_button_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(933, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reserved Seats";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reserved_dataGridView);
            this.groupBox2.Controls.Add(this.reject_button1);
            this.groupBox2.Controls.Add(this.approve_button1);
            this.groupBox2.Location = new System.Drawing.Point(24, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(889, 557);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pending Approvals";
            // 
            // reserved_dataGridView
            // 
            this.reserved_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reserved_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.type,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.reserved_dataGridView.Location = new System.Drawing.Point(20, 40);
            this.reserved_dataGridView.Name = "reserved_dataGridView";
            this.reserved_dataGridView.RowHeadersWidth = 51;
            this.reserved_dataGridView.RowTemplate.Height = 24;
            this.reserved_dataGridView.Size = new System.Drawing.Size(845, 447);
            this.reserved_dataGridView.TabIndex = 0;
            this.reserved_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reserved_dataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Candidate Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "PA Province";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "NA Province";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 164;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Party Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 157;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.HeaderText = "Seat Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Cand CNIC";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Party ID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // reject_button1
            // 
            this.reject_button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.reject_button1.Location = new System.Drawing.Point(748, 503);
            this.reject_button1.Name = "reject_button1";
            this.reject_button1.Size = new System.Drawing.Size(117, 34);
            this.reject_button1.TabIndex = 2;
            this.reject_button1.Text = "Reject";
            this.reject_button1.UseVisualStyleBackColor = true;
            this.reject_button1.Click += new System.EventHandler(this.reject_button1_Click);
            // 
            // approve_button1
            // 
            this.approve_button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.approve_button1.Location = new System.Drawing.Point(611, 503);
            this.approve_button1.Name = "approve_button1";
            this.approve_button1.Size = new System.Drawing.Size(117, 34);
            this.approve_button1.TabIndex = 1;
            this.approve_button1.Text = "Approve";
            this.approve_button1.UseVisualStyleBackColor = true;
            this.approve_button1.Click += new System.EventHandler(this.approve_button1_Click);
            // 
            // back_button
            // 
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.back_button.Location = new System.Drawing.Point(17, 778);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(117, 34);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(933, 605);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Senate Seats";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.senate_dataGridView);
            this.groupBox3.Controls.Add(this.reject_button2);
            this.groupBox3.Controls.Add(this.approve_button2);
            this.groupBox3.Location = new System.Drawing.Point(24, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(889, 557);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pending Approvals";
            // 
            // senate_dataGridView
            // 
            this.senate_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.senate_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.senate_dataGridView.Location = new System.Drawing.Point(20, 40);
            this.senate_dataGridView.Name = "senate_dataGridView";
            this.senate_dataGridView.RowHeadersWidth = 51;
            this.senate_dataGridView.RowTemplate.Height = 24;
            this.senate_dataGridView.Size = new System.Drawing.Size(845, 447);
            this.senate_dataGridView.TabIndex = 0;
            this.senate_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // reject_button2
            // 
            this.reject_button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.reject_button2.Location = new System.Drawing.Point(748, 503);
            this.reject_button2.Name = "reject_button2";
            this.reject_button2.Size = new System.Drawing.Size(117, 34);
            this.reject_button2.TabIndex = 2;
            this.reject_button2.Text = "Reject";
            this.reject_button2.UseVisualStyleBackColor = true;
            this.reject_button2.Click += new System.EventHandler(this.reject_button2_Click);
            // 
            // approve_button2
            // 
            this.approve_button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.approve_button2.Location = new System.Drawing.Point(611, 503);
            this.approve_button2.Name = "approve_button2";
            this.approve_button2.Size = new System.Drawing.Size(117, 34);
            this.approve_button2.TabIndex = 1;
            this.approve_button2.Text = "Approve";
            this.approve_button2.UseVisualStyleBackColor = true;
            this.approve_button2.Click += new System.EventHandler(this.approve_button2_Click);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "Candidate Name";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Province";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 170;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Party Name";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 157;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Cand CNIC";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Party ID";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // Election_Commission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 828);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Election_Commission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Election_Commission";
            this.Load += new System.EventHandler(this.Election_Commission_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.open_seat_dataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reserved_dataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.senate_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button reject_button;
        private System.Windows.Forms.Button approve_button;
        private System.Windows.Forms.DataGridView open_seat_dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView reserved_dataGridView;
        private System.Windows.Forms.Button reject_button1;
        private System.Windows.Forms.Button approve_button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn can_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa_region_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn na_region_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn party_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cand_cnic;
        private System.Windows.Forms.DataGridViewTextBoxColumn party_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView senate_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button reject_button2;
        private System.Windows.Forms.Button approve_button2;
    }
}