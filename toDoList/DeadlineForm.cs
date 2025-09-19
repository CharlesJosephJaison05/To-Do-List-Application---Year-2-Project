using System;
using System.Windows.Forms;

namespace toDoList
{
    public partial class DeadlineForm : Form
    {
        public DateTime Deadline { get; private set; }

        public DeadlineForm()
        {
            InitializeComponent();
            InitializeDateTimePickers();
        }

        private void InitializeDateTimePickers()
        {
            // Date picker setup
            dtpDate.MinDate = DateTime.Today;
            dtpDate.Value = DateTime.Today;

            // Time picker setup
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.ShowUpDown = true;
            dtpTime.Value = DateTime.Now.AddHours(1).Date.AddHours(DateTime.Now.Hour + 1);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            Deadline = dtpDate.Value.Date.Add(dtpTime.Value.TimeOfDay);

            // Validate future time (with 1-minute buffer)
            if (Deadline <= DateTime.Now.AddMinutes(1))
            {
                MessageBox.Show("Please select a time at least 1 minute in the future",
                              "Invalid Deadline",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}