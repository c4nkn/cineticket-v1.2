using CinemaTicket.Data;
using CinemaTicket.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();

                if (!context.Movies.Any() && !context.Halls.Any() && !context.Sessions.Any())
                {
                    DbLoader.Load(context);
                }

                allMovies = context.Movies.ToList();
            }

            InitializeComponent();
            LoadMovies();
        }

        public void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void minimize_MouseEnter(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.FromArgb(37, 38, 44);
        }

        public void minimize_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.BackColor = Color.FromArgb(13, 14, 20);
        }

        public void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void close_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(37, 38, 44);
        }

        public void close_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(13, 14, 20);
        }

        public void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        public void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        public void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void LoadMovies()
        {
            int startX1 = 35;
            int startX2 = 95;
            int startY1 = 280;
            int startY2 = 265;

            for (int i = 0; i < allMovies.Count; i++)
            {
                int row = i / 4;
                int column = i % 4;

                int x1 = startX1 + column * (80 + 130);
                int y1 = startY1 + row * (130 + 50);

                int x2 = startX2 + column * (135 + 75);
                int y2 = startY2 + row * (165 + 15);

                PictureBox pictureBox = new PictureBox()
                {
                    Image = Image.FromFile("..\\..\\Images\\" + i + ".png"),
                    Size = new Size(100, 130),
                    SizeMode = PictureBoxSizeMode.CenterImage,
                    Location = new Point(x1, y1),
                };

                Button pButton = new Button()
                {
                    Size = new Size(135, 165),
                    Text = allMovies[i].Title,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand,
                    Location = new Point(x2, y2),
                    Tag = allMovies[i].Id
                };

                if (File.Exists(allMovies[i].Thumbnail))
                {
                    pButton.Image = Image.FromFile(allMovies[i].Thumbnail);
                    pButton.FlatAppearance.BorderSize = 0;
                }

                pButton.Click += (sender, e) =>
                {
                    Button clickedButton = (Button)sender;
                    int movieId = (int)clickedButton.Tag;

                    ReservationForm reservationForm = new ReservationForm(movieId);
                    reservationForm.Show();
                    this.Owner = reservationForm;
                    this.Hide();
                };

                Controls.Add(pictureBox);
                Controls.Add(pButton);
                Controls.SetChildIndex(pButton, 0);
            }
        }
    }
}
