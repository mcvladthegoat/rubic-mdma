﻿namespace mdma
{
    partial class MDMa
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
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validateSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.compRulesMethod = new System.Windows.Forms.Button();
            this.threshAgrMethod = new System.Windows.Forms.Button();
            this.haraMethod = new System.Windows.Forms.Button();
            this.nansenMethod = new System.Windows.Forms.Button();
            this.paretoMethod = new System.Windows.Forms.Button();
            this.bordaMethod = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(747, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validateSourceToolStripMenuItem,
            this.clearAllToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // validateSourceToolStripMenuItem
            // 
            this.validateSourceToolStripMenuItem.Name = "validateSourceToolStripMenuItem";
            this.validateSourceToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.validateSourceToolStripMenuItem.Text = "Validate source";
            this.validateSourceToolStripMenuItem.Click += new System.EventHandler(this.validateSourceToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.clearAllToolStripMenuItem.Text = "Clear all";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 24);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(16, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 283);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.compRulesMethod);
            this.groupBox1.Controls.Add(this.threshAgrMethod);
            this.groupBox1.Controls.Add(this.haraMethod);
            this.groupBox1.Controls.Add(this.nansenMethod);
            this.groupBox1.Controls.Add(this.paretoMethod);
            this.groupBox1.Controls.Add(this.bordaMethod);
            this.groupBox1.Location = new System.Drawing.Point(16, 342);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(375, 230);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action methods";
            // 
            // compRulesMethod
            // 
            this.compRulesMethod.Location = new System.Drawing.Point(229, 81);
            this.compRulesMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.compRulesMethod.Name = "compRulesMethod";
            this.compRulesMethod.Size = new System.Drawing.Size(100, 28);
            this.compRulesMethod.TabIndex = 6;
            this.compRulesMethod.Text = "Comp. rules";
            this.compRulesMethod.UseVisualStyleBackColor = true;
            // 
            // threshAgrMethod
            // 
            this.threshAgrMethod.Location = new System.Drawing.Point(121, 81);
            this.threshAgrMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.threshAgrMethod.Name = "threshAgrMethod";
            this.threshAgrMethod.Size = new System.Drawing.Size(100, 28);
            this.threshAgrMethod.TabIndex = 5;
            this.threshAgrMethod.Text = "thr. agregate";
            this.threshAgrMethod.UseVisualStyleBackColor = true;
            // 
            // haraMethod
            // 
            this.haraMethod.Location = new System.Drawing.Point(13, 81);
            this.haraMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.haraMethod.Name = "haraMethod";
            this.haraMethod.Size = new System.Drawing.Size(100, 28);
            this.haraMethod.TabIndex = 4;
            this.haraMethod.Text = "Hara";
            this.haraMethod.UseVisualStyleBackColor = true;
            // 
            // nansenMethod
            // 
            this.nansenMethod.Location = new System.Drawing.Point(229, 34);
            this.nansenMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nansenMethod.Name = "nansenMethod";
            this.nansenMethod.Size = new System.Drawing.Size(100, 28);
            this.nansenMethod.TabIndex = 3;
            this.nansenMethod.Text = "Nansen";
            this.nansenMethod.UseVisualStyleBackColor = true;
            // 
            // paretoMethod
            // 
            this.paretoMethod.Location = new System.Drawing.Point(121, 34);
            this.paretoMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paretoMethod.Name = "paretoMethod";
            this.paretoMethod.Size = new System.Drawing.Size(100, 28);
            this.paretoMethod.TabIndex = 1;
            this.paretoMethod.Text = "Pareto";
            this.paretoMethod.UseVisualStyleBackColor = true;
            // 
            // bordaMethod
            // 
            this.bordaMethod.Location = new System.Drawing.Point(13, 34);
            this.bordaMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bordaMethod.Name = "bordaMethod";
            this.bordaMethod.Size = new System.Drawing.Size(100, 28);
            this.bordaMethod.TabIndex = 0;
            this.bordaMethod.Text = "Borda count";
            this.bordaMethod.UseVisualStyleBackColor = true;
            this.bordaMethod.Click += new System.EventHandler(this.bordaMethod_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(16, 481);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(375, 283);
            this.dataGridView2.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(684, 31);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(51, 23);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Position";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Candidate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Person";
            this.Column1.Name = "Column1";
            // 
            // MDMa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 794);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MDMa";
            this.Text = "MDMa";
            this.Load += new System.EventHandler(this.MDMa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validateSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button compRulesMethod;
        private System.Windows.Forms.Button threshAgrMethod;
        private System.Windows.Forms.Button haraMethod;
        private System.Windows.Forms.Button nansenMethod;
        private System.Windows.Forms.Button paretoMethod;
        private System.Windows.Forms.Button bordaMethod;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

