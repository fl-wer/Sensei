namespace Sensei
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.perQueueLabel = new System.Windows.Forms.Label();
            this.perQueueNumeric = new System.Windows.Forms.NumericUpDown();
            this.processNameLabel = new System.Windows.Forms.Label();
            this.processNameTextBox = new System.Windows.Forms.TextBox();
            this.liner_zp0nyc = new System.Windows.Forms.Label();
            this.liner_kH38Cd = new System.Windows.Forms.Label();
            this.loadQueueToggle1 = new System.Windows.Forms.Button();
            this.loadQueueToggle2 = new System.Windows.Forms.Button();
            this.loadQueueToggle3 = new System.Windows.Forms.Button();
            this.loadQueueToggle4 = new System.Windows.Forms.Button();
            this.loadQueueToggle5 = new System.Windows.Forms.Button();
            this.loadQueueToggle6 = new System.Windows.Forms.Button();
            this.loadQueueToggle7 = new System.Windows.Forms.Button();
            this.loadQueueToggle8 = new System.Windows.Forms.Button();
            this.calculateQueues = new System.Windows.Forms.Button();
            this.quickSupport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killAllSessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.perQueueNumeric)).BeginInit();
            this.quickSupport.SuspendLayout();
            this.SuspendLayout();
            // 
            // perQueueLabel
            // 
            this.perQueueLabel.AutoSize = true;
            this.perQueueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perQueueLabel.ForeColor = System.Drawing.Color.White;
            this.perQueueLabel.Location = new System.Drawing.Point(12, 11);
            this.perQueueLabel.Name = "perQueueLabel";
            this.perQueueLabel.Size = new System.Drawing.Size(82, 21);
            this.perQueueLabel.TabIndex = 5;
            this.perQueueLabel.Text = "Per Queue";
            // 
            // perQueueNumeric
            // 
            this.perQueueNumeric.Location = new System.Drawing.Point(154, 13);
            this.perQueueNumeric.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.perQueueNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.perQueueNumeric.Name = "perQueueNumeric";
            this.perQueueNumeric.Size = new System.Drawing.Size(100, 20);
            this.perQueueNumeric.TabIndex = 4;
            this.perQueueNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // processNameLabel
            // 
            this.processNameLabel.AutoSize = true;
            this.processNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processNameLabel.ForeColor = System.Drawing.Color.White;
            this.processNameLabel.Location = new System.Drawing.Point(12, 39);
            this.processNameLabel.Name = "processNameLabel";
            this.processNameLabel.Size = new System.Drawing.Size(109, 21);
            this.processNameLabel.TabIndex = 6;
            this.processNameLabel.Text = "Process Name";
            // 
            // processNameTextBox
            // 
            this.processNameTextBox.Location = new System.Drawing.Point(154, 41);
            this.processNameTextBox.Name = "processNameTextBox";
            this.processNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.processNameTextBox.TabIndex = 7;
            // 
            // liner_zp0nyc
            // 
            this.liner_zp0nyc.BackColor = System.Drawing.Color.DimGray;
            this.liner_zp0nyc.Location = new System.Drawing.Point(17, 75);
            this.liner_zp0nyc.Name = "liner_zp0nyc";
            this.liner_zp0nyc.Size = new System.Drawing.Size(230, 2);
            this.liner_zp0nyc.TabIndex = 8;
            // 
            // liner_kH38Cd
            // 
            this.liner_kH38Cd.BackColor = System.Drawing.Color.DimGray;
            this.liner_kH38Cd.Location = new System.Drawing.Point(17, 141);
            this.liner_kH38Cd.Name = "liner_kH38Cd";
            this.liner_kH38Cd.Size = new System.Drawing.Size(230, 2);
            this.liner_kH38Cd.TabIndex = 10;
            // 
            // loadQueueToggle1
            // 
            this.loadQueueToggle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadQueueToggle1.Location = new System.Drawing.Point(12, 155);
            this.loadQueueToggle1.Name = "loadQueueToggle1";
            this.loadQueueToggle1.Size = new System.Drawing.Size(242, 41);
            this.loadQueueToggle1.TabIndex = 11;
            this.loadQueueToggle1.Text = "1";
            this.loadQueueToggle1.UseVisualStyleBackColor = true;
            this.loadQueueToggle1.Click += new System.EventHandler(this.loadQueue);
            // 
            // loadQueueToggle2
            // 
            this.loadQueueToggle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadQueueToggle2.Location = new System.Drawing.Point(12, 202);
            this.loadQueueToggle2.Name = "loadQueueToggle2";
            this.loadQueueToggle2.Size = new System.Drawing.Size(242, 41);
            this.loadQueueToggle2.TabIndex = 12;
            this.loadQueueToggle2.Text = "2";
            this.loadQueueToggle2.UseVisualStyleBackColor = true;
            this.loadQueueToggle2.Click += new System.EventHandler(this.loadQueue);
            // 
            // loadQueueToggle3
            // 
            this.loadQueueToggle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadQueueToggle3.Location = new System.Drawing.Point(12, 249);
            this.loadQueueToggle3.Name = "loadQueueToggle3";
            this.loadQueueToggle3.Size = new System.Drawing.Size(242, 41);
            this.loadQueueToggle3.TabIndex = 13;
            this.loadQueueToggle3.Text = "3";
            this.loadQueueToggle3.UseVisualStyleBackColor = true;
            this.loadQueueToggle3.Click += new System.EventHandler(this.loadQueue);
            // 
            // loadQueueToggle4
            // 
            this.loadQueueToggle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadQueueToggle4.Location = new System.Drawing.Point(12, 296);
            this.loadQueueToggle4.Name = "loadQueueToggle4";
            this.loadQueueToggle4.Size = new System.Drawing.Size(242, 41);
            this.loadQueueToggle4.TabIndex = 14;
            this.loadQueueToggle4.Text = "4";
            this.loadQueueToggle4.UseVisualStyleBackColor = true;
            this.loadQueueToggle4.Click += new System.EventHandler(this.loadQueue);
            // 
            // loadQueueToggle5
            // 
            this.loadQueueToggle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadQueueToggle5.Location = new System.Drawing.Point(12, 343);
            this.loadQueueToggle5.Name = "loadQueueToggle5";
            this.loadQueueToggle5.Size = new System.Drawing.Size(242, 41);
            this.loadQueueToggle5.TabIndex = 15;
            this.loadQueueToggle5.Text = "5";
            this.loadQueueToggle5.UseVisualStyleBackColor = true;
            this.loadQueueToggle5.Click += new System.EventHandler(this.loadQueue);
            // 
            // loadQueueToggle6
            // 
            this.loadQueueToggle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadQueueToggle6.Location = new System.Drawing.Point(12, 390);
            this.loadQueueToggle6.Name = "loadQueueToggle6";
            this.loadQueueToggle6.Size = new System.Drawing.Size(242, 41);
            this.loadQueueToggle6.TabIndex = 16;
            this.loadQueueToggle6.Text = "6";
            this.loadQueueToggle6.UseVisualStyleBackColor = true;
            this.loadQueueToggle6.Click += new System.EventHandler(this.loadQueue);
            // 
            // loadQueueToggle7
            // 
            this.loadQueueToggle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadQueueToggle7.Location = new System.Drawing.Point(12, 437);
            this.loadQueueToggle7.Name = "loadQueueToggle7";
            this.loadQueueToggle7.Size = new System.Drawing.Size(242, 41);
            this.loadQueueToggle7.TabIndex = 17;
            this.loadQueueToggle7.Text = "7";
            this.loadQueueToggle7.UseVisualStyleBackColor = true;
            this.loadQueueToggle7.Click += new System.EventHandler(this.loadQueue);
            // 
            // loadQueueToggle8
            // 
            this.loadQueueToggle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadQueueToggle8.Location = new System.Drawing.Point(12, 484);
            this.loadQueueToggle8.Name = "loadQueueToggle8";
            this.loadQueueToggle8.Size = new System.Drawing.Size(242, 41);
            this.loadQueueToggle8.TabIndex = 18;
            this.loadQueueToggle8.Text = "8";
            this.loadQueueToggle8.UseVisualStyleBackColor = true;
            this.loadQueueToggle8.Click += new System.EventHandler(this.loadQueue);
            // 
            // calculateQueues
            // 
            this.calculateQueues.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateQueues.Location = new System.Drawing.Point(12, 88);
            this.calculateQueues.Name = "calculateQueues";
            this.calculateQueues.Size = new System.Drawing.Size(242, 41);
            this.calculateQueues.TabIndex = 19;
            this.calculateQueues.Text = "Calculate Queues";
            this.calculateQueues.UseVisualStyleBackColor = true;
            this.calculateQueues.Click += new System.EventHandler(this.calculateQueues_Click);
            // 
            // quickSupport
            // 
            this.quickSupport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem,
            this.killAllSessionsToolStripMenuItem,
            this.minimizeAllToolStripMenuItem});
            this.quickSupport.Name = "quickSupport";
            this.quickSupport.Size = new System.Drawing.Size(155, 70);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Checked = true;
            this.alwaysOnTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always On Top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // killAllSessionsToolStripMenuItem
            // 
            this.killAllSessionsToolStripMenuItem.Name = "killAllSessionsToolStripMenuItem";
            this.killAllSessionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.killAllSessionsToolStripMenuItem.Text = "Kill All Sessions";
            this.killAllSessionsToolStripMenuItem.Click += new System.EventHandler(this.killAllSessionsToolStripMenuItem_Click);
            // 
            // minimizeAllToolStripMenuItem
            // 
            this.minimizeAllToolStripMenuItem.Name = "minimizeAllToolStripMenuItem";
            this.minimizeAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.minimizeAllToolStripMenuItem.Text = "Minimize All";
            this.minimizeAllToolStripMenuItem.Click += new System.EventHandler(this.minimizeAllToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(266, 139);
            this.ContextMenuStrip = this.quickSupport;
            this.Controls.Add(this.calculateQueues);
            this.Controls.Add(this.loadQueueToggle8);
            this.Controls.Add(this.loadQueueToggle7);
            this.Controls.Add(this.loadQueueToggle6);
            this.Controls.Add(this.loadQueueToggle5);
            this.Controls.Add(this.loadQueueToggle4);
            this.Controls.Add(this.loadQueueToggle3);
            this.Controls.Add(this.loadQueueToggle2);
            this.Controls.Add(this.loadQueueToggle1);
            this.Controls.Add(this.liner_kH38Cd);
            this.Controls.Add(this.liner_zp0nyc);
            this.Controls.Add(this.processNameTextBox);
            this.Controls.Add(this.processNameLabel);
            this.Controls.Add(this.perQueueLabel);
            this.Controls.Add(this.perQueueNumeric);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Sensei";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perQueueNumeric)).EndInit();
            this.quickSupport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label perQueueLabel;
        private System.Windows.Forms.NumericUpDown perQueueNumeric;
        private System.Windows.Forms.Label processNameLabel;
        private System.Windows.Forms.TextBox processNameTextBox;
        private System.Windows.Forms.Label liner_zp0nyc;
        private System.Windows.Forms.Label liner_kH38Cd;
        private System.Windows.Forms.Button loadQueueToggle1;
        private System.Windows.Forms.Button loadQueueToggle2;
        private System.Windows.Forms.Button loadQueueToggle3;
        private System.Windows.Forms.Button loadQueueToggle4;
        private System.Windows.Forms.Button loadQueueToggle5;
        private System.Windows.Forms.Button loadQueueToggle6;
        private System.Windows.Forms.Button loadQueueToggle7;
        private System.Windows.Forms.Button loadQueueToggle8;
        private System.Windows.Forms.Button calculateQueues;
        private System.Windows.Forms.ContextMenuStrip quickSupport;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killAllSessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeAllToolStripMenuItem;
    }
}

