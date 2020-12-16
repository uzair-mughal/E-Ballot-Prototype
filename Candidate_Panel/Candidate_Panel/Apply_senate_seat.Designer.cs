namespace Candidate_Panel
{
    partial class Apply_senate_seat
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
            this.apply_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cnic_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.party_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prov_comboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 115);
            this.panel1.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Ballot System";
            // 
            // apply_button
            // 
            this.apply_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.apply_button.Location = new System.Drawing.Point(374, 415);
            this.apply_button.Name = "apply_button";
            this.apply_button.Size = new System.Drawing.Size(117, 34);
            this.apply_button.TabIndex = 65;
            this.apply_button.Text = "Apply";
            this.apply_button.UseVisualStyleBackColor = true;
            this.apply_button.Click += new System.EventHandler(this.apply_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(26, 415);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(117, 34);
            this.back_button.TabIndex = 64;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cnic_label);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.party_label);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.prov_comboBox);
            this.groupBox1.Location = new System.Drawing.Point(26, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 260);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            // 
            // cnic_label
            // 
            this.cnic_label.AutoSize = true;
            this.cnic_label.Location = new System.Drawing.Point(203, 52);
            this.cnic_label.Name = "cnic_label";
            this.cnic_label.Size = new System.Drawing.Size(15, 23);
            this.cnic_label.TabIndex = 20;
            this.cnic_label.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "CNIC:";
            // 
            // party_label
            // 
            this.party_label.AutoSize = true;
            this.party_label.Location = new System.Drawing.Point(203, 111);
            this.party_label.Name = "party_label";
            this.party_label.Size = new System.Drawing.Size(15, 23);
            this.party_label.TabIndex = 18;
            this.party_label.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Party:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Province:";
            // 
            // prov_comboBox
            // 
            this.prov_comboBox.FormattingEnabled = true;
            this.prov_comboBox.Items.AddRange(new object[] {
            "Balochistan",
            "Khyber Pakhtunkhawa",
            "Punjab",
            "Sindh"});
            this.prov_comboBox.Location = new System.Drawing.Point(207, 180);
            this.prov_comboBox.Name = "prov_comboBox";
            this.prov_comboBox.Size = new System.Drawing.Size(188, 31);
            this.prov_comboBox.Sorted = true;
            this.prov_comboBox.TabIndex = 14;
            // 
            // Apply_senate_seat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 474);
            this.Controls.Add(this.apply_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Apply_senate_seat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apply_senate_seat";
            this.Load += new System.EventHandler(this.Apply_senate_seat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apply_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label cnic_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label party_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox prov_comboBox;
    }
}