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
            this.pnlPositionsResults = new System.Windows.Forms.Panel();
            this.btnEraseOne = new System.Windows.Forms.Button();
            this.cheatBox = new System.Windows.Forms.CheckBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExemple1 = new System.Windows.Forms.Button();
            this.lblExemple1 = new System.Windows.Forms.Label();
            this.lblExemple2 = new System.Windows.Forms.Label();
            this.btnExemple2 = new System.Windows.Forms.Button();
            this.lblExemple3 = new System.Windows.Forms.Label();
            this.btnExemple3 = new System.Windows.Forms.Button();
            this.pnlResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.ForeColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(295, 30);
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
            this.btnGreen.Location = new System.Drawing.Point(295, 90);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(38, 38);
            this.btnGreen.TabIndex = 7;
            this.btnGreen.Text = "V";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.ForeColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(295, 210);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(38, 38);
            this.btnYellow.TabIndex = 12;
            this.btnYellow.Text = "J";
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.ForeColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(295, 150);
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
            this.btnOrange.Location = new System.Drawing.Point(295, 270);
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
            this.btnMagenta.Location = new System.Drawing.Point(295, 390);
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
            this.btnCyan.Location = new System.Drawing.Point(295, 330);
            this.btnCyan.Name = "btnCyan";
            this.btnCyan.Size = new System.Drawing.Size(38, 38);
            this.btnCyan.TabIndex = 16;
            this.btnCyan.Text = "C";
            this.btnCyan.UseVisualStyleBackColor = false;
            this.btnCyan.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(227, 453);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(106, 41);
            this.btnValidate.TabIndex = 17;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(227, 545);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(106, 41);
            this.btnErase.TabIndex = 18;
            this.btnErase.Text = "Effacer tout";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.Location = new System.Drawing.Point(12, 543);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(106, 41);
            this.btnReturnMenu.TabIndex = 23;
            this.btnReturnMenu.Text = "Retour au menu";
            this.btnReturnMenu.UseVisualStyleBackColor = true;
            this.btnReturnMenu.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // pnlResults
            // 
            this.pnlResults.BackColor = System.Drawing.Color.Transparent;
            this.pnlResults.Controls.Add(this.pnlPositionsResults);
            this.pnlResults.Location = new System.Drawing.Point(15, 30);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(266, 419);
            this.pnlResults.TabIndex = 24;
            // 
            // pnlPositionsResults
            // 
            this.pnlPositionsResults.BackColor = System.Drawing.Color.Transparent;
            this.pnlPositionsResults.Location = new System.Drawing.Point(80, 0);
            this.pnlPositionsResults.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPositionsResults.Name = "pnlPositionsResults";
            this.pnlPositionsResults.Size = new System.Drawing.Size(191, 419);
            this.pnlPositionsResults.TabIndex = 0;
            // 
            // btnEraseOne
            // 
            this.btnEraseOne.Location = new System.Drawing.Point(227, 499);
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
            this.cheatBox.BackColor = System.Drawing.Color.Transparent;
            this.cheatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cheatBox.ForeColor = System.Drawing.Color.White;
            this.cheatBox.Location = new System.Drawing.Point(144, 505);
            this.cheatBox.Name = "cheatBox";
            this.cheatBox.Size = new System.Drawing.Size(76, 24);
            this.cheatBox.TabIndex = 26;
            this.cheatBox.Text = "Tricher";
            this.cheatBox.UseVisualStyleBackColor = false;
            this.cheatBox.CheckedChanged += new System.EventHandler(this.cheatBox_CheckedChanged);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAnswer.ForeColor = System.Drawing.Color.White;
            this.lblAnswer.Location = new System.Drawing.Point(140, 543);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 20);
            this.lblAnswer.TabIndex = 27;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 496);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 41);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExemple1
            // 
            this.btnExemple1.BackColor = System.Drawing.Color.White;
            this.btnExemple1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExemple1.Location = new System.Drawing.Point(23, 6);
            this.btnExemple1.Margin = new System.Windows.Forms.Padding(2);
            this.btnExemple1.Name = "btnExemple1";
            this.btnExemple1.Size = new System.Drawing.Size(12, 12);
            this.btnExemple1.TabIndex = 29;
            this.btnExemple1.UseVisualStyleBackColor = false;
            // 
            // lblExemple1
            // 
            this.lblExemple1.AutoSize = true;
            this.lblExemple1.BackColor = System.Drawing.Color.Transparent;
            this.lblExemple1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExemple1.ForeColor = System.Drawing.Color.White;
            this.lblExemple1.Location = new System.Drawing.Point(39, 6);
            this.lblExemple1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExemple1.Name = "lblExemple1";
            this.lblExemple1.Size = new System.Drawing.Size(98, 13);
            this.lblExemple1.TabIndex = 30;
            this.lblExemple1.Text = "- bonne position";
            // 
            // lblExemple2
            // 
            this.lblExemple2.AutoSize = true;
            this.lblExemple2.BackColor = System.Drawing.Color.Transparent;
            this.lblExemple2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExemple2.ForeColor = System.Drawing.Color.White;
            this.lblExemple2.Location = new System.Drawing.Point(160, 6);
            this.lblExemple2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExemple2.Name = "lblExemple2";
            this.lblExemple2.Size = new System.Drawing.Size(116, 13);
            this.lblExemple2.TabIndex = 32;
            this.lblExemple2.Text = "- mauvaise position";
            // 
            // btnExemple2
            // 
            this.btnExemple2.BackColor = System.Drawing.Color.Black;
            this.btnExemple2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExemple2.Location = new System.Drawing.Point(144, 6);
            this.btnExemple2.Margin = new System.Windows.Forms.Padding(2);
            this.btnExemple2.Name = "btnExemple2";
            this.btnExemple2.Size = new System.Drawing.Size(12, 12);
            this.btnExemple2.TabIndex = 31;
            this.btnExemple2.UseVisualStyleBackColor = false;
            // 
            // lblExemple3
            // 
            this.lblExemple3.AutoSize = true;
            this.lblExemple3.BackColor = System.Drawing.Color.Transparent;
            this.lblExemple3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExemple3.ForeColor = System.Drawing.Color.White;
            this.lblExemple3.Location = new System.Drawing.Point(296, 7);
            this.lblExemple3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExemple3.Name = "lblExemple3";
            this.lblExemple3.Size = new System.Drawing.Size(36, 13);
            this.lblExemple3.TabIndex = 34;
            this.lblExemple3.Text = "- rien";
            // 
            // btnExemple3
            // 
            this.btnExemple3.BackColor = System.Drawing.Color.Brown;
            this.btnExemple3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExemple3.Location = new System.Drawing.Point(280, 7);
            this.btnExemple3.Margin = new System.Windows.Forms.Padding(2);
            this.btnExemple3.Name = "btnExemple3";
            this.btnExemple3.Size = new System.Drawing.Size(12, 12);
            this.btnExemple3.TabIndex = 33;
            this.btnExemple3.UseVisualStyleBackColor = false;
            // 
            // MasterMind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MasterMindGUI.Properties.Resources.red_wood_texture_interior_design_360074_20903;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(347, 590);
            this.Controls.Add(this.lblExemple3);
            this.Controls.Add(this.btnExemple3);
            this.Controls.Add(this.lblExemple2);
            this.Controls.Add(this.btnExemple2);
            this.Controls.Add(this.lblExemple1);
            this.Controls.Add(this.btnExemple1);
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
            this.MaximizeBox = false;
            this.Name = "MasterMind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterMind";
            this.Load += new System.EventHandler(this.MasterMind_Load);
            this.pnlResults.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlPositionsResults;
        private System.Windows.Forms.Button btnExemple1;
        private System.Windows.Forms.Label lblExemple1;
        private System.Windows.Forms.Label lblExemple2;
        private System.Windows.Forms.Button btnExemple2;
        private System.Windows.Forms.Label lblExemple3;
        private System.Windows.Forms.Button btnExemple3;
    }
}

