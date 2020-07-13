using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class AddTask : Form
    {
        public Task AddedTask { get; set; }

        public AddTask()
        {
            InitializeComponent();

            AddedTask = new Task();

            SetupOwnerCB();
        }

        public AddTask(Task currTask)
        {
            AddedTask = currTask;
            Text = "Edit Task";

            InitializeComponent();

            SetupOwnerCB();

            txtTaskTitle.Text = AddedTask.Text;
            dtpDueDate.Value = AddedTask.DueDate;
            cbAlternate.Checked = AddedTask.Alternate;
            numericDaysBetween.Value = AddedTask.DaysBetween;
            cbRecurring.Checked = AddedTask.Recurring;
            cmbOwner.SelectedValue = AddedTask.OwnedBy;
        }

        public void SetupOwnerCB()
        {
            List<People> list = Enum.GetValues(typeof(People)).Cast<People>().ToList();

            var result = list.Select(x => new
            {
                Person = x,
                Name = x.ToString()
            }).ToList();

            cmbOwner.DataSource = result;
            cmbOwner.DisplayMember = "Name";
            cmbOwner.ValueMember = "Person";

            cmbOwner.SelectedIndex = 0;
        }

        private void cbRecurring_CheckedChanged(object sender, EventArgs e)
        {
            cbAlternate.Enabled = cbRecurring.Checked;
            cbAlternate.Visible = cbRecurring.Checked;
            lblDaysBetween.Visible = cbRecurring.Checked;
            numericDaysBetween.Visible = cbRecurring.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbAlternate.Visible)
                AddedTask.Alternate = cbAlternate.Checked;

            if (numericDaysBetween.Visible)
                AddedTask.DaysBetween = (int)numericDaysBetween.Value;

            AddedTask.DueDate = dtpDueDate.Value;
            //AddedTask.OwnedBy = 
        }
    }
}
