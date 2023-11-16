using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMindGUI
{
    public partial class MasterMind : Form
    {
        public MasterMind()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evénements pour entrer des couleurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Enter the colors
        private void btnRed_Click(object sender, EventArgs e)
        {
            if (btnGuess1.ForeColor == Color.Gray)
            {
                btnGuess1.ForeColor = Color.Red;
                btnGuess1.BackColor = Color.Red;
                btnGuess1.Text = "R";
            }
            else if (btnGuess2.ForeColor == Color.Gray)
            {
                btnGuess2.ForeColor = Color.Red;
                btnGuess2.BackColor = Color.Red;
                btnGuess2.Text = "R";
            }
            else if (btnGuess3.ForeColor == Color.Gray)
            {
                btnGuess3.ForeColor = Color.Red;
                btnGuess3.BackColor = Color.Red;
                btnGuess3.Text = "R";
            }
            else if (btnGuess4.ForeColor == Color.Gray)
            {
                btnGuess4.ForeColor = Color.Red;
                btnGuess4.BackColor = Color.Red;
                btnGuess4.Text = "R";
            }
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            if (btnGuess1.ForeColor == Color.Gray)
            {
                btnGuess1.ForeColor = Color.Green;
                btnGuess1.BackColor = Color.Green;
                btnGuess1.Text = "V";
            }
            else if (btnGuess2.ForeColor == Color.Gray)
            {
                btnGuess2.ForeColor = Color.Green;
                btnGuess2.BackColor = Color.Green;
                btnGuess2.Text = "V";
            }
            else if (btnGuess3.ForeColor == Color.Gray)
            {
                btnGuess3.ForeColor = Color.Green;
                btnGuess3.BackColor = Color.Green;
                btnGuess3.Text = "V";
            }
            else if (btnGuess4.ForeColor == Color.Gray)
            {
                btnGuess4.ForeColor = Color.Green;
                btnGuess4.BackColor = Color.Green;
                btnGuess4.Text = "V";
            }
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            if (btnGuess1.ForeColor == Color.Gray)
            {
                btnGuess1.ForeColor = Color.Yellow;
                btnGuess1.BackColor = Color.Yellow;
                btnGuess1.Text = "J";
            }
            else if (btnGuess2.ForeColor == Color.Gray)
            {
                btnGuess2.ForeColor = Color.Yellow;
                btnGuess2.BackColor = Color.Yellow;
                btnGuess2.Text = "J";
            }
            else if (btnGuess3.ForeColor == Color.Gray)
            {
                btnGuess3.ForeColor = Color.Yellow;
                btnGuess3.BackColor = Color.Yellow;
                btnGuess3.Text = "J";
            }
            else if (btnGuess4.ForeColor == Color.Gray)
            {
                btnGuess4.ForeColor = Color.Yellow;
                btnGuess4.BackColor = Color.Yellow;
                btnGuess4.Text = "J";
            }
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            if (btnGuess1.ForeColor == Color.Gray)
            {
                btnGuess1.ForeColor = Color.Blue;
                btnGuess1.BackColor = Color.Blue;
                btnGuess1.Text = "B";
            }
            else if (btnGuess2.ForeColor == Color.Gray)
            {
                btnGuess2.ForeColor = Color.Blue;
                btnGuess2.BackColor = Color.Blue;
                btnGuess2.Text = "B";
            }
            else if (btnGuess3.ForeColor == Color.Gray)
            {
                btnGuess3.ForeColor = Color.Blue;
                btnGuess3.BackColor = Color.Blue;
                btnGuess3.Text = "B";
            }
            else if (btnGuess4.ForeColor == Color.Gray)
            {
                btnGuess4.ForeColor = Color.Blue;
                btnGuess4.BackColor = Color.Blue;
                btnGuess4.Text = "B";
            }
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            if (btnGuess1.ForeColor == Color.Gray)
            {
                btnGuess1.ForeColor = Color.Orange;
                btnGuess1.BackColor = Color.Orange;
                btnGuess1.Text = "O";
            }
            else if (btnGuess2.ForeColor == Color.Gray)
            {
                btnGuess2.ForeColor = Color.Orange;
                btnGuess2.BackColor = Color.Orange;
                btnGuess2.Text = "O";
            }
            else if (btnGuess3.ForeColor == Color.Gray)
            {
                btnGuess3.ForeColor = Color.Orange;
                btnGuess3.BackColor = Color.Orange;
                btnGuess3.Text = "O";
            }
            else if (btnGuess4.ForeColor == Color.Gray)
            {
                btnGuess4.ForeColor = Color.Orange;
                btnGuess4.BackColor = Color.Orange;
                btnGuess4.Text = "O";
            }
        }

        private void btnCyan_Click(object sender, EventArgs e)
        {
            if (btnGuess1.ForeColor == Color.Gray)
            {
                btnGuess1.ForeColor = Color.Cyan;
                btnGuess1.BackColor = Color.Cyan;
                btnGuess1.Text = "C";
            }
            else if (btnGuess2.ForeColor == Color.Gray)
            {
                btnGuess2.ForeColor = Color.Cyan;
                btnGuess2.BackColor = Color.Cyan;
                btnGuess2.Text = "C";
            }
            else if (btnGuess3.ForeColor == Color.Gray)
            {
                btnGuess3.ForeColor = Color.Cyan;
                btnGuess3.BackColor = Color.Cyan;
                btnGuess3.Text = "C";
            }
            else if (btnGuess4.ForeColor == Color.Gray)
            {
                btnGuess4.ForeColor = Color.Cyan;
                btnGuess4.BackColor = Color.Cyan;
                btnGuess4.Text = "C";
            }
        }

        private void btnMagenta_Click(object sender, EventArgs e)
        {
            if (btnGuess1.ForeColor == Color.Gray)
            {
                btnGuess1.ForeColor = Color.Magenta;
                btnGuess1.BackColor = Color.Magenta;
                btnGuess1.Text = "M";
            }
            else if (btnGuess2.ForeColor == Color.Gray)
            {
                btnGuess2.ForeColor = Color.Magenta;
                btnGuess2.BackColor = Color.Magenta;
                btnGuess2.Text = "M";
            }
            else if (btnGuess3.ForeColor == Color.Gray)
            {
                btnGuess3.ForeColor = Color.Magenta;
                btnGuess3.BackColor = Color.Magenta;
                btnGuess3.Text = "M";
            }
            else if (btnGuess4.ForeColor == Color.Gray)
            {
                btnGuess4.ForeColor = Color.Magenta;
                btnGuess4.BackColor = Color.Magenta;
                btnGuess4.Text = "M";
            }
        }
        #endregion

        /// <summary>
        /// Un événement pour effacer les couleurs entrées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnErase_Click(object sender, EventArgs e)
        {
            btnGuess1.BackColor = Color.Gray;
            btnGuess1.ForeColor = Color.Gray;
            btnGuess1.Text = "";

            btnGuess2.BackColor = Color.Gray;
            btnGuess2.ForeColor = Color.Gray;
            btnGuess2.Text = "";

            btnGuess3.BackColor = Color.Gray;
            btnGuess3.ForeColor = Color.Gray;
            btnGuess3.Text = "";

            btnGuess4.BackColor = Color.Gray;
            btnGuess4.ForeColor = Color.Gray;
            btnGuess4.Text = "";
        }
    }
}
