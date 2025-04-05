namespace CuteToDoList_Practice
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            btnSave = new Button();
            btnNew = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            toDoListView = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)toDoListView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semilight", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(256, 22);
            label1.Name = "label1";
            label1.Size = new Size(176, 50);
            label1.TabIndex = 0;
            label1.Text = "To Do List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 119);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 183);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(45, 143);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(212, 27);
            txtTitle.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(45, 206);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(212, 27);
            txtDescription.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 192, 255);
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(94, 260);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 37);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(255, 192, 255);
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(327, 392);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(105, 37);
            btnNew.TabIndex = 6;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 192, 255);
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(464, 392);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(105, 37);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 255);
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(599, 392);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 37);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // toDoListView
            // 
            toDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toDoListView.BackgroundColor = SystemColors.ButtonHighlight;
            toDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toDoListView.Location = new Point(263, 119);
            toDoListView.Name = "toDoListView";
            toDoListView.RowHeadersWidth = 51;
            toDoListView.Size = new Size(498, 258);
            toDoListView.TabIndex = 9;
            toDoListView.CellContentClick += toDoListView_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(613, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(148, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(800, 463);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(toDoListView);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)toDoListView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private Button btnSave;
        private Button btnNew;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView toDoListView;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}