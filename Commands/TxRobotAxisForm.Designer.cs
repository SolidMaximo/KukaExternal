namespace Commands
{
    partial class TxRobotAxisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_robotPicker = new Tecnomatix.Engineering.Ui.TxObjEditBoxCtrl();
            this.m_txtExternalID = new System.Windows.Forms.TextBox();
            this.cPath = new System.Windows.Forms.TextBox();
            this.m_btnClose = new System.Windows.Forms.Button();
            this.WriteAsBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Upper12 = new System.Windows.Forms.TextBox();
            this.Upper11 = new System.Windows.Forms.TextBox();
            this.Upper10 = new System.Windows.Forms.TextBox();
            this.Upper9 = new System.Windows.Forms.TextBox();
            this.Upper8 = new System.Windows.Forms.TextBox();
            this.Upper7 = new System.Windows.Forms.TextBox();
            this.Lower12 = new System.Windows.Forms.TextBox();
            this.Lower11 = new System.Windows.Forms.TextBox();
            this.Lower10 = new System.Windows.Forms.TextBox();
            this.Lower9 = new System.Windows.Forms.TextBox();
            this.Lower7 = new System.Windows.Forms.TextBox();
            this.writeBtn = new System.Windows.Forms.Button();
            this.Lower8 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ePath = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Robot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "External ID";
            // 
            // m_robotPicker
            // 
            this.m_robotPicker.KeepFaceEmphasizedWhenControlIsNotFocused = true;
            this.m_robotPicker.ListenToPick = true;
            this.m_robotPicker.Location = new System.Drawing.Point(385, 30);
            this.m_robotPicker.Name = "m_robotPicker";
            this.m_robotPicker.Object = null;
            this.m_robotPicker.PickAndClear = false;
            this.m_robotPicker.PickLevel = Tecnomatix.Engineering.Ui.TxPickLevel.Component;
            this.m_robotPicker.PickOnly = false;
            this.m_robotPicker.ReadOnly = false;
            this.m_robotPicker.Size = new System.Drawing.Size(371, 26);
            this.m_robotPicker.TabIndex = 3;
            this.m_robotPicker.ValidatorType = Tecnomatix.Engineering.Ui.TxValidatorType.Robot;
            this.m_robotPicker.TypeInvalid += new System.EventHandler(this.m_robotPicker_TypeInvalid);
            this.m_robotPicker.TypeValid += new System.EventHandler(this.m_robotPicker_TypeValid);
            this.m_robotPicker.Picked += new Tecnomatix.Engineering.Ui.TxObjEditBoxCtrl_PickedEventHandler(this.m_robotPicker_Picked);
            // 
            // m_txtExternalID
            // 
            this.m_txtExternalID.Location = new System.Drawing.Point(385, 62);
            this.m_txtExternalID.Name = "m_txtExternalID";
            this.m_txtExternalID.ReadOnly = true;
            this.m_txtExternalID.Size = new System.Drawing.Size(371, 20);
            this.m_txtExternalID.TabIndex = 4;
            // 
            // cPath
            // 
            this.cPath.Location = new System.Drawing.Point(385, 91);
            this.cPath.Name = "cPath";
            this.cPath.ReadOnly = true;
            this.cPath.Size = new System.Drawing.Size(371, 20);
            this.cPath.TabIndex = 5;
            // 
            // m_btnClose
            // 
            this.m_btnClose.Location = new System.Drawing.Point(673, 150);
            this.m_btnClose.Name = "m_btnClose";
            this.m_btnClose.Size = new System.Drawing.Size(83, 29);
            this.m_btnClose.TabIndex = 6;
            this.m_btnClose.Text = "Close";
            this.m_btnClose.UseVisualStyleBackColor = true;
            this.m_btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // WriteAsBtn
            // 
            this.WriteAsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.WriteAsBtn.Location = new System.Drawing.Point(200, 133);
            this.WriteAsBtn.Name = "WriteAsBtn";
            this.WriteAsBtn.Size = new System.Drawing.Size(85, 46);
            this.WriteAsBtn.TabIndex = 50;
            this.WriteAsBtn.Text = "Export";
            this.WriteAsBtn.UseVisualStyleBackColor = true;
            this.WriteAsBtn.Click += new System.EventHandler(this.WriteAsBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(12, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "j12";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(12, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "j11";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(12, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "j9";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(12, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "j10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(12, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "j8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "j7";
            // 
            // ReadBtn
            // 
            this.ReadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ReadBtn.Location = new System.Drawing.Point(200, 29);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(85, 46);
            this.ReadBtn.TabIndex = 40;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(120, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Upper Limit";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.Location = new System.Drawing.Point(40, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Lower Limit";
            // 
            // Upper12
            // 
            this.Upper12.Location = new System.Drawing.Point(123, 159);
            this.Upper12.Name = "Upper12";
            this.Upper12.Size = new System.Drawing.Size(71, 20);
            this.Upper12.TabIndex = 39;
            this.Upper12.Click += new System.EventHandler(this.Upper12_Click);
            this.Upper12.TextChanged += new System.EventHandler(this.Upper12_TextChanged);
            // 
            // Upper11
            // 
            this.Upper11.Location = new System.Drawing.Point(123, 133);
            this.Upper11.Name = "Upper11";
            this.Upper11.Size = new System.Drawing.Size(71, 20);
            this.Upper11.TabIndex = 38;
            this.Upper11.Click += new System.EventHandler(this.Upper11_Click);
            this.Upper11.TextChanged += new System.EventHandler(this.Upper11_TextChanged);
            // 
            // Upper10
            // 
            this.Upper10.Location = new System.Drawing.Point(123, 107);
            this.Upper10.Name = "Upper10";
            this.Upper10.Size = new System.Drawing.Size(71, 20);
            this.Upper10.TabIndex = 37;
            this.Upper10.Click += new System.EventHandler(this.Upper10_Click);
            this.Upper10.TextChanged += new System.EventHandler(this.Upper10_TextChanged);
            // 
            // Upper9
            // 
            this.Upper9.Location = new System.Drawing.Point(123, 81);
            this.Upper9.Name = "Upper9";
            this.Upper9.Size = new System.Drawing.Size(71, 20);
            this.Upper9.TabIndex = 36;
            this.Upper9.Click += new System.EventHandler(this.Upper9_Click);
            this.Upper9.TextChanged += new System.EventHandler(this.Upper9_TextChanged);
            // 
            // Upper8
            // 
            this.Upper8.Location = new System.Drawing.Point(123, 55);
            this.Upper8.Name = "Upper8";
            this.Upper8.Size = new System.Drawing.Size(71, 20);
            this.Upper8.TabIndex = 35;
            this.Upper8.Click += new System.EventHandler(this.Upper8_Click);
            this.Upper8.TextChanged += new System.EventHandler(this.Upper8_TextChanged);
            // 
            // Upper7
            // 
            this.Upper7.Location = new System.Drawing.Point(123, 29);
            this.Upper7.Name = "Upper7";
            this.Upper7.Size = new System.Drawing.Size(71, 20);
            this.Upper7.TabIndex = 34;
            this.Upper7.Click += new System.EventHandler(this.Upper7_Click);
            this.Upper7.TextChanged += new System.EventHandler(this.Upper7_TextChanged);
            // 
            // Lower12
            // 
            this.Lower12.Location = new System.Drawing.Point(43, 159);
            this.Lower12.Name = "Lower12";
            this.Lower12.Size = new System.Drawing.Size(71, 20);
            this.Lower12.TabIndex = 33;
            this.Lower12.Click += new System.EventHandler(this.Lower12_Click);
            this.Lower12.TextChanged += new System.EventHandler(this.Lower12_TextChanged);
            // 
            // Lower11
            // 
            this.Lower11.Location = new System.Drawing.Point(43, 133);
            this.Lower11.Name = "Lower11";
            this.Lower11.Size = new System.Drawing.Size(71, 20);
            this.Lower11.TabIndex = 32;
            this.Lower11.Click += new System.EventHandler(this.Lower11_Click);
            this.Lower11.TextChanged += new System.EventHandler(this.Lower11_TextChanged);
            // 
            // Lower10
            // 
            this.Lower10.Location = new System.Drawing.Point(43, 107);
            this.Lower10.Name = "Lower10";
            this.Lower10.Size = new System.Drawing.Size(71, 20);
            this.Lower10.TabIndex = 30;
            this.Lower10.Click += new System.EventHandler(this.Lower10_Click);
            this.Lower10.TextChanged += new System.EventHandler(this.Lower10_TextChanged);
            // 
            // Lower9
            // 
            this.Lower9.Location = new System.Drawing.Point(43, 81);
            this.Lower9.Name = "Lower9";
            this.Lower9.Size = new System.Drawing.Size(71, 20);
            this.Lower9.TabIndex = 29;
            this.Lower9.Click += new System.EventHandler(this.Lower9_Click);
            this.Lower9.TextChanged += new System.EventHandler(this.Lower9_TextChanged);
            // 
            // Lower7
            // 
            this.Lower7.Location = new System.Drawing.Point(43, 29);
            this.Lower7.Name = "Lower7";
            this.Lower7.Size = new System.Drawing.Size(71, 20);
            this.Lower7.TabIndex = 27;
            this.Lower7.Click += new System.EventHandler(this.Lower7_Click);
            this.Lower7.TextChanged += new System.EventHandler(this.Lower7_TextChanged);
            // 
            // writeBtn
            // 
            this.writeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.writeBtn.Location = new System.Drawing.Point(200, 81);
            this.writeBtn.Name = "writeBtn";
            this.writeBtn.Size = new System.Drawing.Size(85, 46);
            this.writeBtn.TabIndex = 41;
            this.writeBtn.Text = "Write";
            this.writeBtn.UseVisualStyleBackColor = true;
            this.writeBtn.Click += new System.EventHandler(this.WriteBtn);
            // 
            // Lower8
            // 
            this.Lower8.Location = new System.Drawing.Point(43, 55);
            this.Lower8.Name = "Lower8";
            this.Lower8.Size = new System.Drawing.Size(71, 20);
            this.Lower8.TabIndex = 28;
            this.Lower8.Click += new System.EventHandler(this.Lower8_Click_1);
            this.Lower8.TextChanged += new System.EventHandler(this.Lower8_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current path";
            // 
            // ePath
            // 
            this.ePath.Location = new System.Drawing.Point(385, 117);
            this.ePath.Name = "ePath";
            this.ePath.Size = new System.Drawing.Size(371, 20);
            this.ePath.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(314, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Export path";
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(584, 150);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(83, 29);
            this.Help.TabIndex = 53;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // TxRobotAxisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 190);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ePath);
            this.Controls.Add(this.WriteAsBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Upper12);
            this.Controls.Add(this.Upper11);
            this.Controls.Add(this.Upper10);
            this.Controls.Add(this.Upper9);
            this.Controls.Add(this.Upper8);
            this.Controls.Add(this.Upper7);
            this.Controls.Add(this.Lower12);
            this.Controls.Add(this.Lower11);
            this.Controls.Add(this.Lower10);
            this.Controls.Add(this.Lower9);
            this.Controls.Add(this.Lower7);
            this.Controls.Add(this.writeBtn);
            this.Controls.Add(this.Lower8);
            this.Controls.Add(this.m_btnClose);
            this.Controls.Add(this.cPath);
            this.Controls.Add(this.m_txtExternalID);
            this.Controls.Add(this.m_robotPicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TxRobotAxisForm";
            this.ShouldCloseOnDocumentUnloading = true;
            this.ShowIcon = false;
            this.Text = "KUKA external axis limits changer $machine.dat ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Tecnomatix.Engineering.Ui.TxObjEditBoxCtrl m_robotPicker;
        private System.Windows.Forms.TextBox m_txtExternalID;
        private System.Windows.Forms.TextBox cPath;
        private System.Windows.Forms.Button m_btnClose;
        private System.Windows.Forms.Button WriteAsBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Upper12;
        private System.Windows.Forms.TextBox Upper11;
        private System.Windows.Forms.TextBox Upper10;
        private System.Windows.Forms.TextBox Upper9;
        private System.Windows.Forms.TextBox Upper8;
        private System.Windows.Forms.TextBox Upper7;
        private System.Windows.Forms.TextBox Lower12;
        private System.Windows.Forms.TextBox Lower11;
        private System.Windows.Forms.TextBox Lower10;
        private System.Windows.Forms.TextBox Lower9;
        private System.Windows.Forms.TextBox Lower7;
        private System.Windows.Forms.Button writeBtn;
        private System.Windows.Forms.TextBox Lower8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ePath;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Help;
    }
}