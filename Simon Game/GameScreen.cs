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

        //global variables
        int guess = 0;
        int guesses;
        int roundNumber = 1;

        public GameScreen()
        {
            InitializeComponent();
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

            PlayerTurn();
        }

        //for loop to go through the list with if statements being compared to the i value
        /// <summary>
        /// starts the players turn
        /// </summary>
        public void PlayerTurn()//use guess int to track what the player currently guessed
        {
                //FOLLOW EXAMPLE ON ONENOTE
            
        }

        //set current guess 
        private void greenButton_Click(object sender, EventArgs e)
        {
            guess = 1;
            PlayerTurn();
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            guess = 2;
            PlayerTurn();
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            guess = 3;
            PlayerTurn();
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            guess = 4;
            PlayerTurn();
        }
    }
}
