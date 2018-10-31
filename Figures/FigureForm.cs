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
        Random r = new Random();
        BindingList<Figure> Figures = new BindingList<Figure>();

        
        const int DefaultWidth = 50;
        const int DefaultHeight = 50;


        public FigureForm()
        {
            InitializeComponent();
            listBoxFigures.DataSource = Figures;
            //listBoxFigures.DisplayMember = "Name";
            timerFigures.Start();
        }
      
        private void pictureBoxFigures_Paint(object sender, PaintEventArgs e)
        {
            if (Figures.Count > 0)
            {
                foreach(var f in Figures)
                {
                    f.Move(new Point(pictureBoxFigures.Left, pictureBoxFigures.Top), new Point(pictureBoxFigures.Right, pictureBoxFigures.Bottom));
                    f.Draw(e.Graphics);
                }
            }
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            Figures.Add(new Triangle(r.Next(pictureBoxFigures.Left,pictureBoxFigures.Right - DefaultWidth), 
                r.Next(pictureBoxFigures.Top, pictureBoxFigures.Bottom - DefaultHeight), 50, new Pen(Color.Blue)));
            //listBoxFigures.DisplayMember = "Name";
            //listBoxFigures.DataSource = Figures;
            
            
            //listBoxFigures.Refresh();
            //listBoxFigures.Update();

        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            Figures.Add(new Model.Circle(r.Next(pictureBoxFigures.Left, pictureBoxFigures.Right - DefaultWidth),
                r.Next(pictureBoxFigures.Top ,pictureBoxFigures.Bottom - DefaultHeight),25,new Pen(Color.LightSkyBlue)));
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            Figures.Add(new Model.Rectangle(r.Next(pictureBoxFigures.Left, pictureBoxFigures.Right - DefaultWidth), 
                r.Next(pictureBoxFigures.Top, pictureBoxFigures.Bottom - DefaultHeight), 50, 50, new Pen(Color.Red)));

        }

        private void timerFigures_Tick(object sender, EventArgs e)
        {
            pictureBoxFigures.Invalidate();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if(Figures.Count !=0)
            {
                ((Figure)listBoxFigures.SelectedItem).Stop();
            }
        }
    }
}
