namespace Candidate_Panel
{
    partial class Apply_open_seat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apply_open_seat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prov_comboBox = new System.Windows.Forms.ComboBox();
            this.dist_comboBox = new System.Windows.Forms.ComboBox();
            this.desg_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.party_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.region_dataGridView = new System.Windows.Forms.DataGridView();
            this.region_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back_button = new System.Windows.Forms.Button();
            this.apply_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cnic_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.region_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-74, -14);
            this.panel1.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1516, 113);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(435, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Ballot System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Province:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "District:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Designation:";
            // 
            // prov_comboBox
            // 
            this.prov_comboBox.FormattingEnabled = true;
            this.prov_comboBox.Items.AddRange(new object[] {
            "Balochistan",
            "Khyber Pakhtunkhawa",
            "Punjab",
            "Sindh"});
            this.prov_comboBox.Location = new System.Drawing.Point(185, 161);
            this.prov_comboBox.Name = "prov_comboBox";
            this.prov_comboBox.Size = new System.Drawing.Size(263, 31);
            this.prov_comboBox.Sorted = true;
            this.prov_comboBox.TabIndex = 12;
            this.prov_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dist_comboBox
            // 
            this.dist_comboBox.DropDownHeight = 150;
            this.dist_comboBox.FormattingEnabled = true;
            this.dist_comboBox.IntegralHeight = false;
            this.dist_comboBox.Location = new System.Drawing.Point(185, 216);
            this.dist_comboBox.Name = "dist_comboBox";
            this.dist_comboBox.Size = new System.Drawing.Size(263, 31);
            this.dist_comboBox.Sorted = true;
            this.dist_comboBox.TabIndex = 13;
            this.dist_comboBox.SelectedIndexChanged += new System.EventHandler(this.dist_comboBox_SelectedIndexChanged);
            // 
            // desg_comboBox
            // 
            this.desg_comboBox.FormattingEnabled = true;
            this.desg_comboBox.Items.AddRange(new object[] {
            "MNA",
            "MPA"});
            this.desg_comboBox.Location = new System.Drawing.Point(185, 273);
            this.desg_comboBox.Name = "desg_comboBox";
            this.desg_comboBox.Size = new System.Drawing.Size(125, 31);
            this.desg_comboBox.Sorted = true;
            this.desg_comboBox.TabIndex = 14;
            this.desg_comboBox.SelectedIndexChanged += new System.EventHandler(this.desg_comboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cnic_label);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.party_label);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.desg_comboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dist_comboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.prov_comboBox);
            this.groupBox1.Location = new System.Drawing.Point(24, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 337);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // party_label
            // 
            this.party_label.AutoSize = true;
            this.party_label.Location = new System.Drawing.Point(181, 106);
            this.party_label.Name = "party_label";
            this.party_label.Size = new System.Drawing.Size(15, 23);
            this.party_label.TabIndex = 16;
            this.party_label.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Party:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.region_dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(512, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 471);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Availble Regions:";
            // 
            // region_dataGridView
            // 
            this.region_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.region_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.region_id,
            this.district,
            this.region});
            this.region_dataGridView.Location = new System.Drawing.Point(17, 32);
            this.region_dataGridView.Name = "region_dataGridView";
            this.region_dataGridView.RowHeadersWidth = 51;
            this.region_dataGridView.RowTemplate.Height = 24;
            this.region_dataGridView.Size = new System.Drawing.Size(523, 418);
            this.region_dataGridView.TabIndex = 0;
            this.region_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.region_dataGridView_CellContentClick);
            // 
            // region_id
            // 
            this.region_id.HeaderText = "Region_ID";
            this.region_id.MinimumWidth = 6;
            this.region_id.Name = "region_id";
            this.region_id.ReadOnly = true;
            this.region_id.Width = 125;
            // 
            // district
            // 
            this.district.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.district.HeaderText = "District";
            this.district.MinimumWidth = 6;
            this.district.Name = "district";
            this.district.ReadOnly = true;
            // 
            // region
            // 
            this.region.HeaderText = "Region Number";
            this.region.MinimumWidth = 6;
            this.region.Name = "region";
            this.region.ReadOnly = true;
            this.region.Width = 125;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(47, 549);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(117, 34);
            this.back_button.TabIndex = 12;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click_1);
            // 
            // apply_button
            // 
            this.apply_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.apply_button.Location = new System.Drawing.Point(355, 549);
            this.apply_button.Name = "apply_button";
            this.apply_button.Size = new System.Drawing.Size(117, 34);
            this.apply_button.TabIndex = 59;
            this.apply_button.Text = "Apply";
            this.apply_button.UseVisualStyleBackColor = true;
            this.apply_button.Click += new System.EventHandler(this.apply_button_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "CNIC:";
            // 
            // cnic_label
            // 
            this.cnic_label.AutoSize = true;
            this.cnic_label.Location = new System.Drawing.Point(181, 49);
            this.cnic_label.Name = "cnic_label";
            this.cnic_label.Size = new System.Drawing.Size(15, 23);
            this.cnic_label.TabIndex = 18;
            this.cnic_label.Text = ".";
            this.cnic_label.Click += new System.EventHandler(this.cnic_label_Click);
            // 
            // Apply_open_seat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 610);
            this.Controls.Add(this.apply_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Apply_open_seat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apply_open_seat";
            this.Load += new System.EventHandler(this.Apply_open_seat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.region_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox prov_comboBox;
        private System.Windows.Forms.ComboBox dist_comboBox;
        private System.Windows.Forms.ComboBox desg_comboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView region_dataGridView;
        private System.Windows.Forms.Label party_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button apply_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn region_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn district;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.Label cnic_label;
        private System.Windows.Forms.Label label6;
    }
}