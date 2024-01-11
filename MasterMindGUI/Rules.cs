/*ETML
  Auteur      : Dmytro Remeniuk
  Date        : 11.01.2024
  Description : règles du jeu
*/
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
    public partial class Rules : Form
    {
        public int languageChoice;//pour récuperer la langue choisie

        Menu mainMenu;
        public Rules(Menu menu)
        {
            InitializeComponent();

            mainMenu = menu;
        }

        /// <summary>
        /// Retourner au menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }

        /// <summary>
        /// Changer la lnguee des règles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rules_VisibleChanged(object sender, EventArgs e)
        {
            if(languageChoice == 0)
            {
                lblRules.Text = "Règles:\n\n" +
                    "Dans ce jeu vous allez deviner la combinaison de couleurs qui a été créée par le programme. Les répétitions sont possibles. Les nombres de bonnes et mauvaises positions vont être affichés.\n\n" +
                    "Vous pouvez choisir la difficulté du jeu (qui change la longueur de la combinaison et le nombre de couleurs possibles), ainsi que le thème dans les options.";
            }
            if(languageChoice == 1)
            {
                lblRules.Text = "Rules:\n\n" +
                    "In this game you are going to guess the color combination that was created by the program. There might be repetitions. The numbers of good and bad positions will be displayed.\n\n" +
                    "You can choose the difficulty of the game (which changes the length of the combination and the number of possible colors), as well as the theme in the options.";
            }
            if(languageChoice == 2)
            {
                lblRules.Text = "Правила:\n\n" +
                    "У цій грі треба вгадати послідовність з кольорів, що була створена програмою. Повтори можливі. Ви побачите, скільки з ваших кольорів на правильних позиціях, і скільки на хибних.\n\n" +
                    "Ви можете обрати складність (що змінює довжину послідовності та кількість доступних кольорів), як і зовнішній вигляд, у параметрах.";
            }
        }
    }
}
