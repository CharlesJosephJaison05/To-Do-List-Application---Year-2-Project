namespace toDoList
{
    partial class toDoList
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabLists = new System.Windows.Forms.TabPage();
            this.btnPriority = new System.Windows.Forms.Button();
            this.lstViewLists = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTimeRemaining = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeadline = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tabCreate = new System.Windows.Forms.TabPage();
            this.addNewItem = new System.Windows.Forms.Button();
            this.btnListSave = new System.Windows.Forms.Button();
            this.rtbAdd = new System.Windows.Forms.RichTextBox();
            this.lblAddItem = new System.Windows.Forms.Label();
            this.cmbSetPriority = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lstBListItems = new System.Windows.Forms.ListBox();
            this.mainTabControl.SuspendLayout();
            this.tabLists.SuspendLayout();
            this.tabCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabLists);
            this.mainTabControl.Controls.Add(this.tabCreate);
            this.mainTabControl.Location = new System.Drawing.Point(24, 45);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(735, 393);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabLists
            // 
            this.tabLists.Controls.Add(this.btnPriority);
            this.tabLists.Controls.Add(this.lstViewLists);
            this.tabLists.Controls.Add(this.btnDeadline);
            this.tabLists.Controls.Add(this.btnDelete);
            this.tabLists.Controls.Add(this.btnEdit);
            this.tabLists.Location = new System.Drawing.Point(4, 22);
            this.tabLists.Name = "tabLists";
            this.tabLists.Padding = new System.Windows.Forms.Padding(3);
            this.tabLists.Size = new System.Drawing.Size(727, 367);
            this.tabLists.TabIndex = 0;
            this.tabLists.Text = "Lists";
            this.tabLists.UseVisualStyleBackColor = true;
            // 
            // btnPriority
            // 
            this.btnPriority.Location = new System.Drawing.Point(479, 294);
            this.btnPriority.Name = "btnPriority";
            this.btnPriority.Size = new System.Drawing.Size(135, 23);
            this.btnPriority.TabIndex = 5;
            this.btnPriority.Text = "Sort by priority";
            this.btnPriority.UseVisualStyleBackColor = true;
            this.btnPriority.Click += new System.EventHandler(this.btnPriority_Click);
            // 
            // lstViewLists
            // 
            this.lstViewLists.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnPriority,
            this.columnTimeRemaining});
            this.lstViewLists.FullRowSelect = true;
            this.lstViewLists.GridLines = true;
            this.lstViewLists.HideSelection = false;
            this.lstViewLists.Location = new System.Drawing.Point(5, 39);
            this.lstViewLists.Margin = new System.Windows.Forms.Padding(2);
            this.lstViewLists.Name = "lstViewLists";
            this.lstViewLists.Size = new System.Drawing.Size(353, 248);
            this.lstViewLists.TabIndex = 4;
            this.lstViewLists.UseCompatibleStateImageBehavior = false;
            this.lstViewLists.View = System.Windows.Forms.View.Details;
            this.lstViewLists.SelectedIndexChanged += new System.EventHandler(this.lstViewLists_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 150;
            // 
            // columnPriority
            // 
            this.columnPriority.Text = "Priority";
            this.columnPriority.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPriority.Width = 80;
            // 
            // columnTimeRemaining
            // 
            this.columnTimeRemaining.Text = "Time Remaining";
            this.columnTimeRemaining.Width = 120;
            // 
            // btnDeadline
            // 
            this.btnDeadline.Location = new System.Drawing.Point(479, 264);
            this.btnDeadline.Name = "btnDeadline";
            this.btnDeadline.Size = new System.Drawing.Size(135, 23);
            this.btnDeadline.TabIndex = 3;
            this.btnDeadline.Text = "Set Deadline";
            this.btnDeadline.UseVisualStyleBackColor = true;
            this.btnDeadline.Click += new System.EventHandler(this.btnDeadline_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(574, 39);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(466, 39);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tabCreate
            // 
            this.tabCreate.Controls.Add(this.addNewItem);
            this.tabCreate.Controls.Add(this.btnListSave);
            this.tabCreate.Controls.Add(this.rtbAdd);
            this.tabCreate.Controls.Add(this.lblAddItem);
            this.tabCreate.Controls.Add(this.cmbSetPriority);
            this.tabCreate.Controls.Add(this.label2);
            this.tabCreate.Controls.Add(this.txtName);
            this.tabCreate.Controls.Add(this.lblName);
            this.tabCreate.Controls.Add(this.lstBListItems);
            this.tabCreate.Location = new System.Drawing.Point(4, 22);
            this.tabCreate.Name = "tabCreate";
            this.tabCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreate.Size = new System.Drawing.Size(727, 367);
            this.tabCreate.TabIndex = 1;
            this.tabCreate.Text = "Create Lists";
            this.tabCreate.UseVisualStyleBackColor = true;
            // 
            // addNewItem
            // 
            this.addNewItem.Location = new System.Drawing.Point(432, 294);
            this.addNewItem.Name = "addNewItem";
            this.addNewItem.Size = new System.Drawing.Size(75, 23);
            this.addNewItem.TabIndex = 8;
            this.addNewItem.Text = "Add ";
            this.addNewItem.UseVisualStyleBackColor = true;
            this.addNewItem.Click += new System.EventHandler(this.addNewItem_Click);
            // 
            // btnListSave
            // 
            this.btnListSave.Location = new System.Drawing.Point(243, 320);
            this.btnListSave.Name = "btnListSave";
            this.btnListSave.Size = new System.Drawing.Size(75, 23);
            this.btnListSave.TabIndex = 7;
            this.btnListSave.Text = "Save";
            this.btnListSave.UseVisualStyleBackColor = true;
            this.btnListSave.Click += new System.EventHandler(this.btnListSave_Click);
            // 
            // rtbAdd
            // 
            this.rtbAdd.Location = new System.Drawing.Point(432, 192);
            this.rtbAdd.Name = "rtbAdd";
            this.rtbAdd.Size = new System.Drawing.Size(261, 96);
            this.rtbAdd.TabIndex = 6;
            this.rtbAdd.Text = "";
            // 
            // lblAddItem
            // 
            this.lblAddItem.AutoSize = true;
            this.lblAddItem.Location = new System.Drawing.Point(432, 164);
            this.lblAddItem.Name = "lblAddItem";
            this.lblAddItem.Size = new System.Drawing.Size(52, 13);
            this.lblAddItem.TabIndex = 5;
            this.lblAddItem.Text = "Add Item:";
            // 
            // cmbSetPriority
            // 
            this.cmbSetPriority.FormattingEnabled = true;
            this.cmbSetPriority.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.cmbSetPriority.Location = new System.Drawing.Point(432, 123);
            this.cmbSetPriority.Name = "cmbSetPriority";
            this.cmbSetPriority.Size = new System.Drawing.Size(121, 21);
            this.cmbSetPriority.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Set Priority:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(432, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(429, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lstBListItems
            // 
            this.lstBListItems.FormattingEnabled = true;
            this.lstBListItems.Location = new System.Drawing.Point(66, 50);
            this.lstBListItems.Name = "lstBListItems";
            this.lstBListItems.Size = new System.Drawing.Size(252, 264);
            this.lstBListItems.TabIndex = 0;
            // 
            // toDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTabControl);
            this.Name = "toDoList";
            this.Text = "toDoList";
            this.mainTabControl.ResumeLayout(false);
            this.tabLists.ResumeLayout(false);
            this.tabCreate.ResumeLayout(false);
            this.tabCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabLists;
        private System.Windows.Forms.TabPage tabCreate;
        private System.Windows.Forms.Button btnDeadline;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        //private System.Windows.Forms.ListView lstViewLists;
        //private System.Windows.Forms.ColumnHeader columnName;
        //private System.Windows.Forms.ColumnHeader columnPriority;
        private System.Windows.Forms.Button btnListSave;
        private System.Windows.Forms.RichTextBox rtbAdd;
        private System.Windows.Forms.Label lblAddItem;
        private System.Windows.Forms.ComboBox cmbSetPriority;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lstBListItems;
        private System.Windows.Forms.Button addNewItem;
        //private System.Windows.Forms.ColumnHeader columnCompletion;
        private System.Windows.Forms.ListView lstViewLists;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPriority;
        private System.Windows.Forms.ColumnHeader columnTimeRemaining;
        private System.Windows.Forms.Button btnPriority;
        //private System.Windows.Forms.ListView lstView;
    }
}

