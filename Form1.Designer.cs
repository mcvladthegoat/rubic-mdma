namespace mdma
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.validateSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bordaMethod = new System.Windows.Forms.Button();
            this.paretoMethod = new System.Windows.Forms.Button();
            this.nansenMethod = new System.Windows.Forms.Button();
            this.haraMethod = new System.Windows.Forms.Button();
            this.threshAgrMethod = new System.Windows.Forms.Button();
            this.compRulesMethod = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(307, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validateSourceToolStripMenuItem,
            this.clearAllToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // validateSourceToolStripMenuItem
            // 
            this.validateSourceToolStripMenuItem.Name = "validateSourceToolStripMenuItem";
            this.validateSourceToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.validateSourceToolStripMenuItem.Text = "Validate source";
            this.validateSourceToolStripMenuItem.Click += new System.EventHandler(this.validateSourceToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(281, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.clearAllToolStripMenuItem.Text = "Clear all";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.compRulesMethod);
            this.groupBox1.Controls.Add(this.threshAgrMethod);
            this.groupBox1.Controls.Add(this.haraMethod);
            this.groupBox1.Controls.Add(this.nansenMethod);
            this.groupBox1.Controls.Add(this.paretoMethod);
            this.groupBox1.Controls.Add(this.bordaMethod);
            this.groupBox1.Location = new System.Drawing.Point(12, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 187);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action methods";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Person";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Results";
            this.Column2.Name = "Column2";
            // 
            // bordaMethod
            // 
            this.bordaMethod.Location = new System.Drawing.Point(10, 28);
            this.bordaMethod.Name = "bordaMethod";
            this.bordaMethod.Size = new System.Drawing.Size(75, 23);
            this.bordaMethod.TabIndex = 0;
            this.bordaMethod.Text = "Borda count";
            this.bordaMethod.UseVisualStyleBackColor = true;
            // 
            // paretoMethod
            // 
            this.paretoMethod.Location = new System.Drawing.Point(91, 28);
            this.paretoMethod.Name = "paretoMethod";
            this.paretoMethod.Size = new System.Drawing.Size(75, 23);
            this.paretoMethod.TabIndex = 1;
            this.paretoMethod.Text = "Pareto";
            this.paretoMethod.UseVisualStyleBackColor = true;
            // 
            // nansenMethod
            // 
            this.nansenMethod.Location = new System.Drawing.Point(172, 28);
            this.nansenMethod.Name = "nansenMethod";
            this.nansenMethod.Size = new System.Drawing.Size(75, 23);
            this.nansenMethod.TabIndex = 3;
            this.nansenMethod.Text = "Nansen";
            this.nansenMethod.UseVisualStyleBackColor = true;
            // 
            // haraMethod
            // 
            this.haraMethod.Location = new System.Drawing.Point(10, 66);
            this.haraMethod.Name = "haraMethod";
            this.haraMethod.Size = new System.Drawing.Size(75, 23);
            this.haraMethod.TabIndex = 4;
            this.haraMethod.Text = "Hara";
            this.haraMethod.UseVisualStyleBackColor = true;
            // 
            // threshAgrMethod
            // 
            this.threshAgrMethod.Location = new System.Drawing.Point(91, 66);
            this.threshAgrMethod.Name = "threshAgrMethod";
            this.threshAgrMethod.Size = new System.Drawing.Size(75, 23);
            this.threshAgrMethod.TabIndex = 5;
            this.threshAgrMethod.Text = "thr. agregate";
            this.threshAgrMethod.UseVisualStyleBackColor = true;
            // 
            // compRulesMethod
            // 
            this.compRulesMethod.Location = new System.Drawing.Point(172, 66);
            this.compRulesMethod.Name = "compRulesMethod";
            this.compRulesMethod.Size = new System.Drawing.Size(75, 23);
            this.compRulesMethod.TabIndex = 6;
            this.compRulesMethod.Text = "Comp. rules";
            this.compRulesMethod.UseVisualStyleBackColor = true;
            // 
            // MDMa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 477);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MDMa";
            this.Text = "MDMa";
            this.Load += new System.EventHandler(this.MDMa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button compRulesMethod;
        private System.Windows.Forms.Button threshAgrMethod;
        private System.Windows.Forms.Button haraMethod;
        private System.Windows.Forms.Button nansenMethod;
        private System.Windows.Forms.Button paretoMethod;
        private System.Windows.Forms.Button bordaMethod;
    }
}

