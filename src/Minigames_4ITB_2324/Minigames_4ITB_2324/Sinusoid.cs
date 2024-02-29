using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minigames_4ITB_2324
{
    public partial class Sinusoid : UserControl, IMinigame
    {
        Pen pen = new Pen(Color.Blue);
        private float amplitude = 10; //->min 10 max 100
        private float frequency = 0.5f; //-> min 0.5 max 0.05
        private float amplitude_enemy = 50;
        private float frequency_enemy = 0.03f;
        private int timerDefValue = 1000;
        private int timer;
        public Sinusoid()
        {
            InitializeComponent();
        }

        public int Score { get; set; }
        Random rn = new Random();
        public event Action<int> MinigameEnded;

        public void StartMinigame()
        {
            this.Paint += OnPaint;
        }
        private void OnPaint(object? sender, PaintEventArgs e)
        {
            Draw(e.Graphics, Color.Blue, amplitude, frequency);
            Draw(e.Graphics, Color.Gray, amplitude_enemy, frequency_enemy);
        }
        private void Sinusoid_Load(object sender, EventArgs e)
        {
            generateEnemy();
            progressBar1.Value = 100;
            timer = timerDefValue;
        }
        private void generateEnemy()
        {
            amplitude_enemy = rn.Next(10, 95);
            frequency_enemy = (float)rn.Next(10, 40) / 100;
            //MessageBox.Show("game stats: amplitude: " + amplitude + " frequency: " + frequency + " amplitude_enemy: " + amplitude_enemy + " frequency_enemy: " + frequency_enemy);
        }
        public void Draw(Graphics g, Color color, float amplitude, float frequency)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias; // Enable anti-aliasing
            Pen pen = new Pen(color);
            int offsetX = 0;
            int offsetY = this.ClientSize.Height / 2;

            g.DrawLine(Pens.Black, 0, offsetY, this.ClientSize.Width, offsetY);
            g.DrawLine(Pens.Black, offsetX, 0, offsetX, this.ClientSize.Height);
            PointF[] points = new PointF[this.ClientSize.Width - offsetX];
            for (int x = 0; x < this.ClientSize.Width - offsetX; x++)
            {
                float y = (float)(Math.Sin((x - offsetX) * frequency) * amplitude) + offsetY;
                points[x] = new PointF(x, y);
            }
            g.DrawCurve(pen, points);
        }

        private void chackWin()
        {
            float tolerance = 0.01f; // 1%

            if (Math.Abs(frequency - frequency_enemy) / frequency <= tolerance && Math.Abs(amplitude - amplitude_enemy) / amplitude <= tolerance)
            {
                Score++;
                generateEnemy();
                progressBar1.Value = 100;
                timer = timerDefValue;
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            frequency = (float)hScrollBar1.Value / 100;
            chackWin();
            Refresh();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            amplitude = vScrollBar1.Value;
            chackWin();
            Refresh();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timer > 0)
            {
                timer--;
                progressBar1.Value = timer / 10;
            }
            if (timer <= 0)
            {
                MinigameEnded?.Invoke(Score);
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
