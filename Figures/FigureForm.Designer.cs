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
            this.panelListFigures = new System.Windows.Forms.Panel();
            this.panelProcess = new System.Windows.Forms.Panel();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.listBoxFigures = new System.Windows.Forms.ListBox();
            this.pictureBoxFigures = new System.Windows.Forms.PictureBox();
            this.timerFigures = new System.Windows.Forms.Timer(this.components);
            this.panelOptions.SuspendLayout();
            this.panelListFigures.SuspendLayout();
            this.panelProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFigures)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.buttonStop);
            this.panelOptions.Controls.Add(this.buttonRectangle);
            this.panelOptions.Controls.Add(this.buttonCircle);
            this.panelOptions.Controls.Add(this.buttonTriangle);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOptions.Location = new System.Drawing.Point(0, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(1083, 116);
            this.panelOptions.TabIndex = 0;
            // 
            // panelListFigures
            // 
            this.panelListFigures.Controls.Add(this.listBoxFigures);
            this.panelListFigures.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelListFigures.Location = new System.Drawing.Point(0, 116);
            this.panelListFigures.Name = "panelListFigures";
            this.panelListFigures.Size = new System.Drawing.Size(207, 367);
            this.panelListFigures.TabIndex = 1;
            // 
            // panelProcess
            // 
            this.panelProcess.Controls.Add(this.pictureBoxFigures);
            this.panelProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProcess.Location = new System.Drawing.Point(207, 116);
            this.panelProcess.Name = "panelProcess";
            this.panelProcess.Size = new System.Drawing.Size(876, 367);
            this.panelProcess.TabIndex = 2;
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.BackColor = System.Drawing.Color.Silver;
            this.buttonTriangle.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTriangle.Location = new System.Drawing.Point(13, 12);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(106, 96);
            this.buttonTriangle.TabIndex = 0;
            this.buttonTriangle.Text = "Triangle";
            this.buttonTriangle.UseVisualStyleBackColor = false;
            // 
            // buttonCircle
            // 
            this.buttonCircle.BackColor = System.Drawing.Color.Silver;
            this.buttonCircle.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCircle.Location = new System.Drawing.Point(151, 12);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(103, 96);
            this.buttonCircle.TabIndex = 1;
            this.buttonCircle.Text = "Circle";
            this.buttonCircle.UseVisualStyleBackColor = false;
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.BackColor = System.Drawing.Color.Silver;
            this.buttonRectangle.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRectangle.Location = new System.Drawing.Point(287, 12);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(102, 96);
            this.buttonRectangle.TabIndex = 2;
            this.buttonRectangle.Text = "Rectangle";
            this.buttonRectangle.UseVisualStyleBackColor = false;
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(965, 12);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(103, 96);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // listBoxFigures
            // 
            this.listBoxFigures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFigures.FormattingEnabled = true;
            this.listBoxFigures.ItemHeight = 20;
            this.listBoxFigures.Location = new System.Drawing.Point(0, 0);
            this.listBoxFigures.Name = "listBoxFigures";
            this.listBoxFigures.Size = new System.Drawing.Size(207, 367);
            this.listBoxFigures.TabIndex = 0;
            // 
            // pictureBoxFigures
            // 
            this.pictureBoxFigures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFigures.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFigures.Name = "pictureBoxFigures";
            this.pictureBoxFigures.Size = new System.Drawing.Size(876, 367);
            this.pictureBoxFigures.TabIndex = 0;
            this.pictureBoxFigures.TabStop = false;
            // 
            // FigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 483);
            this.Controls.Add(this.panelProcess);
            this.Controls.Add(this.panelListFigures);
            this.Controls.Add(this.panelOptions);
            this.Name = "FigureForm";
            this.Text = "FigureForm";
            this.panelOptions.ResumeLayout(false);
            this.panelListFigures.ResumeLayout(false);
            this.panelProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFigures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Panel panelListFigures;
        private System.Windows.Forms.ListBox listBoxFigures;
        private System.Windows.Forms.Panel panelProcess;
        private System.Windows.Forms.PictureBox pictureBoxFigures;
        private System.Windows.Forms.Timer timerFigures;
    }
}