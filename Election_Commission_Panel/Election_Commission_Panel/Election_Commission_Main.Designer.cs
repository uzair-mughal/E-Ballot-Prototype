
namespace Election_Commission_Panel
{
    partial class Election_Commission_Main
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.openStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.openButton = new System.Windows.Forms.Button();
            this.openLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reservedButton = new System.Windows.Forms.Button();
            this.reservedEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reservedStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reservedLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.senateButton = new System.Windows.Forms.Button();
            this.senateEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.senateStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.senateLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PMButton = new System.Windows.Forms.Button();
            this.PMEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PMStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PMLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pm_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-11, -10);
            this.panel1.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1505, 113);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(574, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Ballot System";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openEndDateTimePicker);
            this.groupBox1.Controls.Add(this.openStartDateTimePicker);
            this.groupBox1.Controls.Add(this.openButton);
            this.groupBox1.Controls.Add(this.openLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(347, 311);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Open Seat Voting";
            // 
            // openEndDateTimePicker
            // 
            this.openEndDateTimePicker.CustomFormat = "YYYY-MM-DD";
            this.openEndDateTimePicker.Location = new System.Drawing.Point(144, 110);
            this.openEndDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openEndDateTimePicker.Name = "openEndDateTimePicker";
            this.openEndDateTimePicker.Size = new System.Drawing.Size(180, 32);
            this.openEndDateTimePicker.TabIndex = 7;
            // 
            // openStartDateTimePicker
            // 
            this.openStartDateTimePicker.CustomFormat = "YYYY-MM-DD";
            this.openStartDateTimePicker.Location = new System.Drawing.Point(144, 50);
            this.openStartDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openStartDateTimePicker.MinDate = new System.DateTime(2020, 12, 16, 0, 0, 0, 0);
            this.openStartDateTimePicker.Name = "openStartDateTimePicker";
            this.openStartDateTimePicker.Size = new System.Drawing.Size(180, 32);
            this.openStartDateTimePicker.TabIndex = 6;
            this.openStartDateTimePicker.Value = new System.DateTime(2020, 12, 16, 0, 0, 0, 0);
            // 
            // openButton
            // 
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.openButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.Location = new System.Drawing.Point(144, 150);
            this.openButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(180, 34);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "Set Date";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // openLabel
            // 
            this.openLabel.AutoSize = true;
            this.openLabel.Location = new System.Drawing.Point(111, 234);
            this.openLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.openLabel.Name = "openLabel";
            this.openLabel.Size = new System.Drawing.Size(136, 23);
            this.openLabel.TabIndex = 5;
            this.openLabel.Text = "Date Not Set";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Start Date:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reservedButton);
            this.groupBox2.Controls.Add(this.reservedEndDateTimePicker);
            this.groupBox2.Controls.Add(this.reservedStartDateTimePicker);
            this.groupBox2.Controls.Add(this.reservedLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(380, 115);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(347, 311);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reserved Seat Voting";
            // 
            // reservedButton
            // 
            this.reservedButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.reservedButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservedButton.Location = new System.Drawing.Point(148, 150);
            this.reservedButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reservedButton.Name = "reservedButton";
            this.reservedButton.Size = new System.Drawing.Size(180, 34);
            this.reservedButton.TabIndex = 8;
            this.reservedButton.Text = "Set Date";
            this.reservedButton.UseVisualStyleBackColor = true;
            this.reservedButton.Click += new System.EventHandler(this.reservedButton_Click);
            // 
            // reservedEndDateTimePicker
            // 
            this.reservedEndDateTimePicker.CustomFormat = "YYYY-MM-DD";
            this.reservedEndDateTimePicker.Location = new System.Drawing.Point(148, 106);
            this.reservedEndDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reservedEndDateTimePicker.Name = "reservedEndDateTimePicker";
            this.reservedEndDateTimePicker.Size = new System.Drawing.Size(180, 32);
            this.reservedEndDateTimePicker.TabIndex = 9;
            // 
            // reservedStartDateTimePicker
            // 
            this.reservedStartDateTimePicker.CustomFormat = "YYYY-MM-DD";
            this.reservedStartDateTimePicker.Location = new System.Drawing.Point(148, 44);
            this.reservedStartDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reservedStartDateTimePicker.Name = "reservedStartDateTimePicker";
            this.reservedStartDateTimePicker.Size = new System.Drawing.Size(180, 32);
            this.reservedStartDateTimePicker.TabIndex = 8;
            // 
            // reservedLabel
            // 
            this.reservedLabel.AutoSize = true;
            this.reservedLabel.Location = new System.Drawing.Point(113, 234);
            this.reservedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reservedLabel.Name = "reservedLabel";
            this.reservedLabel.Size = new System.Drawing.Size(136, 23);
            this.reservedLabel.TabIndex = 6;
            this.reservedLabel.Text = "Date Not Set";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "End Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Date:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.senateButton);
            this.groupBox3.Controls.Add(this.senateEndDateTimePicker);
            this.groupBox3.Controls.Add(this.senateStartDateTimePicker);
            this.groupBox3.Controls.Add(this.senateLabel);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(746, 115);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(347, 311);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Senate Seat Voting";
            // 
            // senateButton
            // 
            this.senateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.senateButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senateButton.Location = new System.Drawing.Point(148, 146);
            this.senateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.senateButton.Name = "senateButton";
            this.senateButton.Size = new System.Drawing.Size(180, 34);
            this.senateButton.TabIndex = 10;
            this.senateButton.Text = "Set Date";
            this.senateButton.UseVisualStyleBackColor = true;
            this.senateButton.Click += new System.EventHandler(this.senateButton_Click);
            // 
            // senateEndDateTimePicker
            // 
            this.senateEndDateTimePicker.CustomFormat = "YYYY-MM-DD";
            this.senateEndDateTimePicker.Location = new System.Drawing.Point(148, 106);
            this.senateEndDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.senateEndDateTimePicker.Name = "senateEndDateTimePicker";
            this.senateEndDateTimePicker.Size = new System.Drawing.Size(180, 32);
            this.senateEndDateTimePicker.TabIndex = 11;
            // 
            // senateStartDateTimePicker
            // 
            this.senateStartDateTimePicker.CustomFormat = "YYYY-MM-DD";
            this.senateStartDateTimePicker.Location = new System.Drawing.Point(148, 44);
            this.senateStartDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.senateStartDateTimePicker.Name = "senateStartDateTimePicker";
            this.senateStartDateTimePicker.Size = new System.Drawing.Size(180, 32);
            this.senateStartDateTimePicker.TabIndex = 10;
            // 
            // senateLabel
            // 
            this.senateLabel.AutoSize = true;
            this.senateLabel.Location = new System.Drawing.Point(114, 234);
            this.senateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.senateLabel.Name = "senateLabel";
            this.senateLabel.Size = new System.Drawing.Size(136, 23);
            this.senateLabel.TabIndex = 6;
            this.senateLabel.Text = "Date Not Set";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "End Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Start Date:";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 446);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 34);
            this.button2.TabIndex = 17;
            this.button2.Text = "Candidates";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PMButton);
            this.groupBox4.Controls.Add(this.PMEndDateTimePicker);
            this.groupBox4.Controls.Add(this.PMStartDateTimePicker);
            this.groupBox4.Controls.Add(this.PMLabel);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(1113, 115);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(347, 311);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PM Seat Voting";
            // 
            // PMButton
            // 
            this.PMButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PMButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMButton.Location = new System.Drawing.Point(148, 146);
            this.PMButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PMButton.Name = "PMButton";
            this.PMButton.Size = new System.Drawing.Size(180, 34);
            this.PMButton.TabIndex = 10;
            this.PMButton.Text = "Set Date";
            this.PMButton.UseVisualStyleBackColor = true;
            this.PMButton.Click += new System.EventHandler(this.PMButton_Click);
            // 
            // PMEndDateTimePicker
            // 
            this.PMEndDateTimePicker.CustomFormat = "YYYY-MM-DD";
            this.PMEndDateTimePicker.Location = new System.Drawing.Point(148, 106);
            this.PMEndDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PMEndDateTimePicker.Name = "PMEndDateTimePicker";
            this.PMEndDateTimePicker.Size = new System.Drawing.Size(180, 32);
            this.PMEndDateTimePicker.TabIndex = 11;
            // 
            // PMStartDateTimePicker
            // 
            this.PMStartDateTimePicker.CustomFormat = "YYYY-MM-DD";
            this.PMStartDateTimePicker.Location = new System.Drawing.Point(148, 44);
            this.PMStartDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PMStartDateTimePicker.Name = "PMStartDateTimePicker";
            this.PMStartDateTimePicker.Size = new System.Drawing.Size(180, 32);
            this.PMStartDateTimePicker.TabIndex = 10;
            // 
            // PMLabel
            // 
            this.PMLabel.AutoSize = true;
            this.PMLabel.Location = new System.Drawing.Point(114, 234);
            this.PMLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PMLabel.Name = "PMLabel";
            this.PMLabel.Size = new System.Drawing.Size(136, 23);
            this.PMLabel.TabIndex = 6;
            this.PMLabel.Text = "Date Not Set";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 112);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 23);
            this.label12.TabIndex = 10;
            this.label12.Text = "End Date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 50);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 23);
            this.label13.TabIndex = 8;
            this.label13.Text = "Start Date:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pm_button
            // 
            this.pm_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pm_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pm_button.Location = new System.Drawing.Point(1283, 446);
            this.pm_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pm_button.Name = "pm_button";
            this.pm_button.Size = new System.Drawing.Size(180, 34);
            this.pm_button.TabIndex = 18;
            this.pm_button.Text = "PM Results";
            this.pm_button.UseVisualStyleBackColor = true;
            this.pm_button.Click += new System.EventHandler(this.pm_button_Click);
            // 
            // Election_Commission_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1476, 501);
            this.Controls.Add(this.pm_button);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Election_Commission_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Election Commission";
            this.Load += new System.EventHandler(this.Election_Commission_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label openLabel;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label reservedLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label senateLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker openStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker openEndDateTimePicker;
        private System.Windows.Forms.DateTimePicker reservedEndDateTimePicker;
        private System.Windows.Forms.DateTimePicker reservedStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker senateEndDateTimePicker;
        private System.Windows.Forms.DateTimePicker senateStartDateTimePicker;
        private System.Windows.Forms.Button reservedButton;
        private System.Windows.Forms.Button senateButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button PMButton;
        private System.Windows.Forms.DateTimePicker PMEndDateTimePicker;
        private System.Windows.Forms.DateTimePicker PMStartDateTimePicker;
        private System.Windows.Forms.Label PMLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button pm_button;
    }
}