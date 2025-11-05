namespace MusicHub.WinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.artistsTabPage = new System.Windows.Forms.TabPage();
            this.artistsGridView = new System.Windows.Forms.DataGridView();
            this.bookingsTabPage = new System.Windows.Forms.TabPage();
            this.bookingsGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createBookingButton = new System.Windows.Forms.Button();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.bookedByTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resourceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resourcesTabPage = new System.Windows.Forms.TabPage();
            this.resourcesGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.artistsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistsGridView)).BeginInit();
            this.bookingsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.resourcesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.artistsTabPage);
            this.tabControl1.Controls.Add(this.bookingsTabPage);
            this.tabControl1.Controls.Add(this.resourcesTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // artistsTabPage
            // 
            this.artistsTabPage.Controls.Add(this.artistsGridView);
            this.artistsTabPage.Location = new System.Drawing.Point(4, 24);
            this.artistsTabPage.Name = "artistsTabPage";
            this.artistsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.artistsTabPage.Size = new System.Drawing.Size(792, 422);
            this.artistsTabPage.TabIndex = 0;
            this.artistsTabPage.Text = "Artists";
            this.artistsTabPage.UseVisualStyleBackColor = true;
            // 
            // artistsGridView
            // 
            this.artistsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artistsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artistsGridView.Location = new System.Drawing.Point(3, 3);
            this.artistsGridView.Name = "artistsGridView";
            this.artistsGridView.RowTemplate.Height = 25;
            this.artistsGridView.Size = new System.Drawing.Size(786, 416);
            this.artistsGridView.TabIndex = 0;
            // 
            // bookingsTabPage
            // 
            this.bookingsTabPage.Controls.Add(this.bookingsGridView);
            this.bookingsTabPage.Controls.Add(this.groupBox1);
            this.bookingsTabPage.Location = new System.Drawing.Point(4, 24);
            this.bookingsTabPage.Name = "bookingsTabPage";
            this.bookingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.bookingsTabPage.Size = new System.Drawing.Size(792, 422);
            this.bookingsTabPage.TabIndex = 1;
            this.bookingsTabPage.Text = "Bookings";
            this.bookingsTabPage.UseVisualStyleBackColor = true;
            // 
            // bookingsGridView
            // 
            this.bookingsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingsGridView.Location = new System.Drawing.Point(3, 173);
            this.bookingsGridView.Name = "bookingsGridView";
            this.bookingsGridView.RowTemplate.Height = 25;
            this.bookingsGridView.Size = new System.Drawing.Size(786, 246);
            this.bookingsGridView.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createBookingButton);
            this.groupBox1.Controls.Add(this.endDatePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.startDatePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bookedByTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.resourceComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Booking";
            // 
            // createBookingButton
            // 
            this.createBookingButton.Location = new System.Drawing.Point(300, 125);
            this.createBookingButton.Name = "createBookingButton";
            this.createBookingButton.Size = new System.Drawing.Size(121, 23);
            this.createBookingButton.TabIndex = 8;
            this.createBookingButton.Text = "Create Booking";
            this.createBookingButton.UseVisualStyleBackColor = true;
            this.createBookingButton.Click += new System.EventHandler(this.createBookingButton_Click);
            // 
            // endDatePicker
            // 
            this.endDatePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.Location = new System.Drawing.Point(80, 125);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 23);
            this.endDatePicker.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "End Time:";
            // 
            // startDatePicker
            // 
            this.startDatePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(80, 90);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 23);
            this.startDatePicker.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start Time:";
            // 
            // bookedByTextBox
            // 
            this.bookedByTextBox.Location = new System.Drawing.Point(80, 55);
            this.bookedByTextBox.Name = "bookedByTextBox";
            this.bookedByTextBox.Size = new System.Drawing.Size(200, 23);
            this.bookedByTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Booked By:";
            // 
            // resourceComboBox
            // 
            this.resourceComboBox.FormattingEnabled = true;
            this.resourceComboBox.Location = new System.Drawing.Point(80, 20);
            this.resourceComboBox.Name = "resourceComboBox";
            this.resourceComboBox.Size = new System.Drawing.Size(200, 23);
            this.resourceComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resource:";
            // 
            // resourcesTabPage
            // 
            this.resourcesTabPage.Controls.Add(this.resourcesGridView);
            this.resourcesTabPage.Location = new System.Drawing.Point(4, 24);
            this.resourcesTabPage.Name = "resourcesTabPage";
            this.resourcesTabPage.Size = new System.Drawing.Size(792, 422);
            this.resourcesTabPage.TabIndex = 2;
            this.resourcesTabPage.Text = "Resources";
            this.resourcesTabPage.UseVisualStyleBackColor = true;
            // 
            // resourcesGridView
            // 
            this.resourcesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resourcesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourcesGridView.Location = new System.Drawing.Point(0, 0);
            this.resourcesGridView.Name = "resourcesGridView";
            this.resourcesGridView.RowTemplate.Height = 25;
            this.resourcesGridView.Size = new System.Drawing.Size(792, 422);
            this.resourcesGridView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MusicHub Admin";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.artistsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.artistsGridView)).EndInit();
            this.bookingsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookingsGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.resourcesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resourcesGridView)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage artistsTabPage;
        private DataGridView artistsGridView;
        private TabPage bookingsTabPage;
        private DataGridView bookingsGridView;
        private GroupBox groupBox1;
        private Button createBookingButton;
        private DateTimePicker endDatePicker;
        private Label label4;
        private DateTimePicker startDatePicker;
        private Label label3;
        private TextBox bookedByTextBox;
        private Label label2;
        private ComboBox resourceComboBox;
        private Label label1;
        private TabPage resourcesTabPage;
        private DataGridView resourcesGridView;
    }
}
