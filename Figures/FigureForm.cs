using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figures.Model;
using System.Resources;
using System.Threading;
using System.Globalization;



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
            if (Figures.Count > 0)
            {
                foreach (var f in Figures)
                {                   
                  f.Draw(e.Graphics);
                  f.Move(pbChanged);                 
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
            Figures.Add(new Circle(pbCurrentMaxCoordinates, pen:new Pen(Color.LightSkyBlue)));
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Point pbCurrentMaxCoordinates = new Point(pbFigures.Right, pbFigures.Bottom);
            Figures.Add(new Model.Rectangle(pbCurrentMaxCoordinates, pen: new Pen(Color.Red)));

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

     
    }
}
