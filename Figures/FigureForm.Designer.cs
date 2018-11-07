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
            this.bRemoveCollEvent = new System.Windows.Forms.Button();
            this.bAddCollEvent = new System.Windows.Forms.Button();
            this.lLanguage = new System.Windows.Forms.Label();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelListFigures = new System.Windows.Forms.Panel();
            this.lbFigures = new System.Windows.Forms.ListBox();
            this.panelProcess = new System.Windows.Forms.Panel();
            this.pbFigures = new System.Windows.Forms.PictureBox();
            this.timerFigures = new System.Windows.Forms.Timer(this.components);
            this.openSerializedFile = new System.Windows.Forms.OpenFileDialog();
            this.panelOptions.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelListFigures.SuspendLayout();
            this.panelProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFigures)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.Color.RosyBrown;
            this.panelOptions.Controls.Add(this.bRemoveCollEvent);
            this.panelOptions.Controls.Add(this.bAddCollEvent);
            this.panelOptions.Controls.Add(this.lLanguage);
            this.panelOptions.Controls.Add(this.cbLanguage);
            this.panelOptions.Controls.Add(this.buttonStop);
            this.panelOptions.Controls.Add(this.btnRectangle);
            this.panelOptions.Controls.Add(this.btnCircle);
            this.panelOptions.Controls.Add(this.btnTriangle);
            this.panelOptions.Controls.Add(this.menuStrip1);
            resources.ApplyResources(this.panelOptions, "panelOptions");
            this.panelOptions.Name = "panelOptions";
            // 
            // bRemoveCollEvent
            // 
            this.bRemoveCollEvent.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.bRemoveCollEvent.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(this.bRemoveCollEvent, "bRemoveCollEvent");
            this.bRemoveCollEvent.Name = "bRemoveCollEvent";
            this.bRemoveCollEvent.UseVisualStyleBackColor = true;
            this.bRemoveCollEvent.Click += new System.EventHandler(this.bRemoveCollEvent_Click);
            // 
            // bAddCollEvent
            // 
            resources.ApplyResources(this.bAddCollEvent, "bAddCollEvent");
            this.bAddCollEvent.Name = "bAddCollEvent";
            this.bAddCollEvent.UseVisualStyleBackColor = true;
            this.bAddCollEvent.Click += new System.EventHandler(this.bAddCollEvent_Click);
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
            this.buttonStop.BackColor = System.Drawing.Color.DarkGray;
            this.buttonStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonStop.FlatAppearance.BorderSize = 3;
            this.buttonStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.DarkGray;
            this.btnRectangle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRectangle.FlatAppearance.BorderSize = 3;
            this.btnRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btnRectangle, "btnRectangle");
            this.btnRectangle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.DarkGray;
            this.btnCircle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCircle.FlatAppearance.BorderSize = 3;
            this.btnCircle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btnCircle, "btnCircle");
            this.btnCircle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.BackColor = System.Drawing.Color.DarkGray;
            this.btnTriangle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTriangle.FlatAppearance.BorderSize = 3;
            this.btnTriangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btnTriangle, "btnTriangle");
            this.btnTriangle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.UseVisualStyleBackColor = false;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.openToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.kSONToolStripMenuItem,
            this.bINToolStripMenuItem});
            this.fileToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            resources.ApplyResources(this.fileToolStripMenuItem1, "fileToolStripMenuItem1");
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            resources.ApplyResources(this.xMLToolStripMenuItem, "xMLToolStripMenuItem");
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // kSONToolStripMenuItem
            // 
            this.kSONToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.kSONToolStripMenuItem.Name = "kSONToolStripMenuItem";
            resources.ApplyResources(this.kSONToolStripMenuItem, "kSONToolStripMenuItem");
            // 
            // bINToolStripMenuItem
            // 
            this.bINToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.bINToolStripMenuItem.Name = "bINToolStripMenuItem";
            resources.ApplyResources(this.bINToolStripMenuItem, "bINToolStripMenuItem");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FigureForm";
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button bRemoveCollEvent;
        private System.Windows.Forms.Button bAddCollEvent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openSerializedFile;
    }
}