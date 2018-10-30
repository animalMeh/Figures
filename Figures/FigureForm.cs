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
      
        }
      
        private void pictureBoxFigures_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            Figures.Add(new Triangle());
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {

        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {

        }
    }
}
