using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using Figures.Model;
using System.Threading;
using System.Windows.Forms;

namespace Figures
{
    public partial class FigureForm : Form
    {
        private BindingList<Figure> figures = new BindingList<Figure>();
        public FigureForm()
        {
           InitializeComponent();
           lbFigures.DataSource = figures;     
        }

        private void pbFigures_Paint(object sender, PaintEventArgs e)
        {
            Point pbChanged = new Point(pbFigures.Right, pbFigures.Bottom);
            Figure[] currentFigures = (from f in figures select f).ToArray();
            if (figures.Count > 0)
            {
                foreach (var f in figures)
                {                   
                  f.Move(pbChanged , currentFigures);                 
                  f.Draw(e.Graphics);
                }
            }
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            Point pbCurrentMaxCoordinates = new Point(pbFigures.Right, pbFigures.Bottom);
            figures.Add(new Triangle(pbCurrentMaxCoordinates));
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Point pbCurrentMaxCoordinates = new Point(pbFigures.Right, pbFigures.Bottom);
            figures.Add(new Circle(pbCurrentMaxCoordinates));
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Point pbCurrentMaxCoordinates = new Point(pbFigures.Right, pbFigures.Bottom);
            figures.Add(new Model.Rectangle(pbCurrentMaxCoordinates));
        }

        private void timerFigures_Tick(object sender, EventArgs e)
        {
            pbFigures.Refresh();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(figures.Count!=0)
            {
                if (((Figure)lbFigures.SelectedItem).IsStopped)
                {
                    ((Figure)lbFigures.SelectedItem).IsStopped = false;
                }
                else
                {
                    ((Figure)lbFigures.SelectedItem).IsStopped = true;
                }
            }
            lbFigures.DataSource = null;
            lbFigures.DataSource = figures;
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLanguage.Text == "RU")
            {
                ChangeLanguage("ru");
            }

            if(cbLanguage.Text == "EN")
            {
                ChangeLanguage("en");
            }
        }

        private void ChangeLanguage(string lang)
        {
            CultureInfo c = new CultureInfo(lang);
            Thread.CurrentThread.CurrentCulture = c;
            Thread.CurrentThread.CurrentUICulture = c;
            Controls.Clear();
            timerFigures.Stop();
            InitializeComponent();
            foreach(var fug in figures)
            {
                fug.ChangeCulture(c);
            }
            lbFigures.DataSource = figures;
        }

        private void FiguresClashed(object sender , ClashEventArgs e)
        {
            Console.WriteLine(e.First + " -> " + e.Second);
        }
    
        private void bAddCollEvent_Click(object sender, EventArgs e)
        {
            if (figures.Count != 0)
            {
                ((Figure)lbFigures.SelectedItem).FiguresClashed += FiguresClashed;
            }
        }

        private void bRemoveCollEvent_Click(object sender, EventArgs e)
        {
            if (figures.Count != 0)
            {
                ((Figure)lbFigures.SelectedItem).FiguresClashed -= FiguresClashed;
            }
        }
    }
}
