using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figures.Model;

namespace Figures
{
    public partial class FigureForm : Form
    {
        List<Figure> Figures = new List<Figure>();

        public FigureForm()
        {
            InitializeComponent();
            timerFigures.Start();
        }
      
        private void pictureBoxFigures_Paint(object sender, PaintEventArgs e)
        {
            if (Figures.Count != 0)
            {
                Figures[0].Move(new Point(pictureBoxFigures.Left, pictureBoxFigures.Top), new Point(pictureBoxFigures.Right, pictureBoxFigures.Bottom));
                Figures[0].Draw(e.Graphics);
            }
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {

        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            Figures.Add(new Model.Rectangle(10, 20, 10, 40 , new Pen(Color.Red)));
        }

        private void timerFigures_Tick(object sender, EventArgs e)
        {
            pictureBoxFigures.Invalidate();
        }
    }
}
