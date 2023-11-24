﻿namespace MasterMindGUI
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
            this.btnGuess1 = new System.Windows.Forms.Button();
            this.btnGuess2 = new System.Windows.Forms.Button();
            this.btnGuess3 = new System.Windows.Forms.Button();
            this.btnGuess4 = new System.Windows.Forms.Button();
            this.btnReturnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRed.Location = new System.Drawing.Point(189, 232);
            this.btnRed.Margin = new System.Windows.Forms.Padding(0);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(38, 38);
            this.btnRed.TabIndex = 2;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.Location = new System.Drawing.Point(259, 232);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(38, 38);
            this.btnGreen.TabIndex = 7;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.Location = new System.Drawing.Point(329, 232);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(38, 38);
            this.btnYellow.TabIndex = 12;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.Location = new System.Drawing.Point(399, 232);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(38, 38);
            this.btnBlue.TabIndex = 13;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrange.Location = new System.Drawing.Point(469, 232);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(38, 38);
            this.btnOrange.TabIndex = 14;
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            // 
            // btnMagenta
            // 
            this.btnMagenta.BackColor = System.Drawing.Color.Magenta;
            this.btnMagenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnMagenta.Location = new System.Drawing.Point(609, 232);
            this.btnMagenta.Name = "btnMagenta";
            this.btnMagenta.Size = new System.Drawing.Size(38, 38);
            this.btnMagenta.TabIndex = 15;
            this.btnMagenta.UseVisualStyleBackColor = false;
            this.btnMagenta.Click += new System.EventHandler(this.btnMagenta_Click);
            // 
            // btnCyan
            // 
            this.btnCyan.BackColor = System.Drawing.Color.Cyan;
            this.btnCyan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCyan.Location = new System.Drawing.Point(539, 232);
            this.btnCyan.Name = "btnCyan";
            this.btnCyan.Size = new System.Drawing.Size(38, 38);
            this.btnCyan.TabIndex = 16;
            this.btnCyan.UseVisualStyleBackColor = false;
            this.btnCyan.Click += new System.EventHandler(this.btnCyan_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(189, 361);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(106, 41);
            this.btnValidate.TabIndex = 17;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = true;
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(541, 361);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(106, 41);
            this.btnErase.TabIndex = 18;
            this.btnErase.Text = "Effacer";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnGuess1
            // 
            this.btnGuess1.BackColor = System.Drawing.Color.Gray;
            this.btnGuess1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuess1.ForeColor = System.Drawing.Color.Gray;
            this.btnGuess1.Location = new System.Drawing.Point(300, 69);
            this.btnGuess1.Name = "btnGuess1";
            this.btnGuess1.Size = new System.Drawing.Size(32, 32);
            this.btnGuess1.TabIndex = 19;
            this.btnGuess1.UseVisualStyleBackColor = false;
            // 
            // btnGuess2
            // 
            this.btnGuess2.BackColor = System.Drawing.Color.Gray;
            this.btnGuess2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuess2.ForeColor = System.Drawing.Color.Gray;
            this.btnGuess2.Location = new System.Drawing.Point(375, 69);
            this.btnGuess2.Name = "btnGuess2";
            this.btnGuess2.Size = new System.Drawing.Size(32, 32);
            this.btnGuess2.TabIndex = 20;
            this.btnGuess2.UseVisualStyleBackColor = false;
            // 
            // btnGuess3
            // 
            this.btnGuess3.BackColor = System.Drawing.Color.Gray;
            this.btnGuess3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuess3.ForeColor = System.Drawing.Color.Gray;
            this.btnGuess3.Location = new System.Drawing.Point(450, 69);
            this.btnGuess3.Name = "btnGuess3";
            this.btnGuess3.Size = new System.Drawing.Size(32, 32);
            this.btnGuess3.TabIndex = 21;
            this.btnGuess3.UseVisualStyleBackColor = false;
            // 
            // btnGuess4
            // 
            this.btnGuess4.BackColor = System.Drawing.Color.Gray;
            this.btnGuess4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuess4.ForeColor = System.Drawing.Color.Gray;
            this.btnGuess4.Location = new System.Drawing.Point(525, 69);
            this.btnGuess4.Name = "btnGuess4";
            this.btnGuess4.Size = new System.Drawing.Size(32, 32);
            this.btnGuess4.TabIndex = 22;
            this.btnGuess4.UseVisualStyleBackColor = false;
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.Location = new System.Drawing.Point(737, 397);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(106, 41);
            this.btnReturnMenu.TabIndex = 23;
            this.btnReturnMenu.Text = "Retour au menu";
            this.btnReturnMenu.UseVisualStyleBackColor = true;
            this.btnReturnMenu.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // MasterMind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.btnReturnMenu);
            this.Controls.Add(this.btnGuess4);
            this.Controls.Add(this.btnGuess3);
            this.Controls.Add(this.btnGuess2);
            this.Controls.Add(this.btnGuess1);
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
            this.Text = "MasterMind";
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnGuess1;
        private System.Windows.Forms.Button btnGuess2;
        private System.Windows.Forms.Button btnGuess3;
        private System.Windows.Forms.Button btnGuess4;
        private System.Windows.Forms.Button btnReturnMenu;
    }
}
