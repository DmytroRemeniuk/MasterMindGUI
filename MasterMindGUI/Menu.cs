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

        MasterMind MasterMindForm;
        Rules RulesForm;
        Options OptionsForm;
        Results ResultsForm;

        public Menu()
        {
            InitializeComponent();

            MasterMindForm = new MasterMind(this);
            OptionsForm = new Options(this);
            RulesForm = new Rules(this);
            ResultsForm = new Results(this);
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
            //ouvrir les formulaires du jeu
            MasterMindForm.Show();
            ResultsForm.Show();
            //fermer le menu
            this.Hide();
        }
    }
}
