﻿namespace UI
{
    partial class Form1
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lazyLoadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eagerLoadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explicitLoadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.executeStoredProcedureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailsWoCustomMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailsWithCustomMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tPHDisplayCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stToolStripMenuItem,
            this.lazyLoadingToolStripMenuItem,
            this.eagerLoadingToolStripMenuItem,
            this.explicitLoadingToolStripMenuItem,
            this.executeStoredProcedureToolStripMenuItem,
            this.orderDetailsWoCustomMethodToolStripMenuItem,
            this.orderDetailsWithCustomMethodToolStripMenuItem,
            this.tPHDisplayCarsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(254, 202);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // stToolStripMenuItem
            // 
            this.stToolStripMenuItem.Name = "stToolStripMenuItem";
            this.stToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.stToolStripMenuItem.Text = "Populate";
            this.stToolStripMenuItem.Click += new System.EventHandler(this.stToolStripMenuItem_Click);
            // 
            // lazyLoadingToolStripMenuItem
            // 
            this.lazyLoadingToolStripMenuItem.Name = "lazyLoadingToolStripMenuItem";
            this.lazyLoadingToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.lazyLoadingToolStripMenuItem.Text = "Lazy Loading";
            this.lazyLoadingToolStripMenuItem.Click += new System.EventHandler(this.lazyLoadingToolStripMenuItem_Click);
            // 
            // eagerLoadingToolStripMenuItem
            // 
            this.eagerLoadingToolStripMenuItem.Name = "eagerLoadingToolStripMenuItem";
            this.eagerLoadingToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.eagerLoadingToolStripMenuItem.Text = "Eager Loading";
            this.eagerLoadingToolStripMenuItem.Click += new System.EventHandler(this.eagerLoadingToolStripMenuItem_Click);
            // 
            // explicitLoadingToolStripMenuItem
            // 
            this.explicitLoadingToolStripMenuItem.Name = "explicitLoadingToolStripMenuItem";
            this.explicitLoadingToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.explicitLoadingToolStripMenuItem.Text = "Explicit Loading";
            this.explicitLoadingToolStripMenuItem.Click += new System.EventHandler(this.explicitLoadingToolStripMenuItem_Click);
            // 
            // gv
            // 
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.ContextMenuStrip = this.contextMenuStrip1;
            this.gv.Location = new System.Drawing.Point(12, 12);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(551, 238);
            this.gv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // executeStoredProcedureToolStripMenuItem
            // 
            this.executeStoredProcedureToolStripMenuItem.Name = "executeStoredProcedureToolStripMenuItem";
            this.executeStoredProcedureToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.executeStoredProcedureToolStripMenuItem.Text = "Execute StoredProcedure";
            this.executeStoredProcedureToolStripMenuItem.Click += new System.EventHandler(this.executeStoredProcedureToolStripMenuItem_Click);
            // 
            // orderDetailsWoCustomMethodToolStripMenuItem
            // 
            this.orderDetailsWoCustomMethodToolStripMenuItem.Name = "orderDetailsWoCustomMethodToolStripMenuItem";
            this.orderDetailsWoCustomMethodToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.orderDetailsWoCustomMethodToolStripMenuItem.Text = "Order Details Wo Custom Method";
            this.orderDetailsWoCustomMethodToolStripMenuItem.Click += new System.EventHandler(this.orderDetailsWoCustomMethodToolStripMenuItem_Click);
            // 
            // orderDetailsWithCustomMethodToolStripMenuItem
            // 
            this.orderDetailsWithCustomMethodToolStripMenuItem.Name = "orderDetailsWithCustomMethodToolStripMenuItem";
            this.orderDetailsWithCustomMethodToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.orderDetailsWithCustomMethodToolStripMenuItem.Text = "orderDetailsWithCustomMethod";
            this.orderDetailsWithCustomMethodToolStripMenuItem.Click += new System.EventHandler(this.orderDetailsWithCustomMethodToolStripMenuItem_Click);
            // 
            // tPHDisplayCarsToolStripMenuItem
            // 
            this.tPHDisplayCarsToolStripMenuItem.Name = "tPHDisplayCarsToolStripMenuItem";
            this.tPHDisplayCarsToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.tPHDisplayCarsToolStripMenuItem.Text = "tPHDisplayCars";
            this.tPHDisplayCarsToolStripMenuItem.Click += new System.EventHandler(this.tPHDisplayCarsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stToolStripMenuItem;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem lazyLoadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eagerLoadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explicitLoadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeStoredProcedureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsWoCustomMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsWithCustomMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tPHDisplayCarsToolStripMenuItem;
    }
}

