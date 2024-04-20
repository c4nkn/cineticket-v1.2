using CinemaTicket.Data;
using CinemaTicket.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CinemaTicket
{
    public partial class ReservationForm : Form
    {
        public List<string> selectedSeats = new List<string>();
        public int selectedMovie, selectedSession, selectedHall, newId;
        bool tab2, tab3, tab4, isSessionSelected = false;
        private bool mouseDown;
        private Point lastLocation;

        public ReservationForm(int _selectedMovie)
        {
            InitializeComponent();

            selectedMovie = _selectedMovie;

            using (var context = new AppDbContext())
            {
                var filteredSessions = context.Sessions
                    .Where(s => s.AssignedMovieId == _selectedMovie)
                    .Include(s => s.AssignedHall)
                    .Select(s => new Session
                    {
                        Id = s.Id,
                        Date = s.Date,
                        Features = s.Features,
                        Duration = s.Duration,
                        ReservedSeats = s.ReservedSeats,
                        AssignedHallId = s.AssignedHallId,
                        AssignedHall = s.AssignedHall
                    })
                    .ToList();

                var selectedMovieName = context.Movies
                    .Where(m => m.Id == _selectedMovie)
                    .Select(m => m.Title)
                    .FirstOrDefault();

                forMovie.Text = "for: " + selectedMovieName;
                ListSessions(filteredSessions);
            }

            getSeatsBtn.Enabled = false;
            forMovie.Location = new Point(this.ClientSize.Width / 2 - forMovie.Width / 2, forMovie.Location.Y);
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            tabControl1.DrawItem += new DrawItemEventHandler(this.tabControl1_DrawItem);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            isSessionSelected = true;
            getSeatsBtn.Enabled = dataGridView1.SelectedRows.Count > 0;

            if (tab2)
            {
                ClearSeatTab();

                if (selectedSeats.Any())
                {
                    foreach (var seat in selectedSeats)
                    {
                        selectedSeats.Remove(seat);
                    }
                }

                tab2 = false;
            }

            if (tab3)
            {
                ClearDetailsTab();
                tab3 = false;
            }

            if (tab4)
            {
                using (var context = new AppDbContext())
                {
                    var session = context.Sessions
                        .Where(s => s.Id == selectedSession)
                        .Include(s => s.AssignedHall)
                        .FirstOrDefault();

                    dateLbl.Text = session.Date.ToString("dd MMMM");
                    timeLbl.Text = session.Date.ToString("HH:mm");
                }
                tab4 = false;
            }
        }

        public void ListSessions(List<Session> sessions)
        {
            foreach (var session in sessions)
            {
                if (session != null)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();

                    string assignedHall = session.AssignedHall?.Name ?? "Not Available";
                    string features = session.Features ?? "Not Available";

                    List<string> reservedSeats = session.ReservedSeats.Split(',').Select(seat => seat.Trim()).ToList();
                    int availableSeatsCount = session.AssignedHall.TotalSeats - reservedSeats.Count;
                    string availability = availableSeatsCount.ToString() + " seat(s) left.";

                    dataGridViewRow.CreateCells(
                        dataGridView1,
                        session.Id,
                        session.Date,
                        session.Duration,
                        features,
                        availability
                    );

                    if (availableSeatsCount < 10)
                    {
                        dataGridViewRow.Cells[4].Style.ForeColor = Color.IndianRed;
                    } else
                    {
                        dataGridViewRow.Cells[4].Style.ForeColor = Color.Green;
                    }

                    dataGridView1.Rows.Add(dataGridViewRow);
                }
            }
        }

        private void GetSeatsBtn_Click(object sender, EventArgs e)
        {
            tab2 = true;
            tabControl1.SelectedTab = tabPage2;

            if (isSessionSelected && dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int selectedSessionId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);
                selectedSession = selectedSessionId;

                using (var context = new AppDbContext()) {
                    var selectedSession = context.Sessions
                        .Where(s => s.Id == selectedSessionId)
                        .Include(s => s.AssignedHall)
                        .FirstOrDefault();

                    var assignedHall = context.Halls
                        .Where(m => m.Id == selectedSession.AssignedHallId)
                        .FirstOrDefault();

                    DrawSeats(selectedSession.ReservedSeats, tabPage2);
                }
            }

            if (!selectedSeats.Any())
            {
                getDetailsBtn.Enabled = false;
            }
        }

        private void DrawSeats(string _reservedSeats, TabPage tabPage)
        {
            List<string> reservedSeats = _reservedSeats.Split(',').Select(seat => seat.Trim()).ToList();

            int rowSize = 7;
            int columnSize = 12;

            int buttonWidth = 35;
            int buttonHeight = 35;
            int spacing = 5;

            int startX = (tabPage.Width - (columnSize * (buttonWidth + spacing))) / 2;
            int startY = 135;

            for (int i = 0; i < rowSize; i++)
            {
                char rowLetter = (char)('A' + i);

                for (int j = 0; j < columnSize; j++)
                {
                    int seatNumber = j + 1;
                    string seatName = $"{rowLetter}{seatNumber}";

                    System.Windows.Forms.Button seatButton = new System.Windows.Forms.Button
                    {
                        Name = seatName,
                        Tag = seatName,
                        Image = Image.FromFile("..\\..\\Images\\EmptySeat.png"),
                        FlatStyle = FlatStyle.Flat,
                        Width = buttonWidth,
                        Height = buttonHeight,
                        Location = new Point(startX + j * (buttonWidth + spacing), startY + i * (buttonHeight + spacing))
                    };

                    if (reservedSeats.Contains(seatName))
                    {
                        seatButton.Image = Image.FromFile("..\\..\\Images\\TakenSeat.png");
                    }
                    else
                    {
                        seatButton.Click += SeatBtn_Click;
                    }

                    seatButton.FlatAppearance.BorderSize = 0;
                    tabPage.Controls.Add(seatButton);
                }
            }
        }

        private void SeatBtn_Click(object sender, EventArgs e)
        {
            if (tab3)
            {
                ClearDetailsTab();
                tab3 = false;
            }

            if (tab4)
            {
                seatsLbl.Text = string.Join(", ", selectedSeats);
                tab4 = false;
            }

            System.Windows.Forms.Button seatButton = sender as System.Windows.Forms.Button;
            string seatName = seatButton.Name;

            if (selectedSeats.Contains(seatName))
            {
                selectedSeats.Remove(seatName);
                seatButton.Image = Image.FromFile("..\\..\\Images\\EmptySeat.png");
            }
            else
            {
                selectedSeats.Add(seatName);
                seatButton.Image = Image.FromFile("..\\..\\Images\\SelectedSeat.png");
            }

            if (selectedSeats.Count > 0)
            {
                getDetailsBtn.Enabled = true;
                getDetailsBtn.FlatAppearance.BorderColor = Color.SeaGreen;
                getDetailsBtn.ForeColor = Color.SeaGreen;
            } else if (selectedSeats.Count == 0)
            {
                getDetailsBtn.Enabled = false;
                getDetailsBtn.FlatAppearance.BorderColor = Color.DimGray;
                getDetailsBtn.ForeColor = Color.Gray;
            }

            UpdateSelectedSeatsText();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var session = context.Sessions.FirstOrDefault(s => s.Id == selectedSession);

                foreach (var seat in selectedSeats)
                {
                    session.ReservedSeats += (session.ReservedSeats == "") ? seat : $", {seat}";
                }

                for (int i = 0; i < selectedSeats.Count; i++)
                {
                    var reservation = new Reservation
                    {
                        Id = newId,
                        Price = 25,
                        SelectedSeat = selectedSeats[i],
                        SelectedMovieId = selectedMovie,
                        SelectedSessionId = selectedSession
                    };
                    context.Add(reservation);
                }

                context.SaveChanges();
            }

            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Owner = mainForm;
            this.Hide();
        }

        private void ClearSeatTab()
        {
            foreach (Control control in tabPage2.Controls)
            {
                if (!(control.Name == "getDetailsBtn" || control.Name == "tab2Footer" || control.Name == "screen" || control.Name == "tab2Title" || control.Name == "lblSelectedSeats"))
                {
                    tabPage2.Controls.Remove(control);
                }
            }

            selectedSeats.Clear();
            UpdateSelectedSeatsText();
        }

        private void ClearDetailsTab()
        {
            foreach (Control control in tabPage3.Controls)
            {
                if (!(control.Name == "showSummaryBtn" || control.Name == "tab3Footer" || control.Name == "tab3Detail" || control.Name == "tab3Title")) 
                {
                    tabPage3.Controls.Remove(control);
                }
            }
        }

        private void UpdateSelectedSeatsText()
        {
            string selectedSeatsText = string.Join(", ", selectedSeats);
            lblSelectedSeats.Text = $"Selected seats: {selectedSeatsText}";
            lblSelectedSeats.Location = new Point(this.ClientSize.Width / 2 - lblSelectedSeats.Width / 2, lblSelectedSeats.Location.Y);
        }

        private void getDetailsBtn_Click(object sender, EventArgs e)
        {
            tab3 = true;
            tabControl1.SelectedTab = tabPage3;

            int startX1 = 245;
            int startY1 = 130;
            int startX2 = 350;
            int startY2 = 125;
            int y1 = startY1;
            int y2 = startY2;

            for (int i = 0; i < selectedSeats.Count; i++)
            {
                System.Windows.Forms.Label seatLbl = new System.Windows.Forms.Label()
                {
                    ForeColor = Color.White,
                    Location = new Point(startX1, y1),
                    Text = $"Seat {selectedSeats[i]}:"
                };

                System.Windows.Forms.TextBox inputTF = new System.Windows.Forms.TextBox()
                {
                    BackColor = Color.FromArgb(16, 17, 23),
                    ForeColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    MaxLength = 50,
                    Location = new Point(startX2, y2),
                    Size = new Size(250, 25),
                    MaximumSize = new Size(250, 25),
                    MinimumSize = new Size(250, 25)
                };

                tabPage3.Controls.Add(seatLbl);
                tabPage3.Controls.Add(inputTF);
                y1 += 45;
                y2 += 45;
            }
        }

        private void showSummaryBtn_Click(object sender, EventArgs e)
        {
            tab4 = true;
            tabControl1.SelectedTab = tabPage4;

            Random random = new Random();

            using (var context = new AppDbContext())
            {
                var lastSelectedMovie = context.Movies
                    .Where(m => m.Id == selectedMovie)
                    .Select(m => new Movie
                    {
                         Id = m.Id,
                         Title = m.Title,
                         Thumbnail = m.Thumbnail,
                         Genre = m.Genre,
                         Duration = m.Duration,
                         ImdbRating = m.ImdbRating,
                         Sessions = m.Sessions,
                    })
                    .FirstOrDefault();

                selectedMovie = lastSelectedMovie.Id;
                movieTitleLbl.Text = lastSelectedMovie.Title;
                imdbRatingLbl.Text = lastSelectedMovie.ImdbRating.ToString();
                movieThumbnail.Image = Image.FromFile(lastSelectedMovie.Thumbnail);

                var lastSelectedSession = context.Sessions
                    .Where(s => s.Id == selectedSession)
                    .Select(s => new Session
                    {
                        Id = s.Id,
                        Date = s.Date,
                        Features = s.Features,
                        Duration = s.Duration,
                        AssignedMovieId = s.AssignedMovieId,
                        AssignedMovie = s.AssignedMovie,
                        AssignedHallId = s.AssignedHallId,
                        AssignedHall = s.AssignedHall,
                    })
                    .FirstOrDefault();

                selectedSession = lastSelectedSession.Id;
                selectedHall = lastSelectedSession.AssignedHall.Id;
                dateLbl.Text = lastSelectedSession.Date.ToString("dd MMMM");
                timeLbl.Text = lastSelectedSession.Date.ToString("HH:mm");
                seatsLbl.Text = string.Join(", ", selectedSeats);
                hallLbl.Text = lastSelectedSession.AssignedHall.Name;

                do
                {
                    newId = random.Next(10000, 100000);
                }
                while (context.Reservations.Any(r => r.Id == newId));

                idLbl.Text = "#" + newId.ToString();
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabPage2)
            {
                if (tab2 == false) { e.Cancel = true; }
            }
            else if (e.TabPage == tabPage3)
            {
                if (tab3 == false) { e.Cancel = true; }
            }
            else if (e.TabPage == tabPage4)
            {
                if (tab4 == false) { e.Cancel = true; }
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle rectangle = tabControl1.ClientRectangle;

            StringFormat StrFormat = new StringFormat();
            StrFormat.LineAlignment = StringAlignment.Center;
            StrFormat.Alignment = StringAlignment.Center;

            SolidBrush backColor = new SolidBrush(Color.FromArgb(13, 14, 20));
            SolidBrush fontColor;

            e.Graphics.FillRectangle(backColor, rectangle);
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(16, 17, 23), 10), tabPage1.Bounds);

            Font fntTab = e.Font;
            Brush bshBack = new SolidBrush(Color.FromArgb(16, 17, 23));

            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                bool bSelected = (tabControl1.SelectedIndex == i);
                Rectangle recBounds = tabControl1.GetTabRect(i);
                RectangleF tabTextArea = (RectangleF)tabControl1.GetTabRect(i);
                if (bSelected)
                {
                    e.Graphics.FillRectangle(bshBack, recBounds);
                    fontColor = new SolidBrush(Color.White);
                    e.Graphics.DrawString(tabControl1.TabPages[i].Text, fntTab, fontColor, tabTextArea, StrFormat);
                }
                else
                {
                    fontColor = new SolidBrush(Color.Silver);
                    e.Graphics.DrawString(tabControl1.TabPages[i].Text, fntTab, fontColor, tabTextArea, StrFormat);
                }
            }
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

        private void copyButton_Click(object sender, EventArgs e)
        {
            string copyText = $"Ticket ID: {idLbl.Text}, Movie: {movieTitleLbl.Text}, Date: {dateLbl.Text}, Time: {timeLbl.Text}, Seat(s): {seatsLbl.Text}, Hall: {hallLbl.Text}.";
            Clipboard.SetText(copyText);
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

        public void ReservationForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        public void ReservationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        public void ReservationForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
