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
        public int selectedMovie, selectedSession, selectedHall;
        bool tab2, tab3, tab4, isSessionSelected = false;

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

            int startX1 = 259;
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
                    BorderStyle = BorderStyle.FixedSingle,
                    MaxLength = 50,
                    Location = new Point(startX2, y2),
                    Size = new Size(250, 30),
                    MaximumSize = new Size(250, 30),
                    MinimumSize = new Size(250, 30)
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

            using (var context = new AppDbContext())
            {
                var lastSelectedMovie = context.Movies
                    .Where(m => m.Id == selectedMovie)
                    .Select(m => new Movie
                    {
                         Title = m.Title,
                         Thumbnail = m.Thumbnail,
                         Genre = m.Genre,
                         Duration = m.Duration,
                         ImdbRating = m.ImdbRating,
                         Sessions = m.Sessions,
                    })
                    .FirstOrDefault();

                movieTitleLbl.Text = lastSelectedMovie.Title;
                imdbRatingLbl.Text = lastSelectedMovie.ImdbRating.ToString();
                movieThumbnail.Image = Image.FromFile(lastSelectedMovie.Thumbnail);

                var lastSelectedSession = context.Sessions
                    .Where(s => s.Id == selectedSession)
                    .Select(s => new Session
                    {
                        Date = s.Date,
                        Features = s.Features,
                        Duration = s.Duration,
                        AssignedMovieId = s.AssignedMovieId,
                        AssignedMovie = s.AssignedMovie,
                        AssignedHallId = s.AssignedHallId,
                        AssignedHall = s.AssignedHall,
                    })
                    .FirstOrDefault();

                dateLbl.Text = lastSelectedSession.Date.ToString("dd MMMM");
                timeLbl.Text = lastSelectedSession.Date.ToString("HH:mm");
                seatsLbl.Text = string.Join(", ", selectedSeats);
                hallLbl.Text = lastSelectedSession.AssignedHall.Name;
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
    }
}
