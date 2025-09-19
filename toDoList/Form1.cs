using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.Json;

namespace toDoList
{
    public partial class toDoList : Form
    {
        private int index = 0;
        private List<List> totalLists = new List<List>();
        private Timer deadlineTimer;
        private HashSet<string> notifiedLists = new HashSet<string>();

        public toDoList()
        {
            InitializeComponent();
            InitializeListViewColumns();
            InitializeTimer();
            LoadListsFromFile();
            poplutelstViewLists();
        }

        private void InitializeListViewColumns()//Charles
        {
            lstViewLists.Columns.Clear();
            lstViewLists.Columns.Add("Name", 150);
            lstViewLists.Columns.Add("Priority", 80);
            lstViewLists.Columns.Add("Time Remaining", 120);
        }

        private void InitializeTimer()//Charles
        {
            deadlineTimer = new Timer { Interval = 60000 };
            deadlineTimer.Tick += (s, e) =>
            {
                poplutelstViewLists();
                CheckDeadlines();
            };
            deadlineTimer.Start();
        }

        private void btnListSave_Click(object sender, EventArgs e)//Jake
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a list name");
                return;
            }

            int priority = cmbSetPriority.SelectedIndex == -1 ? 5 : 5 - cmbSetPriority.SelectedIndex;
            var newList = new List(txtName.Text, priority);

            foreach (var item in lstBListItems.Items)
            {
                newList.addItems(new Item(item.ToString()));
            }

            totalLists.Add(newList);
            ResetListCreationFields();
            poplutelstViewLists();
        }

        private void ResetListCreationFields()//Charles
        {
            txtName.Clear();
            cmbSetPriority.SelectedIndex = -1;
            lstBListItems.Items.Clear();
            index = 0;
            MessageBox.Show("New List Created");
        }

        private void addNewItem_Click(object sender, EventArgs e)//Charles
        {
            if (string.IsNullOrWhiteSpace(rtbAdd.Text))
            {
                MessageBox.Show("Please add item");
                return;
            }

            lstBListItems.Items.Add($"{++index}.{rtbAdd.Text}");
            rtbAdd.Clear();
        }

        public void poplutelstViewLists()//Jake/Charles
        {
            lstViewLists.BeginUpdate();
            lstViewLists.Items.Clear();

            foreach (var list in totalLists)
            {
                var item = new ListViewItem(list.Name);
                item.SubItems.Add(list.Priority.ToString());
                item.SubItems.Add(GetDeadlineStatus(list));
                item.Tag = list;
                lstViewLists.Items.Add(item);
            }

            lstViewLists.EndUpdate();
        }

        private string GetDeadlineStatus(List list)//Charles
        {
            if (!list.Deadline.HasValue) return "No deadline";

            var remaining = list.Deadline.Value - DateTime.Now;
            return remaining.TotalSeconds > 0
                ? $"{remaining.Days}d {remaining.Hours}h {remaining.Minutes}m"
                : "EXPIRED";
        }

        private void btnEdit_Click(object sender, EventArgs e)//Jake
        {
            if (lstViewLists.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a list");
                return;
            }

            var selectedList = (List)lstViewLists.SelectedItems[0].Tag;
            using (var editFrm = new editForm(selectedList, totalLists))
            {
                if (editFrm.ShowDialog() == DialogResult.OK)
                {
                    poplutelstViewLists(); 
                }
            }
        }

        private void btnDeadline_Click(object sender, EventArgs e)//Charles
        {
            if (lstViewLists.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a list first");
                return;
            }

            var selectedList = (List)lstViewLists.SelectedItems[0].Tag;
            using (var deadlineForm = new DeadlineForm())
            {
                if (deadlineForm.ShowDialog() == DialogResult.OK)
                {
                    selectedList.Deadline = deadlineForm.Deadline;
                    poplutelstViewLists();
                }
            }
        }

        protected override void OnShown(EventArgs e)//Charles
        {
            base.OnShown(e);
            notifiedLists.Clear();
            CheckDeadlines();
        }

        private void CheckDeadlines()//Charles
        {
            foreach (var list in totalLists.Where(l => l.Deadline.HasValue))
            {
                var remaining = list.Deadline.Value - DateTime.Now;
                var listKey = $"{list.Name}_{list.Deadline.Value.Ticks}";

                if (remaining.TotalSeconds <= 0 && !notifiedLists.Contains(listKey))
                {
                    ShowDeadlineAlert(list.Name, "Deadline passed!");
                    notifiedLists.Add(listKey);
                }
                else if (remaining.TotalHours < 24 && !notifiedLists.Contains(listKey))
                {
                    ShowDeadlineAlert(list.Name, $"{remaining.Days}d {remaining.Hours}h {remaining.Minutes}m remaining");
                    notifiedLists.Add(listKey);
                }
            }
        }

        private void ShowDeadlineAlert(string listName, string message)//Charles
        {
            MessageBox.Show($"List '{listName}': {message}",
                          "Deadline Notification",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)//Jake/Charles
        {
            if (lstViewLists.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a list to delete");
                return;
            }

            if (MessageBox.Show("Confirm deletion?", "Delete List",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var selectedList = (List)lstViewLists.SelectedItems[0].Tag;
                totalLists.Remove(selectedList);
                poplutelstViewLists();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)//Charles
        {
            SaveListsToFile();
            deadlineTimer?.Stop();
            base.OnFormClosing(e);
        }

        private void SaveListsToFile()//Jake
        {
                var json = System.Text.Json.JsonSerializer.Serialize(totalLists);
                System.IO.File.WriteAllText("lists.json", json); 
        }

        private void LoadListsFromFile()//Jake
        {
            if (System.IO.File.Exists("lists.json"))
            {
                var json = System.IO.File.ReadAllText("lists.json");
                totalLists = System.Text.Json.JsonSerializer.Deserialize<List<List>>(json);
            }
        }



        private void lstViewLists_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPriority_Click(object sender, EventArgs e)//Jake
        {
            totalLists = totalLists.OrderByDescending(list => list.Priority).ToList();
            poplutelstViewLists();
        }
    }
}