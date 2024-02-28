using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minigames_4ITB_2324
{
    public partial class pismeno : UserControl, IMinigame
    {
        public pismeno()
        {
            InitializeComponent();
        }
        public int Score { get; set; }
        public Random random = new Random();
        char[] abeceda = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        public event Action<int> MinigameEnded;
        string curLetter;

        public void StartMinigame()
        {
            progressBar1.Value = 100;
            DoubleBuffered = true;
            Score = 0;
            getRandomPismeno();
            label1.Text = curLetter;
            timer1.Start();

        }
        private void getRandomPismeno()
        {
            char nahodnePismeno = abeceda[random.Next(abeceda.Length)];
            curLetter = nahodnePismeno.ToString();
            label1.Text = curLetter;
        }
        private void pismeno_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value - 1;
            if (progressBar1.Value <= 0)
            {
                MessageBox.Show("end game");
            }
        }

        private void pismeno_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString().ToLower() == curLetter.ToLower()) 
            {
                MessageBox.Show("jooooo");
                getRandomPismeno();
                Score++;
                progressBar1.Value = 100;
                if(timer1.Interval >= 10)
                {
                    timer1.Interval = timer1.Interval - 5;
                }
            }
            else 
            {
                timer1.Stop();
                timer1.Enabled = false;
                MinigameEnded?.Invoke(Score);
            }
        }
    }
}
