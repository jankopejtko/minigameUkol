namespace Minigames_4ITB_2324
{
    partial class Sinusoid
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            hScrollBar1 = new HScrollBar();
            vScrollBar1 = new VScrollBar();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(0, 446);
            hScrollBar1.Maximum = 50;
            hScrollBar1.Minimum = 5;
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(543, 17);
            hScrollBar1.TabIndex = 0;
            hScrollBar1.Value = 5;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(543, 0);
            vScrollBar1.Minimum = 10;
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 463);
            vScrollBar1.TabIndex = 1;
            vScrollBar1.Value = 10;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(3, 466);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(554, 12);
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
            // 
            // Sinusoid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(progressBar1);
            Controls.Add(vScrollBar1);
            Controls.Add(hScrollBar1);
            DoubleBuffered = true;
            Name = "Sinusoid";
            Size = new Size(560, 480);
            Load += Sinusoid_Load;
            ResumeLayout(false);
        }

        #endregion

        private HScrollBar hScrollBar1;
        private VScrollBar vScrollBar1;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
    }
}
