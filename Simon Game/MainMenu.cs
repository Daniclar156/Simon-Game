﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon_Game
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)//exit button
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)//play button
        {
            //switch screens
            GameScreen GS = new GameScreen();
            Form f = this.FindForm();
            f.Controls.Add(GS);
            f.Controls.Add(this);
        }
    }
}
