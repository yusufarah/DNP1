namespace DNProj
{
    partial class ScheduleSelection
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
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.lsbSchedule = new System.Windows.Forms.ListBox();
            this.rtxtboxBio = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // picPoster
            // 
            this.picPoster.Location = new System.Drawing.Point(13, 13);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(200, 300);
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            // 
            // lsbSchedule
            // 
            this.lsbSchedule.FormattingEnabled = true;
            this.lsbSchedule.Location = new System.Drawing.Point(219, 12);
            this.lsbSchedule.Name = "lsbSchedule";
            this.lsbSchedule.Size = new System.Drawing.Size(569, 121);
            this.lsbSchedule.TabIndex = 1;
            this.lsbSchedule.DoubleClick += new System.EventHandler(this.lsbSchedule_DoubleClick);
            // 
            // rtxtboxBio
            // 
            this.rtxtboxBio.Location = new System.Drawing.Point(219, 139);
            this.rtxtboxBio.Name = "rtxtboxBio";
            this.rtxtboxBio.Size = new System.Drawing.Size(569, 174);
            this.rtxtboxBio.TabIndex = 2;
            this.rtxtboxBio.Text = "";
            this.rtxtboxBio.DoubleClick += new System.EventHandler(this.rtxtboxBio_DoubleClick);
            // 
            // ScheduleSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 328);
            this.Controls.Add(this.rtxtboxBio);
            this.Controls.Add(this.lsbSchedule);
            this.Controls.Add(this.picPoster);
            this.Name = "ScheduleSelection";
            this.Text = "ScheduleSelection";
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.ListBox lsbSchedule;
        private System.Windows.Forms.RichTextBox rtxtboxBio;
    }
}