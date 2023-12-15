namespace MasterMindGUI
{
    partial class Rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rules));
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblRules = new System.Windows.Forms.Label();
            this.tableLayoutrules = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutrules.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReturn.Location = new System.Drawing.Point(3, 408);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(141, 41);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Retour";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblRules
            // 
            this.lblRules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRules.AutoSize = true;
            this.lblRules.BackColor = System.Drawing.Color.Transparent;
            this.lblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.ForeColor = System.Drawing.Color.White;
            this.lblRules.Location = new System.Drawing.Point(3, 103);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(795, 208);
            this.lblRules.TabIndex = 1;
            this.lblRules.Text = resources.GetString("lblRules.Text");
            this.lblRules.VisibleChanged += new System.EventHandler(this.Rules_VisibleChanged);
            // 
            // tableLayoutrules
            // 
            this.tableLayoutrules.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutrules.ColumnCount = 1;
            this.tableLayoutrules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.24406F));
            this.tableLayoutrules.Controls.Add(this.btnReturn, 0, 2);
            this.tableLayoutrules.Controls.Add(this.lblRules, 0, 1);
            this.tableLayoutrules.Location = new System.Drawing.Point(-2, -2);
            this.tableLayoutrules.Name = "tableLayoutrules";
            this.tableLayoutrules.RowCount = 3;
            this.tableLayoutrules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.893891F));
            this.tableLayoutrules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.10611F));
            this.tableLayoutrules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutrules.Size = new System.Drawing.Size(802, 452);
            this.tableLayoutrules.TabIndex = 2;
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutrules);
            this.MaximizeBox = false;
            this.Name = "Rules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterMind Règles";
            this.tableLayoutrules.ResumeLayout(false);
            this.tableLayoutrules.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.TableLayoutPanel tableLayoutrules;
    }
}