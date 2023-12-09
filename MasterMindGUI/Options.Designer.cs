namespace MasterMindGUI
{
    partial class Options
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.length4 = new System.Windows.Forms.RadioButton();
            this.length3 = new System.Windows.Forms.RadioButton();
            this.length2 = new System.Windows.Forms.RadioButton();
            this.length6 = new System.Windows.Forms.RadioButton();
            this.length5 = new System.Windows.Forms.RadioButton();
            this.NbColorsBox = new System.Windows.Forms.ComboBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblNbColors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(374, 402);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(109, 36);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Retour";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // length4
            // 
            this.length4.AutoSize = true;
            this.length4.Checked = true;
            this.length4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.length4.Location = new System.Drawing.Point(374, 172);
            this.length4.Name = "length4";
            this.length4.Size = new System.Drawing.Size(30, 17);
            this.length4.TabIndex = 1;
            this.length4.TabStop = true;
            this.length4.Text = "4";
            this.length4.UseVisualStyleBackColor = true;
            this.length4.CheckedChanged += new System.EventHandler(this.length_CheckedChanged);
            // 
            // length3
            // 
            this.length3.AutoSize = true;
            this.length3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.length3.Location = new System.Drawing.Point(374, 135);
            this.length3.Name = "length3";
            this.length3.Size = new System.Drawing.Size(30, 17);
            this.length3.TabIndex = 2;
            this.length3.Text = "3";
            this.length3.UseVisualStyleBackColor = true;
            this.length3.CheckedChanged += new System.EventHandler(this.length_CheckedChanged);
            // 
            // length2
            // 
            this.length2.AutoSize = true;
            this.length2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.length2.Location = new System.Drawing.Point(374, 102);
            this.length2.Name = "length2";
            this.length2.Size = new System.Drawing.Size(30, 17);
            this.length2.TabIndex = 3;
            this.length2.Text = "2";
            this.length2.UseVisualStyleBackColor = true;
            this.length2.CheckedChanged += new System.EventHandler(this.length_CheckedChanged);
            // 
            // length6
            // 
            this.length6.AutoSize = true;
            this.length6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.length6.Location = new System.Drawing.Point(374, 242);
            this.length6.Name = "length6";
            this.length6.Size = new System.Drawing.Size(30, 17);
            this.length6.TabIndex = 4;
            this.length6.Text = "6";
            this.length6.UseVisualStyleBackColor = true;
            this.length6.CheckedChanged += new System.EventHandler(this.length_CheckedChanged);
            // 
            // length5
            // 
            this.length5.AutoSize = true;
            this.length5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.length5.Location = new System.Drawing.Point(374, 208);
            this.length5.Name = "length5";
            this.length5.Size = new System.Drawing.Size(30, 17);
            this.length5.TabIndex = 5;
            this.length5.Text = "5";
            this.length5.UseVisualStyleBackColor = true;
            this.length5.CheckedChanged += new System.EventHandler(this.length_CheckedChanged);
            // 
            // NbColorsBox
            // 
            this.NbColorsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NbColorsBox.FormattingEnabled = true;
            this.NbColorsBox.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.NbColorsBox.Location = new System.Drawing.Point(58, 102);
            this.NbColorsBox.Name = "NbColorsBox";
            this.NbColorsBox.Size = new System.Drawing.Size(121, 21);
            this.NbColorsBox.TabIndex = 6;
            this.NbColorsBox.Text = "7";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(326, 72);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(140, 13);
            this.lblLength.TabIndex = 7;
            this.lblLength.Text = "Longueur de la combinaison";
            // 
            // lblNbColors
            // 
            this.lblNbColors.AutoSize = true;
            this.lblNbColors.Location = new System.Drawing.Point(66, 72);
            this.lblNbColors.Name = "lblNbColors";
            this.lblNbColors.Size = new System.Drawing.Size(102, 13);
            this.lblNbColors.TabIndex = 8;
            this.lblNbColors.Text = "Nombre de couleurs";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.lblNbColors);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.NbColorsBox);
            this.Controls.Add(this.length5);
            this.Controls.Add(this.length6);
            this.Controls.Add(this.length2);
            this.Controls.Add(this.length3);
            this.Controls.Add(this.length4);
            this.Controls.Add(this.btnReturn);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.RadioButton length4;
        private System.Windows.Forms.RadioButton length3;
        private System.Windows.Forms.RadioButton length2;
        private System.Windows.Forms.RadioButton length6;
        private System.Windows.Forms.RadioButton length5;
        private System.Windows.Forms.ComboBox NbColorsBox;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblNbColors;
    }
}