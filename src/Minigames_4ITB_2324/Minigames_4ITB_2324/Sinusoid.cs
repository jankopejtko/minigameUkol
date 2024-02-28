using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minigames_4ITB_2324
{
    public partial class Sinusoid : UserControl, IMinigame
    {
        public Sinusoid()
        {
            InitializeComponent();
        }

        public int Score { get; set; }

        public event Action<int> MinigameEnded;

        public void StartMinigame()
        {

        }
    }
}
