namespace toDoList
{
    partial class editForm
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
            this.btnAdd = new System.Windows.Forms.Label();
            this.txtNew = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToDos = new System.Windows.Forms.ListBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnToDoDelete = new System.Windows.Forms.Button();
            this.btnNewNewAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(581, 55);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 16);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add New Item:";
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(585, 75);
            this.txtNew.Margin = new System.Windows.Forms.Padding(4);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(317, 117);
            this.txtNew.TabIndex = 2;
            this.txtNew.Text = "";
            this.txtNew.TextChanged += new System.EventHandler(this.txtNew_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Set Priority:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtToDos
            // 
            this.txtToDos.FormattingEnabled = true;
            this.txtToDos.ItemHeight = 16;
            this.txtToDos.Location = new System.Drawing.Point(65, 86);
            this.txtToDos.Margin = new System.Windows.Forms.Padding(4);
            this.txtToDos.Name = "txtToDos";
            this.txtToDos.Size = new System.Drawing.Size(373, 388);
            this.txtToDos.TabIndex = 4;
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.cmbPriority.Location = new System.Drawing.Point(585, 277);
            this.cmbPriority.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(160, 24);
            this.cmbPriority.TabIndex = 5;
            this.cmbPriority.SelectedIndexChanged += new System.EventHandler(this.cmbPriority_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(65, 482);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnToDoDelete
            // 
            this.btnToDoDelete.Location = new System.Drawing.Point(340, 482);
            this.btnToDoDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnToDoDelete.Name = "btnToDoDelete";
            this.btnToDoDelete.Size = new System.Drawing.Size(100, 28);
            this.btnToDoDelete.TabIndex = 7;
            this.btnToDoDelete.Text = "Delete";
            this.btnToDoDelete.UseVisualStyleBackColor = true;
            this.btnToDoDelete.Click += new System.EventHandler(this.btnToDoDelete_Click);
            // 
            // btnNewNewAdd
            // 
            this.btnNewNewAdd.Location = new System.Drawing.Point(585, 202);
            this.btnNewNewAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewNewAdd.Name = "btnNewNewAdd";
            this.btnNewNewAdd.Size = new System.Drawing.Size(100, 28);
            this.btnNewNewAdd.TabIndex = 8;
            this.btnNewNewAdd.Text = "Add";
            this.btnNewNewAdd.UseVisualStyleBackColor = true;
            this.btnNewNewAdd.Click += new System.EventHandler(this.btnNewNewAdd_Click);
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnNewNewAdd);
            this.Controls.Add(this.btnToDoDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.txtToDos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "editForm";
            this.Text = "editForm";
            this.Load += new System.EventHandler(this.editForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnAdd;
        private System.Windows.Forms.RichTextBox txtNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox txtToDos;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnToDoDelete;
        private System.Windows.Forms.Button btnNewNewAdd;
    }
}