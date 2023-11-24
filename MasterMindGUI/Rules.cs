﻿using System;
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
        Menu mainMenu;
        public Rules(Menu menu)
        {
            InitializeComponent();

            mainMenu = menu;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }
    }
}