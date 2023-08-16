using System;
using System.Data;
using System.Windows.Forms;

namespace ToDo_APP
{
    public partial class ToDoList : Form
    {
        private TodoContext _dbContext;
        
        public ToDoList()
        {
            InitializeComponent();
            _dbContext = new TodoContext();
        }

        bool isEditing = false;
        DataTable toDoList = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            toDoList.Columns.Add("Title");
            toDoList.Columns.Add("Description");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            Textbox.Text = "";
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            isEditing = true;
            int rowIndex = ToDoListView.CurrentCell.RowIndex;
            titleTextBox.Text = toDoList.Rows[rowIndex]["Title"].ToString();
            Textbox.Text = toDoList.Rows[rowIndex]["Description"].ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = ToDoListView.CurrentCell.RowIndex;
                toDoList.Rows.RemoveAt(rowIndex);
                ToDoListView.DataSource = toDoList; // Update the data source of the DataGridView
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
  

        private void Save_Click(object sender, EventArgs e)
        {
            void SaveTodoItem()
            {
                string title = titleTextBox.Text;
                string description = Textbox.Text;

                if (isEditing)
                {
                    // Editing an existing item
                    int rowIndex = ToDoListView.CurrentCell.RowIndex;
                    int todoItemId = (int)ToDoListView.Rows[rowIndex].Cells["Id"].Value;

                    TodoItem existingItem = _dbContext.TodoItems.Find(todoItemId);
                    if (existingItem != null)
                    {
                        existingItem.Title = title;
                        existingItem.Description = description;
                        _dbContext.SaveChanges();
                    }
                }
                else
                {
                    // Adding a new item
                    TodoItem newItem = new TodoItem
                    {
                        Title = title,
                        Description = description,
                        DueDate = DateTime.Now
                    };

                    _dbContext.TodoItems.Add(newItem);
                    _dbContext.SaveChanges();
                }

                //LoadTodoItems(); // Reload the todo items in the grid view
                //ClearFields();
                isEditing = false;
            }
            SaveTodoItem();

            titleTextBox.Text = "";
            Textbox.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle cell content click event if needed
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click event if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click event if needed
        }
    }
}