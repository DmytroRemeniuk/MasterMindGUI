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
    public partial class Menu : Form
    {
        //lier les formes
        Rules RulesForm;
        Options OptionsForm;
        //pour passer les variables d'Options à MasterMind
        public int combLength;
        public string colours;
        public int coloursNb;
        public bool showLetters;
        public bool showNumbers;
        public int languageChoice = 0;

        public Menu()
        {
            InitializeComponent();

            OptionsForm = new Options(this);
            RulesForm = new Rules(this);
        }

        /// <summary>
        /// Quitter l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// ouvrir des règles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRules_Click(object sender, EventArgs e)
        {
            RulesForm.languageChoice = languageChoice;
            //afficher des règles
            RulesForm.Show();
            //fermer le menu
            this.Hide();
        }

        /// <summary>
        /// ouvrir des options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOptions_Click(object sender, EventArgs e)
        {
            OptionsForm.languageChoice = languageChoice;
            //afficher des options
            OptionsForm.Show();
            //fermer le menu
            this.Hide();
        }

        /// <summary>
        /// commencer le jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            MasterMind MasterMindForm = new MasterMind(this);
            
            if (languageChoice == 0)
            {
                switch (coloursNb)
                {
                    case 2:
                        colours = "RV";
                        break;
                    case 3:
                        colours = "RVB";
                        break;
                    case 4:
                        colours = "RVBJ";
                        break;
                    case 5:
                        colours = "RVBJO";
                        break;
                    case 6:
                        colours = "RVBJOC";
                        break;
                    case 7:
                        colours = "RVBJOCM";
                        break;
                }
            }
            if (languageChoice == 1)
            {
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
            }
            if (languageChoice == 2)
            {
                switch (coloursNb)
                {
                    case 2:
                        colours = "ЧЗ";
                        break;
                    case 3:
                        colours = "ЧЗС";
                        break;
                    case 4:
                        colours = "ЧЗСЖ";
                        break;
                    case 5:
                        colours = "ЧЗСЖП";
                        break;
                    case 6:
                        colours = "ЧЗСЖПГ";
                        break;
                    case 7:
                        colours = "ЧЗСЖПГР";
                        break;
                }
            }

            //associer des variables
            MasterMindForm.colours = colours;
            MasterMindForm.combLength = combLength;
            MasterMindForm.showLetters = showLetters;
            MasterMindForm.showNumbers = showNumbers;
            MasterMindForm.languageChoice = languageChoice;
            //ouvrir les formulaires du jeu
            MasterMindForm.Show();
            //fermer le menu
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //associer des variables
            //colours = OptionsForm.colours;
            combLength = OptionsForm.combLength;
            showLetters = OptionsForm.showLetters;
            showNumbers = OptionsForm.showNumbers;
            coloursNb = OptionsForm.coloursNb;
        }

        private void language_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFrench.Checked)
            {
                lblLanguage.Text = "Langue:";
                lblWelcome.Text = "Bienvenue sur MasterMind!";
                btnPlay.Text = "Jouer";
                btnOptions.Text = "Options";
                btnRules.Text = "Règles";
                btnQuit.Text = "Quitter";
                languageChoice = 0;
            }
            if (rdbEnglish.Checked)
            {
                lblLanguage.Text = "Language:";
                lblWelcome.Text = "Welcome to MasterMind!";
                btnPlay.Text = "Play";
                btnOptions.Text = "Options";
                btnRules.Text = "Rules";
                btnQuit.Text = "Quit";
                languageChoice = 1;
            }
            if (rdbUkrainian.Checked)
            {
                lblLanguage.Text = "Мова:";
                lblWelcome.Text = "Вітаємо у MasterMind!";
                btnPlay.Text = "Грати";
                btnOptions.Text = "Параметри";
                btnRules.Text = "Правила";
                btnQuit.Text = "Вийти";
                languageChoice = 2;
            }
        }
    }
}

