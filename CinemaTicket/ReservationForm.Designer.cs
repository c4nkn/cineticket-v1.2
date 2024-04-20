namespace CinemaTicket
{
    partial class ReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.forMovie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.getSeatsBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.getDetailsBtn = new System.Windows.Forms.Button();
            this.lblSelectedSeats = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.showSummaryBtn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.imdbRatingLbl = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.movieTitleLbl = new System.Windows.Forms.Label();
            this.movieThumbnail = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.idLbl = new System.Windows.Forms.Label();
            this.hallLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.seatsLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Features = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 30);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.minimizeButton.ForeColor = System.Drawing.Color.DarkGray;
            this.minimizeButton.Location = new System.Drawing.Point(829, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(35, 30);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.Text = "―";
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Firebrick;
            this.closeButton.Location = new System.Drawing.Point(864, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(36, 30);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "✖";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 30);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(82, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 600);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.forMovie);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.getSeatsBtn);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(892, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select Session";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(377, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "developed by can with ❤";
            // 
            // forMovie
            // 
            this.forMovie.AutoSize = true;
            this.forMovie.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.forMovie.Location = new System.Drawing.Point(437, 48);
            this.forMovie.Name = "forMovie";
            this.forMovie.Size = new System.Drawing.Size(18, 19);
            this.forMovie.TabIndex = 3;
            this.forMovie.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(389, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Sessions";
            // 
            // getSeatsBtn
            // 
            this.getSeatsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getSeatsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.getSeatsBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.getSeatsBtn.Location = new System.Drawing.Point(28, 468);
            this.getSeatsBtn.Name = "getSeatsBtn";
            this.getSeatsBtn.Size = new System.Drawing.Size(836, 42);
            this.getSeatsBtn.TabIndex = 1;
            this.getSeatsBtn.Text = "Continue";
            this.getSeatsBtn.UseVisualStyleBackColor = true;
            this.getSeatsBtn.Click += new System.EventHandler(this.GetSeatsBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle57.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle57.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle57.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle57;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.Duration,
            this.Features,
            this.Availability});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle58.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle58.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle58;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(28, 84);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle59.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle59.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle59;
            dataGridViewCellStyle60.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle60;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(836, 355);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.getDetailsBtn);
            this.tabPage2.Controls.Add(this.lblSelectedSeats);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(892, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Select Seat(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(377, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "developed by can with ❤";
            // 
            // getDetailsBtn
            // 
            this.getDetailsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getDetailsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.getDetailsBtn.ForeColor = System.Drawing.Color.DimGray;
            this.getDetailsBtn.Location = new System.Drawing.Point(28, 468);
            this.getDetailsBtn.Name = "getDetailsBtn";
            this.getDetailsBtn.Size = new System.Drawing.Size(836, 42);
            this.getDetailsBtn.TabIndex = 4;
            this.getDetailsBtn.Text = "Continue";
            this.getDetailsBtn.UseVisualStyleBackColor = true;
            this.getDetailsBtn.Click += new System.EventHandler(this.getDetailsBtn_Click);
            // 
            // lblSelectedSeats
            // 
            this.lblSelectedSeats.AutoSize = true;
            this.lblSelectedSeats.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSelectedSeats.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSelectedSeats.Location = new System.Drawing.Point(353, 436);
            this.lblSelectedSeats.Name = "lblSelectedSeats";
            this.lblSelectedSeats.Size = new System.Drawing.Size(187, 20);
            this.lblSelectedSeats.TabIndex = 3;
            this.lblSelectedSeats.Text = "You didn\'t choose any seat.";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(134, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(625, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "s c r e e n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.showSummaryBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(892, 556);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Details";
            // 
            // showSummaryBtn
            // 
            this.showSummaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSummaryBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.showSummaryBtn.Location = new System.Drawing.Point(318, 460);
            this.showSummaryBtn.Name = "showSummaryBtn";
            this.showSummaryBtn.Size = new System.Drawing.Size(257, 40);
            this.showSummaryBtn.TabIndex = 5;
            this.showSummaryBtn.Text = "Continue";
            this.showSummaryBtn.UseVisualStyleBackColor = true;
            this.showSummaryBtn.Click += new System.EventHandler(this.showSummaryBtn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.imdbRatingLbl);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.movieTitleLbl);
            this.tabPage4.Controls.Add(this.movieThumbnail);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.idLbl);
            this.tabPage4.Controls.Add(this.hallLbl);
            this.tabPage4.Controls.Add(this.dateLbl);
            this.tabPage4.Controls.Add(this.timeLbl);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.seatsLbl);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(892, 556);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Summary";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label18.Location = new System.Drawing.Point(356, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(177, 25);
            this.label18.TabIndex = 23;
            this.label18.Text = "Reservation Details";
            // 
            // imdbRatingLbl
            // 
            this.imdbRatingLbl.AutoSize = true;
            this.imdbRatingLbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.imdbRatingLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imdbRatingLbl.Location = new System.Drawing.Point(317, 140);
            this.imdbRatingLbl.Name = "imdbRatingLbl";
            this.imdbRatingLbl.Size = new System.Drawing.Size(28, 19);
            this.imdbRatingLbl.TabIndex = 22;
            this.imdbRatingLbl.Text = "0.0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.DarkOrange;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.Location = new System.Drawing.Point(272, 142);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 15);
            this.label20.TabIndex = 21;
            this.label20.Text = "IMDB";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movieTitleLbl
            // 
            this.movieTitleLbl.AutoSize = true;
            this.movieTitleLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.movieTitleLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.movieTitleLbl.Location = new System.Drawing.Point(266, 107);
            this.movieTitleLbl.Name = "movieTitleLbl";
            this.movieTitleLbl.Size = new System.Drawing.Size(124, 25);
            this.movieTitleLbl.TabIndex = 18;
            this.movieTitleLbl.Text = "Movie Name";
            // 
            // movieThumbnail
            // 
            this.movieThumbnail.Location = new System.Drawing.Point(73, 107);
            this.movieThumbnail.Name = "movieThumbnail";
            this.movieThumbnail.Size = new System.Drawing.Size(167, 203);
            this.movieThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.movieThumbnail.TabIndex = 17;
            this.movieThumbnail.TabStop = false;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(198, 460);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 45);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(652, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 45);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(377, 540);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "developed by can with ❤";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(246, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Pay Now";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.idLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.idLbl.Location = new System.Drawing.Point(68, 357);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(67, 25);
            this.idLbl.TabIndex = 12;
            this.idLbl.Text = "#0000";
            // 
            // hallLbl
            // 
            this.hallLbl.AutoSize = true;
            this.hallLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.hallLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.hallLbl.Location = new System.Drawing.Point(754, 357);
            this.hallLbl.Name = "hallLbl";
            this.hallLbl.Size = new System.Drawing.Size(67, 25);
            this.hallLbl.TabIndex = 11;
            this.hallLbl.Text = "XYZ-1";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.dateLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.dateLbl.Location = new System.Drawing.Point(229, 357);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(82, 25);
            this.dateLbl.TabIndex = 10;
            this.dateLbl.Text = "01 April";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.timeLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.timeLbl.Location = new System.Drawing.Point(402, 357);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(84, 25);
            this.timeLbl.TabIndex = 8;
            this.timeLbl.Text = "0:00 pm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label13.Location = new System.Drawing.Point(405, 345);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 12);
            this.label13.TabIndex = 7;
            this.label13.Text = "T I M E";
            // 
            // seatsLbl
            // 
            this.seatsLbl.AutoSize = true;
            this.seatsLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.seatsLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.seatsLbl.Location = new System.Drawing.Point(579, 357);
            this.seatsLbl.Name = "seatsLbl";
            this.seatsLbl.Size = new System.Drawing.Size(36, 25);
            this.seatsLbl.TabIndex = 5;
            this.seatsLbl.Text = "A1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(71, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "I D ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(757, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "H A L L";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(582, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "S E A T S";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(232, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "D A T E ";
            // 
            // ID
            // 
            this.ID.HeaderText = "#";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Duration
            // 
            this.Duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            // 
            // Features
            // 
            this.Features.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Features.HeaderText = "Features";
            this.Features.Name = "Features";
            // 
            // Availability
            // 
            this.Availability.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Availability.HeaderText = "Availability";
            this.Availability.Name = "Availability";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(300, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(324, 19);
            this.label12.TabIndex = 8;
            this.label12.Text = "Please enter your names for each seat you selected.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(389, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(385, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Select seat(s)";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(900, 632);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineTicket";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieThumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label minimizeButton;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label forMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getSeatsBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSelectedSeats;
        private System.Windows.Forms.Button getDetailsBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label seatsLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label hallLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label movieTitleLbl;
        private System.Windows.Forms.PictureBox movieThumbnail;
        private System.Windows.Forms.Label imdbRatingLbl;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button showSummaryBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Features;
        private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
    }
}