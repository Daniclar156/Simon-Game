using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Simon_Game
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();
            //global variables
            int guess;
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Form1.pattern.Clear();
            //Refresh();
            //Thread.Sleep(1000);
            ComputerTurn();
        }
        /// <summary>
        /// Generates a random number between 1 and 4 and adds it to the pattern list. Loops through and lights up buttons acording to pattern.
        /// </summary>
        public void ComputerTurn()
        {
            Random randNum = new Random();
            Form1.pattern.Add(randNum.Next(1, 5));
            Form1.pattern.Add(randNum.Next(1, 5));
            Form1.pattern.Add(randNum.Next(1, 5));
            Form1.pattern.Add(randNum.Next(1, 5));

            for (int i = 0; i < Form1.pattern.Count(); i++)
            {
                if (Form1.pattern[i] == 1)
                {
                    greenButton.BackColor = Color.Green;
                    Refresh();
                    Thread.Sleep(500);
                    greenButton.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(1000);
                    greenButton.BackColor = Color.Green;
                }

                if (Form1.pattern[i] == 2)
                {
                    redButton.BackColor = Color.Red;
                    Refresh();
                    Thread.Sleep(500);
                    redButton.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(1000);
                    redButton.BackColor = Color.Red;
                }

                if (Form1.pattern[i] == 3)
                {
                    yellowButton.BackColor = Color.Yellow;
                    Refresh();
                    Thread.Sleep(500);
                    yellowButton.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(1000);
                    yellowButton.BackColor = Color.Yellow;
                }

                if (Form1.pattern[i] == 4)
                {
                    blueButton.BackColor = Color.Blue;
                    Refresh();
                    Thread.Sleep(500);
                    blueButton.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(1000);
                    blueButton.BackColor = Color.Blue;
                }
            }
        }

        //for loop to go through the list with if statements being compared to the i value
    }
}
