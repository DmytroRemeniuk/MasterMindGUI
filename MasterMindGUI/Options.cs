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
        Menu mainMenu;
        public Options(Menu menu)
        {
            InitializeComponent();

            mainMenu = menu;
        }

        //retourner au menu
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }
    }
}
