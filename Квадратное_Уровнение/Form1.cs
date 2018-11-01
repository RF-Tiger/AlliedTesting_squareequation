using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Квадратное_Уровнение
{
    public partial class Form1 : Form
    {
        int PanelWidth;
        bool isCollapsed;

        public Form1()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            UC_About uch = new UC_About();
            AddControlsToPanel(uch);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();

                }
            }

            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 46.5)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);


        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnAbout);
            UC_About uch = new UC_About();
            AddControlsToPanel(uch);


        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSquare);
            UC_Square qcs = new UC_Square();
            AddControlsToPanel(qcs);

        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnOther);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");


        }
    }
}
