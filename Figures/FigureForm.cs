﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using Figures.Model;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Text.RegularExpressions;


namespace Figures
{
    public partial class FigureForm : Form
    {
        private BindingList<Figure> figures = new BindingList<Figure>();
        Point pbMaxCoordinate = new Point();

        public FigureForm()
        {
           InitializeComponent();
           lbFigures.DataSource = figures;     
        }

        private void pbFigures_Paint(object sender, PaintEventArgs e)
        {
            pbMaxCoordinate = new Point(pbFigures.Right, pbFigures.Bottom);//
            Figure[] currentFigures = (from f in figures select f).ToArray();
            if (figures.Count > 0)
            {
                foreach (var f in figures)
                {
                    MovingHelper.AsyncMove(f, pbMaxCoordinate, currentFigures);      
                    f.Draw(e.Graphics);
                }
            }
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            pbMaxCoordinate = new Point(pbFigures.Right, pbFigures.Bottom);
            figures.Add(new Triangle(pbMaxCoordinate));
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            pbMaxCoordinate = new Point(pbFigures.Right, pbFigures.Bottom);
            figures.Add(new Circle(pbMaxCoordinate));
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            pbMaxCoordinate = new Point(pbFigures.Right, pbFigures.Bottom);
            figures.Add(new Model.Rectangle(pbMaxCoordinate));
        }

        private void timerFigures_Tick(object sender, EventArgs e)
        {
            pbFigures.Invalidate();
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
                ((Figure)lbFigures.SelectedItem).FigureClash += FiguresClashed;
            }
        }

        private void bRemoveCollEvent_Click(object sender, EventArgs e)
        {
            if (figures.Count != 0)
            {
                ((Figure)lbFigures.SelectedItem).FigureClash -= FiguresClashed;
            }
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Figure[] fig = figures.ToArray();
            XmlSerializer formatter = new XmlSerializer(typeof(Figure[]));
            using (FileStream fs = new FileStream("figuress.xml", FileMode.Create))
            {
                formatter.Serialize(fs, fig);
                Console.WriteLine("Объект сериализован");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openSerializedFile.ShowDialog();
            string readFile = openSerializedFile.FileName;
            IsFileCanBeDeserialized(readFile, out string myFile);
            XmlSerializer formatter = new XmlSerializer(typeof(Figure[]));
            switch (myFile)
            {
                case "xml":
                    {
                        using (FileStream fs = new FileStream(readFile, FileMode.Open))
                        {
                            Figure[] newFigures = (Figure[])formatter.Deserialize(fs);
                            figures.Clear();
                            foreach(var f in newFigures)
                            {
                                figures.Add(f);
                            }
                            lbFigures.DataSource = figures;
                        }
                        break;
                    }
            }
        }

        private bool IsFileCanBeDeserialized(string fileName, out string Type)
        {
            var pattern = @"\.xml$|\.json$|\.dat$";
            if (fileName.EndsWith(".xml"))
                Type = "xml";
            else if (fileName.EndsWith(".json"))
                Type = "json";
            else if (fileName.EndsWith(".dat"))
                Type = "bin";
            else Type =  "";
            return Regex.IsMatch(fileName, pattern);
        }
    }
}
