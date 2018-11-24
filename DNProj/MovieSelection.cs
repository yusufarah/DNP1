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
    public partial class MovieSelection : Form
    {
        Controller controller;
        public MovieSelection()
        {
            InitializeComponent();
            controller = new Controller();
            addMovies();
        }

        private void addMovies()
        {
            lsbMovies.Items.Clear();
            lsbMovies.DisplayMember = "name";
            int x = 0;

            foreach (var item in controller.GetMovies())
            {
                lsbMovies.Items.Add(item);
                x++;
            }
            Console.WriteLine(x);
        }

        private void lsbMovies_DoubleClick(object sender, EventArgs e)
        {
            ScheduleSelection scheduleSelection = new ScheduleSelection(lsbMovies.SelectedItem as Movie);
            scheduleSelection.ShowDialog();
        }
    }
}
