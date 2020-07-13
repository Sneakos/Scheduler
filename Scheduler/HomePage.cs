using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class HomePage : Form
    {
        private List<Task> tasks;

        public HomePage()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            LoadTasks();

            SetupTaskGrid();
        }

        #region Events

        private void HomePage_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void HomePage_Resize(object sender, EventArgs e)
        {
            lblTodaysTasks.AlignLabelToScreenHorizontally(HorizontalAlignment.Center);
        }

        private void toolStripMenuItemComplete_Click(object sender, EventArgs e)
        {
            Task selectedTask = (Task)gridTasks.SelectedRows[0].DataBoundItem;

            selectedTask.Completed = true;

            if (selectedTask.Recurring)
            {
                Task newTask = Task.CreateNewTask(selectedTask);
                tasks.Add(newTask);
            }

            SetupTaskGrid();

            SaveTasks();
        }

        private void toolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            Task selectedTask = (Task)gridTasks.SelectedRows[0].DataBoundItem;

            AddTask addTask = new AddTask(selectedTask);

            if (addTask.ShowDialog() == DialogResult.OK)
            {
                SetupTaskGrid();
            }
        }

        private void gridTasks_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            gridTasks.ClearSelection();
            int rowSelected = e.RowIndex;

            if (e.RowIndex != -1)
            {
                gridTasks.Rows[rowSelected].Selected = true;
            }
            e.ContextMenuStrip = cmsTaskActions;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();

            if (addTask.ShowDialog() == DialogResult.OK)
            {
                Task addedTask = addTask.AddedTask;
                tasks.Add(addedTask);

                SetupTaskGrid();
            }
        }

        private void cbOwner_CheckedChanged(object sender, EventArgs e)
        {
            SetupTaskGrid();
        }

        #endregion Events

        #region Helper Methods

        public void SetupTaskGrid()
        {
            gridTasks.DataSource = tasks.Where(x => x.DueDate.Date <= DateTime.Now.Date && x.Completed == false)
                                        .Where(x => (cbAlex.Checked && x.OwnedBy == People.Alex) ||
                                                    (cbJessica.Checked && x.OwnedBy == People.Jessica) ||
                                                    (cbSeth.Checked && x.OwnedBy == People.Seth))
                                        .OrderBy(x => x.DueDate)
                                        .ThenBy(x => x.OwnedBy)
                                        .ToList();

            gridTasks.Columns["DaysBetween"].Visible = false;
            gridTasks.Columns["Completed"].Visible = false;
            gridTasks.Columns["Recurring"].Visible = false;
            gridTasks.Columns["Alternate"].Visible = false;

            gridTasks.Columns["OwnedBy"].DisplayIndex = 0;
            gridTasks.Columns["Text"].DisplayIndex = 1;
            gridTasks.Columns["DueDate"].DisplayIndex = 2;

            gridTasks.Columns["OwnedBy"].HeaderText = "Owned By";
            gridTasks.Columns["Text"].HeaderText = "Task";
            gridTasks.Columns["DueDate"].HeaderText = "Date Due";

            gridTasks.Columns["OwnedBy"].Width = gridTasks.Width / 4;
            gridTasks.Columns["Text"].Width = (gridTasks.Width / 4) * 2;
            gridTasks.Columns["DueDate"].Width = gridTasks.Width / 4;

            foreach(DataGridViewRow row in gridTasks.Rows)
            {
                DataGridViewCell ownedByCell = row.Cells["OwnedBy"];
                DataGridViewCell dueDateCell = row.Cells["DueDate"];

                if ((People)ownedByCell.Value == People.Alex)
                {
                    ownedByCell.Style.BackColor = cbAlex.ForeColor;
                }
                else if ((People)ownedByCell.Value == People.Jessica)
                {
                    ownedByCell.Style.BackColor = cbJessica.ForeColor;
                }
                else
                {
                    ownedByCell.Style.BackColor = cbSeth.ForeColor;
                }

                ownedByCell.Style.ForeColor = Color.White;
                ownedByCell.Style.SelectionBackColor = ownedByCell.Style.BackColor;
                ownedByCell.Style.SelectionForeColor = Color.White;

                if (((DateTime)dueDateCell.Value).Date < DateTime.Now.Date)
                {
                    dueDateCell.Style.BackColor = Color.Red;
                    dueDateCell.Style.SelectionBackColor = Color.Red;
                }
            }
        }

        #endregion Helper Methods

        #region File Methods

        private void LoadTasks()
        {
            string path = ConfigurationManager.AppSettings["TaskPath"];

            string[] lines = File.ReadAllLines(path);
            tasks = new List<Task>(lines.Length);

            foreach(string line in lines)
            {
                Task newTask = JsonConvert.DeserializeObject<Task>(line);
                tasks.Add(newTask);
            }
        }

        private void SaveTasks()
        {
            string path = ConfigurationManager.AppSettings["TaskPath"];
            string completedTaskPath = ConfigurationManager.AppSettings["CompletedTaskPath"];

            List<string> currentTasks = new List<string>(tasks.Count);
            List<string> completedTasks = new List<string>(tasks.Count);

            foreach (Task task in tasks)
            {
                string taskString = JsonConvert.SerializeObject(task).Replace("T00:00:00-05:00", "").Replace("T00:00:00", "");

                if (task.Completed)
                    completedTasks.Add(taskString);
                else
                    currentTasks.Add(taskString);
            }

            File.WriteAllLines(path, currentTasks);
            File.WriteAllLines(completedTaskPath, completedTasks);
        }

        #endregion File Methods
    }
}
