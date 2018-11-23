namespace DNProj
{
    partial class MovieSelection
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
            this.lsbMovies = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsbMovies
            // 
            this.lsbMovies.FormattingEnabled = true;
            this.lsbMovies.Items.AddRange(new object[] {
            "Spiderman",
            "Batman"});
            this.lsbMovies.Location = new System.Drawing.Point(13, 13);
            this.lsbMovies.Name = "lsbMovies";
            this.lsbMovies.Size = new System.Drawing.Size(419, 420);
            this.lsbMovies.TabIndex = 0;
            this.lsbMovies.SelectedIndexChanged += new System.EventHandler(this.lsbMovies_SelectedIndexChanged);
            // 
            // MovieSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.lsbMovies);
            this.Name = "MovieSelection";
            this.Text = "MovieSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbMovies;
    }
}