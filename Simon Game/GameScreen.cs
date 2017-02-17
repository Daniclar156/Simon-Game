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
using System.Media;

namespace Simon_Game
{
    public partial class GameScreen : UserControl
    {

        //global variables
        int guess = 0;
        SoundPlayer greenBoop = new SoundPlayer(Properties.Resources.green);//soundplayers
        SoundPlayer redBoop = new SoundPlayer(Properties.Resources.red);
        SoundPlayer yellowBoop = new SoundPlayer(Properties.Resources.yellow);
        SoundPlayer blueBoop = new SoundPlayer(Properties.Resources.blue);
        SoundPlayer failSound = new SoundPlayer(Properties.Resources.mistake);

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
                    greenBoop.Play();
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
                    redBoop.Play();
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
                    yellowBoop.Play();
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
                    blueBoop.Play();
                    blueButton.BackColor = Color.White;
                    Refresh();
                    Thread.Sleep(1000);
                    blueButton.BackColor = Color.Blue;
                }
            }

            guess = 0;
        }

        //player turn 
        private void greenButton_Click(object sender, EventArgs e)
        {
            greenBoop.Play();
            if (Form1.pattern[guess] == 1)
            {
                greenButton.BackColor = Color.White;
                Refresh();
                Thread.Sleep(500);
                greenButton.BackColor = Color.Green;
                Refresh();
                guess++;
                if (Form1.pattern.Count == guess)
                {
                    ComputerTurn();
                }
            }
            else
            {
                failSound.Play();
                GameOverScreen gos = new GameOverScreen();
                Form f = this.FindForm();
                f.Controls.Remove(this);
                f.Controls.Add(gos);
            }
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            redBoop.Play();
            if (Form1.pattern[guess] == 2)
            {
                redButton.BackColor = Color.White;
                Refresh();
                Thread.Sleep(500);
                redButton.BackColor = Color.Red;
                Refresh();
                guess++;
                if (Form1.pattern.Count == guess)
                {
                    ComputerTurn();
                }

            }
            else
            {
                failSound.Play();
                Form f = this.FindForm();
                f.Controls.Remove(this);
                GameOverScreen gos = new GameOverScreen();
                f.Controls.Add(gos);
            }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            yellowBoop.Play();
            if (Form1.pattern[guess] == 3)
            {
                yellowButton.BackColor = Color.White;
                Refresh();
                Thread.Sleep(500);
                yellowButton.BackColor = Color.Yellow;
                Refresh();
                guess++;
                if (Form1.pattern.Count == guess)
                {
                    ComputerTurn();
                }
            }
            else
            {
                failSound.Play();
                GameOverScreen gos = new GameOverScreen();
                Form f = this.FindForm();
                f.Controls.Remove(this);
                f.Controls.Add(gos);
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            blueBoop.Play();
            if (Form1.pattern[guess] == 4)
            {
                blueButton.BackColor = Color.White;
                Refresh();
                Thread.Sleep(500);
                blueButton.BackColor = Color.Blue;
                Refresh();
                guess++;
                if (Form1.pattern.Count == guess)
                {
                    ComputerTurn();
                }
            }
            else
            {
                failSound.Play();
                GameOverScreen gos = new GameOverScreen();
                Form f = this.FindForm();
                f.Controls.Remove(this);
                f.Controls.Add(gos);
            }
        }

    }
}
