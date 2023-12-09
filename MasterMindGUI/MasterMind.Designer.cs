namespace MasterMindGUI
{
    partial class MasterMind
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnMagenta = new System.Windows.Forms.Button();
            this.btnCyan = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.btnEraseOne = new System.Windows.Forms.Button();
            this.cheatBox = new System.Windows.Forms.CheckBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.ForeColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(627, 30);
            this.btnRed.Margin = new System.Windows.Forms.Padding(0);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(38, 38);
            this.btnRed.TabIndex = 2;
            this.btnRed.Text = "R";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.ForeColor = System.Drawing.Color.Green;
            this.btnGreen.Location = new System.Drawing.Point(627, 90);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(38, 38);
            this.btnGreen.TabIndex = 7;
            this.btnGreen.Text = "G";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.ForeColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(627, 210);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(38, 38);
            this.btnYellow.TabIndex = 12;
            this.btnYellow.Text = "Y";
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.ForeColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(627, 150);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(38, 38);
            this.btnBlue.TabIndex = 13;
            this.btnBlue.Text = "B";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrange.ForeColor = System.Drawing.Color.Orange;
            this.btnOrange.Location = new System.Drawing.Point(627, 270);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(38, 38);
            this.btnOrange.TabIndex = 14;
            this.btnOrange.Text = "O";
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnMagenta
            // 
            this.btnMagenta.BackColor = System.Drawing.Color.Magenta;
            this.btnMagenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnMagenta.ForeColor = System.Drawing.Color.Magenta;
            this.btnMagenta.Location = new System.Drawing.Point(627, 390);
            this.btnMagenta.Name = "btnMagenta";
            this.btnMagenta.Size = new System.Drawing.Size(38, 38);
            this.btnMagenta.TabIndex = 15;
            this.btnMagenta.Text = "M";
            this.btnMagenta.UseVisualStyleBackColor = false;
            this.btnMagenta.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnCyan
            // 
            this.btnCyan.BackColor = System.Drawing.Color.Cyan;
            this.btnCyan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCyan.ForeColor = System.Drawing.Color.Cyan;
            this.btnCyan.Location = new System.Drawing.Point(627, 330);
            this.btnCyan.Name = "btnCyan";
            this.btnCyan.Size = new System.Drawing.Size(38, 38);
            this.btnCyan.TabIndex = 16;
            this.btnCyan.Text = "C";
            this.btnCyan.UseVisualStyleBackColor = false;
            this.btnCyan.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(559, 478);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(106, 41);
            this.btnValidate.TabIndex = 17;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(559, 572);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(106, 41);
            this.btnErase.TabIndex = 18;
            this.btnErase.Text = "Effacer tout";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.Location = new System.Drawing.Point(15, 585);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(106, 41);
            this.btnReturnMenu.TabIndex = 23;
            this.btnReturnMenu.Text = "Retour au menu";
            this.btnReturnMenu.UseVisualStyleBackColor = true;
            this.btnReturnMenu.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // pnlResults
            // 
            this.pnlResults.Location = new System.Drawing.Point(15, 30);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(538, 536);
            this.pnlResults.TabIndex = 24;
            // 
            // btnEraseOne
            // 
            this.btnEraseOne.Location = new System.Drawing.Point(559, 525);
            this.btnEraseOne.Name = "btnEraseOne";
            this.btnEraseOne.Size = new System.Drawing.Size(106, 41);
            this.btnEraseOne.TabIndex = 25;
            this.btnEraseOne.Text = "Effacer ";
            this.btnEraseOne.UseVisualStyleBackColor = true;
            this.btnEraseOne.Click += new System.EventHandler(this.btnEraseOne_Click);
            // 
            // cheatBox
            // 
            this.cheatBox.AutoSize = true;
            this.cheatBox.Location = new System.Drawing.Point(304, 596);
            this.cheatBox.Name = "cheatBox";
            this.cheatBox.Size = new System.Drawing.Size(59, 17);
            this.cheatBox.TabIndex = 26;
            this.cheatBox.Text = "Tricher";
            this.cheatBox.UseVisualStyleBackColor = true;
            this.cheatBox.CheckedChanged += new System.EventHandler(this.cheatBox_CheckedChanged);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(405, 596);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer.TabIndex = 27;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(138, 585);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 41);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MasterMind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 638);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.cheatBox);
            this.Controls.Add(this.btnEraseOne);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.btnReturnMenu);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnCyan);
            this.Controls.Add(this.btnMagenta);
            this.Controls.Add(this.btnOrange);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MasterMind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterMind";
            this.VisibleChanged += new System.EventHandler(this.MasterMind_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnMagenta;
        private System.Windows.Forms.Button btnCyan;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnReturnMenu;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Button btnEraseOne;
        private System.Windows.Forms.CheckBox cheatBox;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnReset;
    }
}

