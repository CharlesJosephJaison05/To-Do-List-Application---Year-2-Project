using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toDoList
{
    public partial class editForm : Form
    {
        List l;
        List<List> tList;

  
        public editForm()
        {
            InitializeComponent();
            
        }

        public editForm(List l, List<List> tList)//Jake
        {
            InitializeComponent();
            this.l = l;
            this.tList = tList;
            populatetxtToDos();
            LoadCurrentPriority();
        }

        private void LoadCurrentPriority()//Charles
        {
          
            cmbPriority.SelectedIndex = 5 - l.Priority; 
        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void editForm_Load(object sender, EventArgs e)
        {
            
        }

        public void populatetxtToDos()//Jake
        {
            if (l != null && l.Items !=null)
            {
                txtToDos.Items.Clear();
                for (int i = 0; i < l.Items.Count; i++)
                {
                    var item = l.Items[i];
                    txtToDos.Items.Add($"{item.Description}"); 
                }
                
            }
            else
            {
                MessageBox.Show("No items in selected list");
            }
        }

        private void btnNewNewAdd_Click(object sender, EventArgs e)//Jake
        {
            string text = txtNew.Text;
            if (!string.IsNullOrEmpty(text))
            {

                int nextIndex = l.Items.Count + 1; 
                l.addItems(new Item($"{nextIndex}. {text}")); 
                populatetxtToDos();
                txtNew.Clear();
            }
            else
            {
                MessageBox.Show("Please enter new item");
            }
        }

        private void btnToDoDelete_Click(object sender, EventArgs e)//Jake
        {
            if (txtToDos.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to delete");
                return;
            }

            int selectedIndex = txtToDos.SelectedIndex;
            l.Items[selectedIndex].IsCompleted = true; 
            l.Items.RemoveAt(selectedIndex);
            txtToDos.Items.RemoveAt(selectedIndex);

            for (int i = 0; i < txtToDos.Items.Count; i++)
            {
                string currentItem = txtToDos.Items[i].ToString();
                int indexNumber = currentItem.IndexOf('.');
                string desc;

                if (indexNumber != -1 && indexNumber + 1 < currentItem.Length)
                {
                    desc = currentItem.Substring(indexNumber + 1).Trim();
                }
                else
                {
                    desc = currentItem;
                }

                txtToDos.Items[i] = $"{i + 1}. {desc}";
            }
            populatetxtToDos();
            

        }

        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)//Jake
        {
            if (cmbPriority.SelectedIndex != -1)
            {
               
                l.Priority = 5 - cmbPriority.SelectedIndex;
            }
        }

        private void txtNew_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)//Jake/Charles
        {

            if (cmbPriority.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a priority level");
                return;
            }
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Changes have been applied");
            this.Close();
        }

       
    
    }
}
