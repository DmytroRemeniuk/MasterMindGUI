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
    public partial class Results : Form
    {
        Menu mainMenu;
        MasterMind master;
        public Results(Menu menu)
        {
            InitializeComponent();
            mainMenu = menu;
        }
    }
}
