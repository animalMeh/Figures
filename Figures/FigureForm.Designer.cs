namespace Figures
{
    partial class FigureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FigureForm));
            this.panelOptions = new System.Windows.Forms.Panel();
            this.lLanguage = new System.Windows.Forms.Label();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.panelListFigures = new System.Windows.Forms.Panel();
            this.lbFigures = new System.Windows.Forms.ListBox();
            this.panelProcess = new System.Windows.Forms.Panel();
            this.pbFigures = new System.Windows.Forms.PictureBox();
            this.timerFigures = new System.Windows.Forms.Timer(this.components);
            this.panelOptions.SuspendLayout();
            this.panelListFigures.SuspendLayout();
            this.panelProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFigures)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.Color.RosyBrown;
            this.panelOptions.Controls.Add(this.lLanguage);
            this.panelOptions.Controls.Add(this.cbLanguage);
            this.panelOptions.Controls.Add(this.buttonStop);
            this.panelOptions.Controls.Add(this.btnRectangle);
            this.panelOptions.Controls.Add(this.btnCircle);
            this.panelOptions.Controls.Add(this.btnTriangle);
            resources.ApplyResources(this.panelOptions, "panelOptions");
            this.panelOptions.Name = "panelOptions";
            // 
            // lLanguage
            // 
            resources.ApplyResources(this.lLanguage, "lLanguage");
            this.lLanguage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lLanguage.Name = "lLanguage";
            // 
            // cbLanguage
            // 
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            resources.GetString("cbLanguage.Items"),
            resources.GetString("cbLanguage.Items1")});
            resources.ApplyResources(this.cbLanguage, "cbLanguage");
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // buttonStop
            // 
            resources.ApplyResources(this.buttonStop, "buttonStop");
            this.buttonStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonStop.FlatAppearance.BorderSize = 3;
            this.buttonStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.Silver;
            this.btnRectangle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRectangle.FlatAppearance.BorderSize = 3;
            this.btnRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btnRectangle, "btnRectangle");
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.Silver;
            this.btnCircle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCircle.FlatAppearance.BorderSize = 3;
            this.btnCircle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btnCircle, "btnCircle");
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTriangle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTriangle.FlatAppearance.BorderSize = 3;
            this.btnTriangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btnTriangle, "btnTriangle");
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.UseVisualStyleBackColor = false;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // panelListFigures
            // 
            this.panelListFigures.Controls.Add(this.lbFigures);
            resources.ApplyResources(this.panelListFigures, "panelListFigures");
            this.panelListFigures.Name = "panelListFigures";
            // 
            // lbFigures
            // 
            resources.ApplyResources(this.lbFigures, "lbFigures");
            this.lbFigures.FormattingEnabled = true;
            this.lbFigures.Name = "lbFigures";
            // 
            // panelProcess
            // 
            this.panelProcess.Controls.Add(this.pbFigures);
            resources.ApplyResources(this.panelProcess, "panelProcess");
            this.panelProcess.Name = "panelProcess";
            // 
            // pbFigures
            // 
            resources.ApplyResources(this.pbFigures, "pbFigures");
            this.pbFigures.Name = "pbFigures";
            this.pbFigures.TabStop = false;
            this.pbFigures.Paint += new System.Windows.Forms.PaintEventHandler(this.pbFigures_Paint);
            // 
            // timerFigures
            // 
            this.timerFigures.Enabled = true;
            this.timerFigures.Interval = 25;
            this.timerFigures.Tick += new System.EventHandler(this.timerFigures_Tick);
            // 
            // FigureForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelProcess);
            this.Controls.Add(this.panelListFigures);
            this.Controls.Add(this.panelOptions);
            this.Name = "FigureForm";
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            this.panelListFigures.ResumeLayout(false);
            this.panelProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFigures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Panel panelListFigures;
        private System.Windows.Forms.ListBox lbFigures;
        private System.Windows.Forms.Panel panelProcess;
        private System.Windows.Forms.PictureBox pbFigures;
        private System.Windows.Forms.Timer timerFigures;
        private System.Windows.Forms.Label lLanguage;
        private System.Windows.Forms.ComboBox cbLanguage;

       
    }
}