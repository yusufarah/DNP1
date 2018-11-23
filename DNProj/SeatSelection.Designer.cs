namespace DNProj
{
    partial class SeatSelection
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReserve = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSeatnumber = new System.Windows.Forms.Label();
            this.lblReserveret = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtboxSeatNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 310);
            this.panel1.TabIndex = 0;
            // 
            // btnReserve
            // 
            this.btnReserve.AutoSize = true;
            this.btnReserve.Location = new System.Drawing.Point(615, 298);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(80, 23);
            this.btnReserve.TabIndex = 1;
            this.btnReserve.Text = "Reserve seat";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(821, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "!implement";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblSeatnumber
            // 
            this.lblSeatnumber.AutoSize = true;
            this.lblSeatnumber.Location = new System.Drawing.Point(548, 15);
            this.lblSeatnumber.Name = "lblSeatnumber";
            this.lblSeatnumber.Size = new System.Drawing.Size(64, 13);
            this.lblSeatnumber.TabIndex = 4;
            this.lblSeatnumber.Text = "Seatnumber";
            // 
            // lblReserveret
            // 
            this.lblReserveret.AutoSize = true;
            this.lblReserveret.Location = new System.Drawing.Point(612, 35);
            this.lblReserveret.Name = "lblReserveret";
            this.lblReserveret.Size = new System.Drawing.Size(30, 13);
            this.lblReserveret.TabIndex = 5;
            this.lblReserveret.Text = "temp";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(615, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 20);
            this.textBox1.TabIndex = 6;
            // 
            // txtboxSeatNumber
            // 
            this.txtboxSeatNumber.Location = new System.Drawing.Point(615, 12);
            this.txtboxSeatNumber.Name = "txtboxSeatNumber";
            this.txtboxSeatNumber.ReadOnly = true;
            this.txtboxSeatNumber.Size = new System.Drawing.Size(80, 20);
            this.txtboxSeatNumber.TabIndex = 3;
            // 
            // SeatSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 353);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblReserveret);
            this.Controls.Add(this.lblSeatnumber);
            this.Controls.Add(this.txtboxSeatNumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.panel1);
            this.Name = "SeatSelection";
            this.Text = "SeatSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblSeatnumber;
        private System.Windows.Forms.Label lblReserveret;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtboxSeatNumber;
    }
}