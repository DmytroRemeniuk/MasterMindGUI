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
        //les variables à passer vers MasterMind
        public int combLength = 4;
        public int coloursNb = 7;
        public string colours = "RVBJOCM";
        public bool showLetters = true;
        public bool showNumbers = false;
        public int languageChoice;

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
                //passer la valeur à une variable
                coloursNb = Convert.ToInt32(NbColorsBox.Text);

                //changer l'affichage de resultat
                if(rdbNumbers.Checked == true)
                {
                    showNumbers = true;
                }
                else
                {
                    showNumbers = false;
                }

                //associer des variables
                mainMenu.colours = colours;
                mainMenu.combLength = combLength;
                mainMenu.showLetters = showLetters;
                mainMenu.showNumbers = showNumbers;
                mainMenu.coloursNb = coloursNb;
                //retourner au menu
                this.Hide();
                mainMenu.Show();
            }
            else
            {
                if(languageChoice == 0)
                {
                    MessageBox.Show("Veuillez choisir la valeur existante dans la liste");
                }
                if(languageChoice == 1)
                {
                    MessageBox.Show("Choose a value from the list, please");
                }
                if(languageChoice == 2)
                {
                    MessageBox.Show("Шановний, оберіть число зі списку");
                }
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
            if(ckBoxShowLetters.Checked)
            {
                showLetters = true;
            }
            else
            {
                showLetters = false;
            }
        }

        private void Options_VisibleChanged(object sender, EventArgs e)
        {
            if(languageChoice == 0)
            {
                lblNbColors.Text = "Nombre de couleurs";
                ckBoxShowLetters.Text = "Afficher les lettres";
                rdbNumbers.Text = "Afficher le resultat avec les chiffres";
                rdbPoints.Text = "Afficher le resultat avec les points";
                lblLength.Text = "Longueur de la combinaison";
                btnReturn.Text = "Retour";
            }
            if(languageChoice == 1)
            {
                lblNbColors.Text = "Number of colors";
                ckBoxShowLetters.Text = "Show letters";
                rdbNumbers.Text = "Display the result with numbers";
                rdbPoints.Text = "Display the result with points";
                lblLength.Text = "Combination length";
                btnReturn.Text = "Return";
            }
            if(languageChoice == 2)
            {
                lblNbColors.Text = "Кількість кольорів";
                ckBoxShowLetters.Text = "Показати літери";
                rdbNumbers.Text = "Відображати результат цифрами";
                rdbPoints.Text = "Відображати результат крапками";
                lblLength.Text = "Довжина послідовності";
                btnReturn.Text = "Назад";
            }
        }
    }
}
