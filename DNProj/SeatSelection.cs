using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNProj
{
    public partial class SeatSelection : Form
    {
        public SeatSelection()
        {
            InitializeComponent();
            reserveSeats();
            CreateSeats();

        }

        private void CreateSeats()
        {
            int seatNumber = 1;
            int lblXpoint = 5;
            int lblYpoint = 5;

            while (seatNumber <= 150)
            {
                for (int i = 0; i < 15; i++)
                {
                    panel1.Controls.Add(new Label
                    {
                        Location = new Point(lblXpoint, lblYpoint),
                        Size = new Size(30, 25),
                        BorderStyle = BorderStyle.FixedSingle,
                        Text = seatNumber + "",
                        TextAlign = ContentAlignment.MiddleCenter,
                        Name = "lbl" + seatNumber,
                        BackColor = Color.Green,
                    });
                    lblXpoint += 35;
                    seatNumber++;
                }
                lblYpoint += 30;
                lblXpoint = 5;
            }
            foreach (Control control in panel1.Controls)
            {
                control.Click += label_Click;
                if (randomNumbers.Contains(Convert.ToInt32(control.Name.Substring(3))))
                {
                    control.BackColor = Color.Red;
                }
            }
        }

        private List<int> randomNumbers = new List<int>();
        private void reserveSeats()
        {
            var rnd = new Random();
            randomNumbers = Enumerable.Range(1, 150).OrderBy(x => rnd.Next()).Take(50).ToList();
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label temp = sender as Label;
            txtboxSeatNumber.Text = temp.Name.Substring(3);
            if (temp.BackColor == Color.Red)
            {
                lblReserveret.Text = "This seat is reservered";
                btnReserve.Enabled = false;
            } else
            {
                lblReserveret.Text = "This seat is free";
                btnReserve.Enabled = true;
                
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            foreach (Control control in panel1.Controls)
            {
                if (Convert.ToInt32(txtboxSeatNumber.Text) == Convert.ToInt32(control.Name.Substring(3)))
                {
                    control.BackColor = Color.Red;
                }
                
            }
        }
    }
}
