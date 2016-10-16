namespace DataBaseLaba3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AdministrationTab = new System.Windows.Forms.TabPage();
            this.AccountMangmentTab = new System.Windows.Forms.TabPage();
            this.CharactersTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectionLabel = new System.Windows.Forms.Label();
            this.ConnetcBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.AdministrationTab);
            this.tabControl1.Controls.Add(this.AccountMangmentTab);
            this.tabControl1.Controls.Add(this.CharactersTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(950, 472);
            this.tabControl1.TabIndex = 0;
            // 
            // AdministrationTab
            // 
            this.AdministrationTab.Location = new System.Drawing.Point(4, 22);
            this.AdministrationTab.Name = "AdministrationTab";
            this.AdministrationTab.Padding = new System.Windows.Forms.Padding(3);
            this.AdministrationTab.Size = new System.Drawing.Size(942, 446);
            this.AdministrationTab.TabIndex = 0;
            this.AdministrationTab.Text = "Адміністрація";
            this.AdministrationTab.UseVisualStyleBackColor = true;
            // 
            // AccountMangmentTab
            // 
            this.AccountMangmentTab.Location = new System.Drawing.Point(4, 22);
            this.AccountMangmentTab.Name = "AccountMangmentTab";
            this.AccountMangmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.AccountMangmentTab.Size = new System.Drawing.Size(942, 446);
            this.AccountMangmentTab.TabIndex = 1;
            this.AccountMangmentTab.Text = "Створення аккаунтів";
            this.AccountMangmentTab.UseVisualStyleBackColor = true;
            // 
            // CharactersTab
            // 
            this.CharactersTab.Location = new System.Drawing.Point(4, 22);
            this.CharactersTab.Name = "CharactersTab";
            this.CharactersTab.Padding = new System.Windows.Forms.Padding(3);
            this.CharactersTab.Size = new System.Drawing.Size(942, 446);
            this.CharactersTab.TabIndex = 3;
            this.CharactersTab.Text = "Ігрові персонажі";
            this.CharactersTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(803, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcom, manager.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConnectionLabel
            // 
            this.ConnectionLabel.AutoSize = true;
            this.ConnectionLabel.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConnectionLabel.Location = new System.Drawing.Point(12, -2);
            this.ConnectionLabel.Name = "ConnectionLabel";
            this.ConnectionLabel.Size = new System.Drawing.Size(211, 28);
            this.ConnectionLabel.TabIndex = 2;
            this.ConnectionLabel.Text = "Database is disconnetced";
            // 
            // ConnetcBtn
            // 
            this.ConnetcBtn.Location = new System.Drawing.Point(231, 3);
            this.ConnetcBtn.Name = "ConnetcBtn";
            this.ConnetcBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnetcBtn.TabIndex = 3;
            this.ConnetcBtn.Text = "Connect";
            this.ConnetcBtn.UseVisualStyleBackColor = true;
            this.ConnetcBtn.Click += new System.EventHandler(this.ConnetcBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(986, 503);
            this.Controls.Add(this.ConnetcBtn);
            this.Controls.Add(this.ConnectionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "RPG";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AdministrationTab;
        private System.Windows.Forms.TabPage AccountMangmentTab;
        private System.Windows.Forms.TabPage CharactersTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ConnectionLabel;
        private System.Windows.Forms.Button ConnetcBtn;
    }
}

