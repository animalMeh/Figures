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
        BindingList<Figure> Figures = new BindingList<Figure>();

        public FigureForm()
        {
           InitializeComponent();
           lbFigures.DataSource = Figures;
          
        }

        private void pbFigures_Paint(object sender, PaintEventArgs e)
        {
            Point pbChanged = new Point(pbFigures.Right, pbFigures.Bottom);
            Figure[] CurrentFigures = (from f in Figures select f).ToArray();
            if (Figures.Count > 0)
            {
                foreach (var f in Figures)
                {                   
                  f.Move(pbChanged , CurrentFigures);                 
                  f.Draw(e.Graphics);
                }
            }            
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            Point pbCurrentMaxCoordinates = new Point(pbFigures.Right, pbFigures.Bottom);
            Figures.Add(new Triangle(pbCurrentMaxCoordinates)); //here is no pen in constructor
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Point pbCurrentMaxCoordinates = new Point(pbFigures.Right, pbFigures.Bottom);
            Figures.Add(new Circle(pbCurrentMaxCoordinates));
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Point pbCurrentMaxCoordinates = new Point(pbFigures.Right, pbFigures.Bottom);
            Figures.Add(new Model.Rectangle(pbCurrentMaxCoordinates));

        }

        private void timerFigures_Tick(object sender, EventArgs e)
        {
            pbFigures.Refresh();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(Figures.Count !=0)
            {
                if (((Figure)lbFigures.SelectedItem).IsStopped)
                    ((Figure)lbFigures.SelectedItem).IsStopped = false;
                else
                    ((Figure)lbFigures.SelectedItem).IsStopped = true;
            }
            lbFigures.DataSource = null;
            lbFigures.DataSource = Figures;
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
            foreach(var fug in Figures)
            {
                fug.ChangeCulture(c);
            }
            lbFigures.DataSource = Figures;

        }


        private void FiguresClashed(object sender , ClashEventArgs e)
        {
            Console.WriteLine(e.First + " -> " + e.Second);
        }

    
        private void bAddCollEvent_Click(object sender, EventArgs e)
        {
            if (Figures.Count != 0)
            {
                ((Figure)lbFigures.SelectedItem).FiguresClashed += FiguresClashed;
            }
        }

        private void bRemoveCollEvent_Click(object sender, EventArgs e)
        {
            if (Figures.Count != 0)
            {
                ((Figure)lbFigures.SelectedItem).FiguresClashed -= FiguresClashed;
            }
        }
    }
}
