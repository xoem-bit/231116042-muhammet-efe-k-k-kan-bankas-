namespace _231116042_muhammet_efe_kök_kan_bankası
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuCircleProgress1 = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Red;
            this.bunifuLabel1.Location = new System.Drawing.Point(187, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(654, 65);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Kan Bankası Yönetim Sistemi";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuCircleProgress1
            // 
            this.bunifuCircleProgress1.Animated = false;
            this.bunifuCircleProgress1.AnimationInterval = 1;
            this.bunifuCircleProgress1.AnimationSpeed = 1;
            this.bunifuCircleProgress1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgress1.CircleMargin = 10;
            this.bunifuCircleProgress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.bunifuCircleProgress1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCircleProgress1.IsPercentage = false;
            this.bunifuCircleProgress1.LineProgressThickness = 10;
            this.bunifuCircleProgress1.LineThickness = 10;
            this.bunifuCircleProgress1.Location = new System.Drawing.Point(377, 149);
            this.bunifuCircleProgress1.Name = "bunifuCircleProgress1";
            this.bunifuCircleProgress1.ProgressAnimationSpeed = 200;
            this.bunifuCircleProgress1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgress1.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress1.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress1.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress1.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.bunifuCircleProgress1.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bunifuCircleProgress1.Size = new System.Drawing.Size(267, 267);
            this.bunifuCircleProgress1.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress1.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.bunifuCircleProgress1.SubScriptText = ".00";
            this.bunifuCircleProgress1.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress1.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.bunifuCircleProgress1.SuperScriptText = "°C";
            this.bunifuCircleProgress1.TabIndex = 16;
            this.bunifuCircleProgress1.Text = "30";
            this.bunifuCircleProgress1.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bunifuCircleProgress1.Value = 30;
            this.bunifuCircleProgress1.ValueByTransition = 30;
            this.bunifuCircleProgress1.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 600);
            this.Controls.Add(this.bunifuCircleProgress1);
            this.Controls.Add(this.bunifuLabel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuCircleProgress bunifuCircleProgress1;
    }
}

