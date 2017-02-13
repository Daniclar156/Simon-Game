using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon_Game
{
    public partial class Form1 : Form
    {
        //global variables
        public static List<int> pattern = new List<int>();
        public Form1()
        {
            InitializeComponent();
            //switch screens
            MainMenu MM = new MainMenu();
            this.Controls.Add(MM);
            this.Controls.Remove(this);
        }
    }
}
