using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuteToDoList_Practice
{
    
    
    public partial class Form2 : Form
    {
        private const string filepath = "C:/Visual Studio IDE/Side Projects/CuteToDoList_Practice/ToDoList_Storage.txt";
        public Form2()
        {
            InitializeComponent();
        }
        DataTable toDoList = new DataTable(); //Will store data in colunms, will be used for data grid view;
        bool isEditing = false; //Track when things are being edited or not;
        private void Form2_Load(object sender, EventArgs e)
        {
            //Create columns
            toDoList.Columns.Add("Title");
            toDoList.Columns.Add("Description");

            //Point data grid view to data source
            toDoListView.DataSource = toDoList;
            LoadFromFile();
        }

        private void LoadFromFile()
        {
            if (File.Exists(filepath))
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Split into title and description
                        var parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            toDoList.Rows.Add(parts[0], parts[1]);
                        }
                    }
                }
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            
                if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Please fill in the required fields.", "Error");
                    return;
                }

                if (isEditing)
                {
                    toDoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = txtTitle.Text;
                    toDoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"] = txtDescription.Text;
                }
                else
                {
                    toDoList.Rows.Add(txtTitle.Text, txtDescription.Text);
                
                }

                SaveToFile();

                //Clear fields
                txtTitle.Text = "";
                txtDescription.Text = "";
                isEditing = false;         
          

        }
        
        private void SaveToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filepath))
                {
                    foreach (DataRow row in toDoList.Rows)
                    {
                        writer.WriteLine($"{row["Title"]}, {row["Description"]}");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("ERROR: File Not Found");
            }
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {//Basically just clear text boxes
            txtDescription.Clear();
            txtTitle.Clear();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            isEditing = true;
            //Fill text fields with data from table           
            txtTitle.Text = toDoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            txtDescription.Text = toDoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                toDoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
                SaveToFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
            
        
        }

        private void toDoListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

