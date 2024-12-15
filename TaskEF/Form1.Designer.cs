namespace TaskEF
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            nametextBox = new TextBox();
            desctextBox = new TextBox();
            label2 = new Label();
            categorytextBox = new TextBox();
            label3 = new Label();
            Add = new Button();
            Delete = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            update = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(311, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(463, 359);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 34);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // nametextBox
            // 
            nametextBox.Location = new Point(24, 57);
            nametextBox.Name = "nametextBox";
            nametextBox.Size = new Size(228, 27);
            nametextBox.TabIndex = 2;
            // 
            // desctextBox
            // 
            desctextBox.Location = new Point(24, 128);
            desctextBox.Name = "desctextBox";
            desctextBox.Size = new Size(228, 27);
            desctextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 105);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // categorytextBox
            // 
            categorytextBox.Location = new Point(24, 204);
            categorytextBox.Name = "categorytextBox";
            categorytextBox.Size = new Size(228, 27);
            categorytextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 181);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 5;
            label3.Text = "Category Name";
            // 
            // Add
            // 
            Add.Location = new Point(24, 269);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 7;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(158, 269);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 8;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // update
            // 
            update.Location = new Point(24, 334);
            update.Name = "update";
            update.Size = new Size(94, 29);
            update.TabIndex = 9;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(update);
            Controls.Add(Delete);
            Controls.Add(Add);
            Controls.Add(categorytextBox);
            Controls.Add(label3);
            Controls.Add(desctextBox);
            Controls.Add(label2);
            Controls.Add(nametextBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox nametextBox;
        private TextBox desctextBox;
        private Label label2;
        private TextBox categorytextBox;
        private Label label3;
        private Button Add;
        private Button Delete;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button update;
    }
}
