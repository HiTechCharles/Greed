namespace Greed
{
    partial class GreedGame
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
            this.GameLogRTB = new System.Windows.Forms.RichTextBox();
            this.CurScoreLBL = new System.Windows.Forms.Label();
            this.RollBTN = new System.Windows.Forms.Button();
            this.StopBTN = new System.Windows.Forms.Button();
            this.CurScoreNUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CurScoreNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // GameLogRTB
            // 
            this.GameLogRTB.Location = new System.Drawing.Point(12, 12);
            this.GameLogRTB.Name = "GameLogRTB";
            this.GameLogRTB.ReadOnly = true;
            this.GameLogRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.GameLogRTB.Size = new System.Drawing.Size(463, 609);
            this.GameLogRTB.TabIndex = 14;
            this.GameLogRTB.Text = "";
            this.GameLogRTB.TextChanged += new System.EventHandler(this.GameLogRTB_TextChanged);
            // 
            // CurScoreLBL
            // 
            this.CurScoreLBL.AutoSize = true;
            this.CurScoreLBL.Location = new System.Drawing.Point(5, 650);
            this.CurScoreLBL.Name = "CurScoreLBL";
            this.CurScoreLBL.Size = new System.Drawing.Size(219, 39);
            this.CurScoreLBL.TabIndex = 5;
            this.CurScoreLBL.Text = "Round Sc&ore";
            // 
            // RollBTN
            // 
            this.RollBTN.ForeColor = System.Drawing.Color.Black;
            this.RollBTN.Location = new System.Drawing.Point(12, 724);
            this.RollBTN.Name = "RollBTN";
            this.RollBTN.Size = new System.Drawing.Size(150, 55);
            this.RollBTN.TabIndex = 6;
            this.RollBTN.Text = "&Roll";
            this.RollBTN.UseVisualStyleBackColor = true;
            this.RollBTN.Click += new System.EventHandler(this.RollBTN_Click);
            // 
            // StopBTN
            // 
            this.StopBTN.ForeColor = System.Drawing.Color.Black;
            this.StopBTN.Location = new System.Drawing.Point(193, 724);
            this.StopBTN.Name = "StopBTN";
            this.StopBTN.Size = new System.Drawing.Size(150, 55);
            this.StopBTN.TabIndex = 7;
            this.StopBTN.Text = "&Stop";
            this.StopBTN.UseVisualStyleBackColor = true;
            this.StopBTN.Click += new System.EventHandler(this.StopBTN_Click);
            // 
            // CurScoreNUD
            // 
            this.CurScoreNUD.Location = new System.Drawing.Point(240, 643);
            this.CurScoreNUD.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CurScoreNUD.Name = "CurScoreNUD";
            this.CurScoreNUD.Size = new System.Drawing.Size(103, 46);
            this.CurScoreNUD.TabIndex = 8;
            // 
            // GreedGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(487, 791);
            this.Controls.Add(this.GameLogRTB);
            this.Controls.Add(this.CurScoreNUD);
            this.Controls.Add(this.StopBTN);
            this.Controls.Add(this.RollBTN);
            this.Controls.Add(this.CurScoreLBL);
            this.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "GreedGame";
            this.Text = "?";
            this.Load += new System.EventHandler(this.GreedGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CurScoreNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox GameLogRTB;
        private System.Windows.Forms.Label CurScoreLBL;
        private System.Windows.Forms.Button RollBTN;
        private System.Windows.Forms.Button StopBTN;
        private System.Windows.Forms.NumericUpDown CurScoreNUD;
    }
}