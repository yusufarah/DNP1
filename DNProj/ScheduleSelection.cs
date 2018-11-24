using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIACinemaDB.Model;

namespace DNProj
{
    public partial class ScheduleSelection : Form
    {
        private Movie movie;
        public ScheduleSelection(Movie m)
        {
            InitializeComponent();
            movie = m;
            fillSchudules(m);
            fillBio(m);
            addPicture(m);
        }

        private void fillSchudules(Movie movie)
        {
            lsbSchedule.Items.Clear();
            lsbSchedule.DisplayMember = "date_time";
            foreach (var item in movie.Schedules)
            {
                lsbSchedule.Items.Add(item);
            }            
        }

        private void fillBio(Movie movie)
        {
            rtxtboxBio.AppendText("Description: " + movie.description + Environment.NewLine);
            rtxtboxBio.AppendText(Environment.NewLine);
            rtxtboxBio.AppendText("Duration: " + movie.duration + " minutes" + Environment.NewLine);
            rtxtboxBio.AppendText("Director: " + movie.director + Environment.NewLine);
            rtxtboxBio.AppendText("Actor: " + movie.actor);
        }

        private void addPicture(Movie movie)
        {
            picPoster.Load(movie.imageURL);
        }

        private void rtxtboxBio_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void lsbSchedule_DoubleClick(object sender, EventArgs e)
        {            
            SeatSelection seatSelection = new SeatSelection(lsbSchedule.SelectedItem as Schedule);
            seatSelection.ShowDialog();
        }
    }
}
