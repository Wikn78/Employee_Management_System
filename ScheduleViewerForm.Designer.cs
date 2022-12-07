namespace EmployeeManagementSystem
{
    partial class ScheduleViewerForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.morningShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eveningShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nightShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleViewerTextbox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.morningShiftToolStripMenuItem,
            this.eveningShiftToolStripMenuItem,
            this.nightShiftToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // morningShiftToolStripMenuItem
            // 
            this.morningShiftToolStripMenuItem.Name = "morningShiftToolStripMenuItem";
            this.morningShiftToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.morningShiftToolStripMenuItem.Text = "Morning Shift";
            this.morningShiftToolStripMenuItem.Click += new System.EventHandler(this.morningShiftToolStripMenuItem_Click);
            // 
            // eveningShiftToolStripMenuItem
            // 
            this.eveningShiftToolStripMenuItem.Name = "eveningShiftToolStripMenuItem";
            this.eveningShiftToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.eveningShiftToolStripMenuItem.Text = "Evening Shift";
            this.eveningShiftToolStripMenuItem.Click += new System.EventHandler(this.eveningShiftToolStripMenuItem_Click);
            // 
            // nightShiftToolStripMenuItem
            // 
            this.nightShiftToolStripMenuItem.Name = "nightShiftToolStripMenuItem";
            this.nightShiftToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.nightShiftToolStripMenuItem.Text = "Night Shift";
            this.nightShiftToolStripMenuItem.Click += new System.EventHandler(this.nightShiftToolStripMenuItem_Click);
            // 
            // scheduleViewerTextbox
            // 
            this.scheduleViewerTextbox.Location = new System.Drawing.Point(12, 27);
            this.scheduleViewerTextbox.Name = "scheduleViewerTextbox";
            this.scheduleViewerTextbox.Size = new System.Drawing.Size(776, 411);
            this.scheduleViewerTextbox.TabIndex = 1;
            this.scheduleViewerTextbox.Text = "Please Select an Shift From Above";
            // 
            // ScheduleViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scheduleViewerTextbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ScheduleViewerForm";
            this.Text = "Schedule Viewer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem morningShiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eveningShiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nightShiftToolStripMenuItem;
        private System.Windows.Forms.RichTextBox scheduleViewerTextbox;
    }
}