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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleViewerForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.morningShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eveningShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nightShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.goBackButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 371);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(13, 415);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 2;
            this.goBackButton.Text = "Logout";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // ScheduleViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ScheduleViewerForm";
            this.Text = "Schedule Viewer";
            this.Load += new System.EventHandler(this.ScheduleViewerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem morningShiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eveningShiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nightShiftToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button goBackButton;
    }
}