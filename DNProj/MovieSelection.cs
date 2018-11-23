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
    public partial class MovieSelection : Form
    {
        private List<Movie> temp = new List<Movie>();
        public MovieSelection()
        {
            InitializeComponent();
            addMovies();
        }

        private void addMovies()
        {
            lsbMovies.Items.Clear();
            Movie movie1 = new Movie("Spiderman", "This is a movie about Spiderman", 2010);
            Movie movie2 = new Movie("Batman", "This is a movie about Batman", 2030);

            temp.Add(movie1);
            temp.Add(movie2);


            lsbMovies.DisplayMember = "Name";
            lsbMovies.ValueMember = "Bio";

            foreach (var item in temp)
            {
                lsbMovies.Items.Add(item);
            }

        }

        private void lsbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScheduleSelection scheduleSelection = new ScheduleSelection();
            scheduleSelection.ShowDialog();
        }
    }
}
