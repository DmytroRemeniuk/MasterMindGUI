namespace MasterMindGUI
{
    partial class Menu
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
            this.tableLayoutMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.rdbFrench = new System.Windows.Forms.RadioButton();
            this.rdbEnglish = new System.Windows.Forms.RadioButton();
            this.rdbUkrainian = new System.Windows.Forms.RadioButton();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.tableLayoutMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutMenu
            // 
            this.tableLayoutMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutMenu.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutMenu.ColumnCount = 3;
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.02378F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.58323F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.26783F));
            this.tableLayoutMenu.Controls.Add(this.btnPlay, 1, 2);
            this.tableLayoutMenu.Controls.Add(this.btnRules, 1, 4);
            this.tableLayoutMenu.Controls.Add(this.btnOptions, 1, 3);
            this.tableLayoutMenu.Controls.Add(this.btnQuit, 1, 5);
            this.tableLayoutMenu.Controls.Add(this.lblWelcome, 1, 1);
            this.tableLayoutMenu.Controls.Add(this.rdbFrench, 0, 3);
            this.tableLayoutMenu.Controls.Add(this.rdbEnglish, 0, 4);
            this.tableLayoutMenu.Controls.Add(this.rdbUkrainian, 0, 5);
            this.tableLayoutMenu.Controls.Add(this.lblLanguage, 0, 2);
            this.tableLayoutMenu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMenu.Name = "tableLayoutMenu";
            this.tableLayoutMenu.RowCount = 7;
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.9423F));
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.05769F));
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutMenu.Size = new System.Drawing.Size(799, 450);
            this.tableLayoutMenu.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Lime;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnPlay.Location = new System.Drawing.Point(155, 191);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(432, 40);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Jouer";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRules.Location = new System.Drawing.Point(155, 284);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(432, 41);
            this.btnRules.TabIndex = 3;
            this.btnRules.Text = "Règles";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOptions.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnOptions.Location = new System.Drawing.Point(202, 237);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(432, 40);
            this.btnOptions.TabIndex = 2;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuit.BackColor = System.Drawing.Color.Red;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnQuit.Location = new System.Drawing.Point(202, 332);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(432, 41);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Black;
            this.lblWelcome.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Orange;
            this.lblWelcome.Location = new System.Drawing.Point(220, 66);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(396, 120);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = " Bienvenue sur MasterMind!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbFrench
            // 
            this.rdbFrench.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbFrench.AutoSize = true;
            this.rdbFrench.Checked = true;
            this.rdbFrench.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFrench.ForeColor = System.Drawing.Color.White;
            this.rdbFrench.Location = new System.Drawing.Point(28, 245);
            this.rdbFrench.Name = "rdbFrench";
            this.rdbFrench.Size = new System.Drawing.Size(96, 24);
            this.rdbFrench.TabIndex = 5;
            this.rdbFrench.TabStop = true;
            this.rdbFrench.Text = "Français";
            this.rdbFrench.UseVisualStyleBackColor = true;
            this.rdbFrench.CheckedChanged += new System.EventHandler(this.language_CheckedChanged);
            // 
            // rdbEnglish
            // 
            this.rdbEnglish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbEnglish.AutoSize = true;
            this.rdbEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEnglish.ForeColor = System.Drawing.Color.White;
            this.rdbEnglish.Location = new System.Drawing.Point(33, 293);
            this.rdbEnglish.Name = "rdbEnglish";
            this.rdbEnglish.Size = new System.Drawing.Size(86, 24);
            this.rdbEnglish.TabIndex = 6;
            this.rdbEnglish.Text = "English";
            this.rdbEnglish.UseVisualStyleBackColor = true;
            this.rdbEnglish.CheckedChanged += new System.EventHandler(this.language_CheckedChanged);
            // 
            // rdbUkrainian
            // 
            this.rdbUkrainian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbUkrainian.AutoSize = true;
            this.rdbUkrainian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUkrainian.ForeColor = System.Drawing.Color.White;
            this.rdbUkrainian.Location = new System.Drawing.Point(16, 341);
            this.rdbUkrainian.Name = "rdbUkrainian";
            this.rdbUkrainian.Size = new System.Drawing.Size(119, 24);
            this.rdbUkrainian.TabIndex = 7;
            this.rdbUkrainian.Text = "Українська";
            this.rdbUkrainian.UseVisualStyleBackColor = true;
            this.rdbUkrainian.CheckedChanged += new System.EventHandler(this.language_CheckedChanged);
            // 
            // lblLanguage
            // 
            this.lblLanguage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.BackColor = System.Drawing.Color.Transparent;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.ForeColor = System.Drawing.Color.White;
            this.lblLanguage.Location = new System.Drawing.Point(23, 196);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(106, 29);
            this.lblLanguage.TabIndex = 8;
            this.lblLanguage.Text = "Langue:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutMenu);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaserMind Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tableLayoutMenu.ResumeLayout(false);
            this.tableLayoutMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMenu;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.RadioButton rdbFrench;
        private System.Windows.Forms.RadioButton rdbEnglish;
        private System.Windows.Forms.RadioButton rdbUkrainian;
        private System.Windows.Forms.Label lblLanguage;
    }
}