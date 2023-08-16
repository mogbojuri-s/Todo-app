namespace ToDo_APP
{
    partial class ToDoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            titleTextBox = new TextBox();
            Textbox = new TextBox();
            Textbox2 = new Label();
            label3 = new Label();
            NewButton = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            SaveButton = new Button();
            toDoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)toDoListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(832, 78);
            label1.TabIndex = 0;
            label1.Text = "ToDoList";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // titleTextBox
            // 
            titleTextBox.BackColor = SystemColors.HighlightText;
            titleTextBox.Location = new Point(12, 91);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(843, 31);
            titleTextBox.TabIndex = 1;
            // 
            // Textbox
            // 
            Textbox.Location = new Point(12, 164);
            Textbox.Name = "Textbox";
            Textbox.Size = new Size(843, 31);
            Textbox.TabIndex = 2;
            // 
            // Textbox2
            // 
            Textbox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Textbox2.Location = new Point(16, 125);
            Textbox2.Name = "Textbox2";
            Textbox2.Size = new Size(839, 36);
            Textbox2.TabIndex = 3;
            Textbox2.Text = "Description";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 61);
            label3.Name = "label3";
            label3.Size = new Size(839, 27);
            label3.TabIndex = 4;
            label3.Text = "Title";
            label3.Click += label3_Click;
            // 
            // NewButton
            // 
            NewButton.Location = new Point(12, 201);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(190, 34);
            NewButton.TabIndex = 5;
            NewButton.Text = "New";
            NewButton.UseVisualStyleBackColor = true;
           
            // 
            // EditButton
            // 
            EditButton.Location = new Point(231, 201);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(190, 34);
            EditButton.TabIndex = 6;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
         
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(446, 201);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(190, 34);
            DeleteButton.TabIndex = 7;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += Delete_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(660, 201);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(190, 34);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += Save_Click;
            // 
            // toDoListView
            // 
            toDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toDoListView.BackgroundColor = SystemColors.ControlLightLight;
            toDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toDoListView.Location = new Point(12, 252);
            toDoListView.Name = "toDoListView";
            toDoListView.RowHeadersWidth = 62;
            toDoListView.RowTemplate.Height = 33;
            toDoListView.Size = new Size(832, 225);
            toDoListView.TabIndex = 9;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(867, 489);
            Controls.Add(toDoListView);
            Controls.Add(SaveButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(NewButton);
            Controls.Add(label3);
            Controls.Add(Textbox2);
            Controls.Add(Textbox);
            Controls.Add(titleTextBox);
            Controls.Add(label1);
            Name = "ToDoList";
            Text = "ToDoList";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)toDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titleTextBox;
        private TextBox Textbox;
        private Label Textbox2;
        private Label label3;
        private Button NewButton;
        private Button EditButton;
        private Button DeleteButton;
        private Button SaveButton;
        private DataGridView ToDoListView;
        private DataGridView toDoListView;
    }
}