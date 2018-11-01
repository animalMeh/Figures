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
            this.panelOptions = new System.Windows.Forms.Panel();
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
            this.panelOptions.Controls.Add(this.buttonStop);
            this.panelOptions.Controls.Add(this.btnRectangle);
            this.panelOptions.Controls.Add(this.btnCircle);
            this.panelOptions.Controls.Add(this.btnTriangle);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOptions.Location = new System.Drawing.Point(0, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(1083, 116);
            this.panelOptions.TabIndex = 0;
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonStop.FlatAppearance.BorderSize = 3;
            this.buttonStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonStop.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(962, 12);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(109, 96);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.Silver;
            this.btnRectangle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRectangle.FlatAppearance.BorderSize = 3;
            this.btnRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRectangle.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRectangle.Location = new System.Drawing.Point(287, 12);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(102, 96);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.Silver;
            this.btnCircle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCircle.FlatAppearance.BorderSize = 3;
            this.btnCircle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCircle.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCircle.Location = new System.Drawing.Point(151, 12);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(103, 96);
            this.btnCircle.TabIndex = 1;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTriangle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTriangle.FlatAppearance.BorderSize = 3;
            this.btnTriangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTriangle.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTriangle.Location = new System.Drawing.Point(13, 12);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(106, 96);
            this.btnTriangle.TabIndex = 0;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = false;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // panelListFigures
            // 
            this.panelListFigures.Controls.Add(this.lbFigures);
            this.panelListFigures.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelListFigures.Location = new System.Drawing.Point(0, 116);
            this.panelListFigures.Name = "panelListFigures";
            this.panelListFigures.Size = new System.Drawing.Size(207, 428);
            this.panelListFigures.TabIndex = 1;
            // 
            // lbFigures
            // 
            this.lbFigures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFigures.FormattingEnabled = true;
            this.lbFigures.ItemHeight = 20;
            this.lbFigures.Location = new System.Drawing.Point(0, 0);
            this.lbFigures.Name = "lbFigures";
            this.lbFigures.Size = new System.Drawing.Size(207, 428);
            this.lbFigures.TabIndex = 0;
            // 
            // panelProcess
            // 
            this.panelProcess.Controls.Add(this.pbFigures);
            this.panelProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProcess.Location = new System.Drawing.Point(207, 116);
            this.panelProcess.Name = "panelProcess";
            this.panelProcess.Size = new System.Drawing.Size(876, 428);
            this.panelProcess.TabIndex = 2;
            // 
            // pbFigures
            // 
            this.pbFigures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFigures.Location = new System.Drawing.Point(0, 0);
            this.pbFigures.Name = "pbFigures";
            this.pbFigures.Size = new System.Drawing.Size(876, 428);
            this.pbFigures.TabIndex = 0;
            this.pbFigures.TabStop = false;
            this.pbFigures.Paint += new System.Windows.Forms.PaintEventHandler(this.pbFigures_Paint);
            // 
            // timerFigures
            // 
            this.timerFigures.Interval = 25;
            this.timerFigures.Tick += new System.EventHandler(this.timerFigures_Tick);
            // 
            // FigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 544);
            this.Controls.Add(this.panelProcess);
            this.Controls.Add(this.panelListFigures);
            this.Controls.Add(this.panelOptions);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "FigureForm";
            this.Text = "FigureForm";
            this.panelOptions.ResumeLayout(false);
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
    }
}