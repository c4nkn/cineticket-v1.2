using CinemaTicket.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTicket
{
    public partial class MainForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public List<Movie> allMovies;

        public MainForm()
        {
            InitializeComponent();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimize_MouseEnter(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.FromArgb(37, 38, 44);
        }

        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.FromArgb(13, 14, 20);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(37, 38, 44);
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(13, 14, 20);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
