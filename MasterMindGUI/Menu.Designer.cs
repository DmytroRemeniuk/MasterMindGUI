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
            this.tableLayoutMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutMenu
            // 
            this.tableLayoutMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutMenu.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutMenu.ColumnCount = 3;
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.31269F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.64383F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutMenu.Controls.Add(this.btnPlay, 1, 2);
            this.tableLayoutMenu.Controls.Add(this.btnRules, 1, 4);
            this.tableLayoutMenu.Controls.Add(this.btnOptions, 1, 3);
            this.tableLayoutMenu.Controls.Add(this.btnQuit, 1, 5);
            this.tableLayoutMenu.Controls.Add(this.lblWelcome, 1, 1);
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
            this.btnPlay.Location = new System.Drawing.Point(205, 191);
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
            this.btnRules.Location = new System.Drawing.Point(205, 284);
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
            this.btnOptions.Location = new System.Drawing.Point(232, 237);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(432, 41);
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
            this.btnQuit.Location = new System.Drawing.Point(232, 332);
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
            this.lblWelcome.Location = new System.Drawing.Point(250, 66);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(396, 120);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = " Bienvenue sur MasterMind!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MasterMindGUI.Properties.Resources.maxresdefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutMenu);
            this.Name = "Menu";
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
    }
}