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
    public partial class Options : Form
    {
        public int combLength = 4;
        int coloursNb;
        public string colours = "RGBYOCM";
        public bool showLetters = false;

        Menu mainMenu;
        public Options(Menu menu)
        {
            InitializeComponent();

            mainMenu = menu;
        }

        /// <summary>
        /// pour retourner au menu et donner des variable au jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if(NbColorsBox.Text == "2" || NbColorsBox.Text == "3" || NbColorsBox.Text == "4" || NbColorsBox.Text == "5" || NbColorsBox.Text == "6" || NbColorsBox.Text == "7")
            {
                coloursNb = Convert.ToInt32(NbColorsBox.Text);
                switch (coloursNb)
                {
                    case 2:
                        colours = "RG";
                        break;
                    case 3:
                        colours = "RGB";
                        break;
                    case 4:
                        colours = "RGBY";
                        break;
                    case 5:
                        colours = "RGBYO";
                        break;
                    case 6:
                        colours = "RGBYOC";
                        break;
                    case 7:
                        colours = "RGBYOCM";
                        break;
                }
                //associer des variables
                mainMenu.colours = colours;
                mainMenu.combLength = combLength;
                mainMenu.showLetters = showLetters;

                //retourner au menu
                this.Hide();
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("Veuillez choisir la valeur existante dans la liste");
            }
        }

        /// <summary>
        /// pour récuperer la valeur des radiobuttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void length_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;

            combLength = Convert.ToInt32(radio.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                showLetters = true;
            }
            else
            {
                showLetters = false;
            }
        }
    }
}
