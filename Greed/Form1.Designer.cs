namespace Greed
{
    partial class PlayerSettings
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
            this.PlayerTypesGB = new System.Windows.Forms.GroupBox();
            this.PlayerTypeCB = new System.Windows.Forms.ComboBox();
            this.Player1LBL = new System.Windows.Forms.Label();
            this.Player2LBL = new System.Windows.Forms.Label();
            this.PlayerNamesGB = new System.Windows.Forms.GroupBox();
            this.Name2TB = new System.Windows.Forms.TextBox();
            this.Name1TB = new System.Windows.Forms.TextBox();
            this.PlayBTN = new System.Windows.Forms.Button();
            this.SpeechCHK = new System.Windows.Forms.CheckBox();
            this.PlayerTypesGB.SuspendLayout();
            this.PlayerNamesGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerTypesGB
            // 
            this.PlayerTypesGB.Controls.Add(this.PlayerTypeCB);
            this.PlayerTypesGB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayerTypesGB.Location = new System.Drawing.Point(19, 18);
            this.PlayerTypesGB.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.PlayerTypesGB.Name = "PlayerTypesGB";
            this.PlayerTypesGB.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.PlayerTypesGB.Size = new System.Drawing.Size(472, 140);
            this.PlayerTypesGB.TabIndex = 0;
            this.PlayerTypesGB.TabStop = false;
            this.PlayerTypesGB.Text = "Player &Types";
            // 
            // PlayerTypeCB
            // 
            this.PlayerTypeCB.Cursor = System.Windows.Forms.Cursors.Default;
            this.PlayerTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerTypeCB.FormattingEnabled = true;
            this.PlayerTypeCB.Items.AddRange(new object[] {
            "Human Vs Computer",
            "Human Vs Human",
            "Computer Vs Computer\t\t\t"});
            this.PlayerTypeCB.Location = new System.Drawing.Point(27, 60);
            this.PlayerTypeCB.MaxDropDownItems = 3;
            this.PlayerTypeCB.Name = "PlayerTypeCB";
            this.PlayerTypeCB.Size = new System.Drawing.Size(429, 47);
            this.PlayerTypeCB.TabIndex = 0;
            this.PlayerTypeCB.SelectedIndexChanged += new System.EventHandler(this.PlayerTypeCB_SelectedIndexChanged);
            // 
            // Player1LBL
            // 
            this.Player1LBL.AutoSize = true;
            this.Player1LBL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Player1LBL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Player1LBL.Location = new System.Drawing.Point(20, 53);
            this.Player1LBL.Name = "Player1LBL";
            this.Player1LBL.Size = new System.Drawing.Size(147, 39);
            this.Player1LBL.TabIndex = 0;
            this.Player1LBL.Text = "Player &1";
            // 
            // Player2LBL
            // 
            this.Player2LBL.AutoSize = true;
            this.Player2LBL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Player2LBL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Player2LBL.Location = new System.Drawing.Point(20, 123);
            this.Player2LBL.Name = "Player2LBL";
            this.Player2LBL.Size = new System.Drawing.Size(147, 39);
            this.Player2LBL.TabIndex = 2;
            this.Player2LBL.Text = "Player &2";
            // 
            // PlayerNamesGB
            // 
            this.PlayerNamesGB.Controls.Add(this.Name2TB);
            this.PlayerNamesGB.Controls.Add(this.Name1TB);
            this.PlayerNamesGB.Controls.Add(this.Player1LBL);
            this.PlayerNamesGB.Controls.Add(this.Player2LBL);
            this.PlayerNamesGB.ForeColor = System.Drawing.Color.White;
            this.PlayerNamesGB.Location = new System.Drawing.Point(19, 188);
            this.PlayerNamesGB.Name = "PlayerNamesGB";
            this.PlayerNamesGB.Size = new System.Drawing.Size(472, 175);
            this.PlayerNamesGB.TabIndex = 1;
            this.PlayerNamesGB.TabStop = false;
            this.PlayerNamesGB.Text = "Player &Names";
            // 
            // Name2TB
            // 
            this.Name2TB.Location = new System.Drawing.Point(173, 117);
            this.Name2TB.Name = "Name2TB";
            this.Name2TB.Size = new System.Drawing.Size(283, 46);
            this.Name2TB.TabIndex = 3;
            this.Name2TB.TextChanged += new System.EventHandler(this.Name2_TextChanged);
            // 
            // Name1TB
            // 
            this.Name1TB.Location = new System.Drawing.Point(173, 45);
            this.Name1TB.Multiline = true;
            this.Name1TB.Name = "Name1TB";
            this.Name1TB.Size = new System.Drawing.Size(283, 46);
            this.Name1TB.TabIndex = 1;
            this.Name1TB.TextChanged += new System.EventHandler(this.Name1TB_TextChanged);
            // 
            // PlayBTN
            // 
            this.PlayBTN.AutoSize = true;
            this.PlayBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.PlayBTN.Location = new System.Drawing.Point(342, 378);
            this.PlayBTN.Name = "PlayBTN";
            this.PlayBTN.Size = new System.Drawing.Size(127, 53);
            this.PlayBTN.TabIndex = 3;
            this.PlayBTN.Text = "Play!";
            this.PlayBTN.UseVisualStyleBackColor = true;
            this.PlayBTN.Click += new System.EventHandler(this.PlayBTN_Click);
            // 
            // SpeechCHK
            // 
            this.SpeechCHK.AutoSize = true;
            this.SpeechCHK.ForeColor = System.Drawing.Color.White;
            this.SpeechCHK.Location = new System.Drawing.Point(19, 388);
            this.SpeechCHK.Name = "SpeechCHK";
            this.SpeechCHK.Size = new System.Drawing.Size(300, 43);
            this.SpeechCHK.TabIndex = 2;
            this.SpeechCHK.Text = "&Speak Dice Rolls";
            this.SpeechCHK.UseVisualStyleBackColor = true;
            this.SpeechCHK.CheckedChanged += new System.EventHandler(this.SpeechCHK_CheckedChanged);
            // 
            // PlayerSettings
            // 
            this.AccessibleName = "Welcome to Greed";
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(481, 458);
            this.Controls.Add(this.SpeechCHK);
            this.Controls.Add(this.PlayBTN);
            this.Controls.Add(this.PlayerNamesGB);
            this.Controls.Add(this.PlayerTypesGB);
            this.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "PlayerSettings";
            this.Text = "Player Settings";
            this.PlayerTypesGB.ResumeLayout(false);
            this.PlayerNamesGB.ResumeLayout(false);
            this.PlayerNamesGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PlayerTypesGB;
        private System.Windows.Forms.Label Player1LBL;
        protected System.Windows.Forms.Label Player2LBL;
        private System.Windows.Forms.GroupBox PlayerNamesGB;
        private System.Windows.Forms.TextBox Name1TB;
        private System.Windows.Forms.TextBox Name2TB;
        private System.Windows.Forms.Button PlayBTN;
        private System.Windows.Forms.ComboBox PlayerTypeCB;
        private System.Windows.Forms.CheckBox SpeechCHK;
    }
}

