
namespace Programming.View.Controls
{
    partial class MovieControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MovieGroupBox = new System.Windows.Forms.GroupBox();
            this.FindRatingButton = new System.Windows.Forms.Button();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.DurationLable = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseYearLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.MovieGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovieGroupBox
            // 
            this.MovieGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieGroupBox.Controls.Add(this.FindRatingButton);
            this.MovieGroupBox.Controls.Add(this.DurationTextBox);
            this.MovieGroupBox.Controls.Add(this.DurationLable);
            this.MovieGroupBox.Controls.Add(this.RatingTextBox);
            this.MovieGroupBox.Controls.Add(this.RatingLabel);
            this.MovieGroupBox.Controls.Add(this.GenreTextBox);
            this.MovieGroupBox.Controls.Add(this.GenreLabel);
            this.MovieGroupBox.Controls.Add(this.YearTextBox);
            this.MovieGroupBox.Controls.Add(this.ReleaseYearLabel);
            this.MovieGroupBox.Controls.Add(this.NameTextBox);
            this.MovieGroupBox.Controls.Add(this.NameLabel);
            this.MovieGroupBox.Controls.Add(this.MovieListBox);
            this.MovieGroupBox.Location = new System.Drawing.Point(411, 6);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Size = new System.Drawing.Size(375, 409);
            this.MovieGroupBox.TabIndex = 2;
            this.MovieGroupBox.TabStop = false;
            this.MovieGroupBox.Text = "Movie";
            // 
            // FindRatingButton
            // 
            this.FindRatingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FindRatingButton.Location = new System.Drawing.Point(226, 374);
            this.FindRatingButton.Name = "FindRatingButton";
            this.FindRatingButton.Size = new System.Drawing.Size(101, 23);
            this.FindRatingButton.TabIndex = 11;
            this.FindRatingButton.Text = "Find";
            this.FindRatingButton.UseVisualStyleBackColor = true;
            this.FindRatingButton.Click += new System.EventHandler(this.FindRatingButton_Click);
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DurationTextBox.Location = new System.Drawing.Point(226, 213);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(100, 23);
            this.DurationTextBox.TabIndex = 10;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // DurationLable
            // 
            this.DurationLable.AutoSize = true;
            this.DurationLable.Location = new System.Drawing.Point(226, 195);
            this.DurationLable.Name = "DurationLable";
            this.DurationLable.Size = new System.Drawing.Size(56, 15);
            this.DurationLable.TabIndex = 9;
            this.DurationLable.Text = "Duration:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(226, 169);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(100, 23);
            this.RatingTextBox.TabIndex = 8;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(226, 151);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(44, 15);
            this.RatingLabel.TabIndex = 7;
            this.RatingLabel.Text = "Rating:";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(226, 125);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(101, 23);
            this.GenreTextBox.TabIndex = 6;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(226, 107);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(41, 15);
            this.GenreLabel.TabIndex = 5;
            this.GenreLabel.Text = "Genre:";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(226, 81);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(101, 23);
            this.YearTextBox.TabIndex = 4;
            this.YearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // ReleaseYearLabel
            // 
            this.ReleaseYearLabel.AutoSize = true;
            this.ReleaseYearLabel.Location = new System.Drawing.Point(226, 63);
            this.ReleaseYearLabel.Name = "ReleaseYearLabel";
            this.ReleaseYearLabel.Size = new System.Drawing.Size(74, 15);
            this.ReleaseYearLabel.TabIndex = 3;
            this.ReleaseYearLabel.Text = "Release year:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(226, 37);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(101, 23);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(226, 19);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(42, 15);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // MovieListBox
            // 
            this.MovieListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.ItemHeight = 15;
            this.MovieListBox.Location = new System.Drawing.Point(6, 18);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(211, 379);
            this.MovieListBox.TabIndex = 0;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // MovieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MovieGroupBox);
            this.Name = "MovieControl";
            this.Size = new System.Drawing.Size(816, 489);
            this.MovieGroupBox.ResumeLayout(false);
            this.MovieGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MovieGroupBox;
        private System.Windows.Forms.Button FindRatingButton;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Label DurationLable;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label ReleaseYearLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ListBox MovieListBox;
    }
}
