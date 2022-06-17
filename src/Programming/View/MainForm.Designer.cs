namespace Programming.View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProgrammingTabControl = new System.Windows.Forms.TabControl();
            this.EnumsTabControl = new System.Windows.Forms.TabPage();
            this.seasonsHandleControl1 = new Programming.View.Controls.SeasonsHandleControl();
            this.weekdayParsinControl1 = new Programming.View.Controls.WeekdayParsingControl();
            this.groupBoxEnumerationsControl1 = new Programming.View.Controls.EnumerationsControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.movieControl1 = new Programming.View.Controls.MovieControl();
            this.rectanglesControl1 = new Programming.View.Controls.RectanglesControl();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.Controls.RectanglesCollisionControl();
            this.ProgrammingTabControl.SuspendLayout();
            this.EnumsTabControl.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgrammingTabControl
            // 
            this.ProgrammingTabControl.Controls.Add(this.EnumsTabControl);
            this.ProgrammingTabControl.Controls.Add(this.ClassesTabPage);
            this.ProgrammingTabControl.Controls.Add(this.RectanglesTabPage);
            this.ProgrammingTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgrammingTabControl.Location = new System.Drawing.Point(0, 0);
            this.ProgrammingTabControl.Name = "ProgrammingTabControl";
            this.ProgrammingTabControl.SelectedIndex = 0;
            this.ProgrammingTabControl.Size = new System.Drawing.Size(800, 450);
            this.ProgrammingTabControl.TabIndex = 0;
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Controls.Add(this.seasonsHandleControl1);
            this.EnumsTabControl.Controls.Add(this.weekdayParsinControl1);
            this.EnumsTabControl.Controls.Add(this.groupBoxEnumerationsControl1);
            this.EnumsTabControl.Location = new System.Drawing.Point(4, 24);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabControl.Size = new System.Drawing.Size(792, 422);
            this.EnumsTabControl.TabIndex = 0;
            this.EnumsTabControl.Text = "Enums";
            this.EnumsTabControl.UseVisualStyleBackColor = true;
            // 
            // seasonsHandleControl1
            // 
            this.seasonsHandleControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seasonsHandleControl1.Location = new System.Drawing.Point(394, 274);
            this.seasonsHandleControl1.Name = "seasonsHandleControl1";
            this.seasonsHandleControl1.Size = new System.Drawing.Size(392, 140);
            this.seasonsHandleControl1.TabIndex = 4;
            // 
            // weekdayParsinControl1
            // 
            this.weekdayParsinControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.weekdayParsinControl1.Location = new System.Drawing.Point(6, 274);
            this.weekdayParsinControl1.Name = "weekdayParsinControl1";
            this.weekdayParsinControl1.Size = new System.Drawing.Size(382, 140);
            this.weekdayParsinControl1.TabIndex = 3;
            // 
            // groupBoxEnumerationsControl1
            // 
            this.groupBoxEnumerationsControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEnumerationsControl1.Location = new System.Drawing.Point(6, 6);
            this.groupBoxEnumerationsControl1.Name = "groupBoxEnumerationsControl1";
            this.groupBoxEnumerationsControl1.Size = new System.Drawing.Size(780, 262);
            this.groupBoxEnumerationsControl1.TabIndex = 2;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.movieControl1);
            this.ClassesTabPage.Controls.Add(this.rectanglesControl1);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 24);
            this.ClassesTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Size = new System.Drawing.Size(792, 422);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // movieControl1
            // 
            this.movieControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.movieControl1.Location = new System.Drawing.Point(413, 0);
            this.movieControl1.Name = "movieControl1";
            this.movieControl1.Size = new System.Drawing.Size(379, 422);
            this.movieControl1.TabIndex = 3;
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Location = new System.Drawing.Point(6, 6);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(393, 419);
            this.rectanglesControl1.TabIndex = 2;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.rectanglesCollisionControl1);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 24);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesTabPage.Size = new System.Drawing.Size(792, 422);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(3, 3);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(786, 416);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProgrammingTabControl);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming Demo";
            this.ProgrammingTabControl.ResumeLayout(false);
            this.EnumsTabControl.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ProgrammingTabControl;
        private System.Windows.Forms.TabPage EnumsTabControl;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label HeightLabel2;
        private Controls.RectanglesCollisionControl rectanglesCollisionControl1;
        private Controls.EnumerationsControl groupBoxEnumerationsControl1;
        private Controls.WeekdayParsingControl weekdayParsinControl1;
        private Controls.SeasonsHandleControl seasonsHandleControl1;
        private Controls.RectanglesControl rectanglesControl1;
        private Controls.MovieControl movieControl1;
    }
}

