namespace RestaurantSalaries.Forms
{
    partial class EmployeesForm
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
            employeesGridView = new DataGridView();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            formPanel = new Panel();
            label5 = new Label();
            deductionsTextBox = new TextBox();
            label4 = new Label();
            bonusTextBox = new TextBox();
            label3 = new Label();
            hoursWorkedTextBox = new TextBox();
            label1 = new Label();
            hourlyRateTextBox = new TextBox();
            saveButton = new Button();
            label2 = new Label();
            nameLabel = new Label();
            positionTextBox = new TextBox();
            nameTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)employeesGridView).BeginInit();
            formPanel.SuspendLayout();
            SuspendLayout();
            // 
            // employeesGridView
            // 
            employeesGridView.AllowUserToOrderColumns = true;
            employeesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeesGridView.Location = new Point(38, 14);
            employeesGridView.Name = "employeesGridView";
            employeesGridView.ReadOnly = true;
            employeesGridView.RowHeadersWidth = 62;
            employeesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeesGridView.ShowEditingIcon = false;
            employeesGridView.Size = new Size(751, 217);
            employeesGridView.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(218, 244);
            addButton.Name = "addButton";
            addButton.Size = new Size(102, 34);
            addButton.TabIndex = 1;
            addButton.Text = "Добави";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(342, 244);
            editButton.Name = "editButton";
            editButton.Size = new Size(136, 34);
            editButton.TabIndex = 2;
            editButton.Text = "Редактирай";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(501, 244);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(111, 34);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Изтрий";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // formPanel
            // 
            formPanel.Controls.Add(label5);
            formPanel.Controls.Add(deductionsTextBox);
            formPanel.Controls.Add(label4);
            formPanel.Controls.Add(bonusTextBox);
            formPanel.Controls.Add(label3);
            formPanel.Controls.Add(hoursWorkedTextBox);
            formPanel.Controls.Add(label1);
            formPanel.Controls.Add(hourlyRateTextBox);
            formPanel.Controls.Add(saveButton);
            formPanel.Controls.Add(label2);
            formPanel.Controls.Add(nameLabel);
            formPanel.Controls.Add(positionTextBox);
            formPanel.Controls.Add(nameTextBox);
            formPanel.Location = new Point(38, 294);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(751, 286);
            formPanel.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(483, 127);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 13;
            label5.Text = "Удръжки";
            // 
            // deductionsTextBox
            // 
            deductionsTextBox.Location = new Point(483, 155);
            deductionsTextBox.Name = "deductionsTextBox";
            deductionsTextBox.Size = new Size(150, 31);
            deductionsTextBox.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 127);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 11;
            label4.Text = "Бонус";
            // 
            // bonusTextBox
            // 
            bonusTextBox.Location = new Point(302, 155);
            bonusTextBox.Name = "bonusTextBox";
            bonusTextBox.Size = new Size(139, 31);
            bonusTextBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 127);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 9;
            label3.Text = "Отработени часове";
            // 
            // hoursWorkedTextBox
            // 
            hoursWorkedTextBox.Location = new Point(88, 155);
            hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            hoursWorkedTextBox.Size = new Size(172, 31);
            hoursWorkedTextBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(483, 18);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 7;
            label1.Text = "Почасова ставка";
            // 
            // hourlyRateTextBox
            // 
            hourlyRateTextBox.Location = new Point(483, 46);
            hourlyRateTextBox.Name = "hourlyRateTextBox";
            hourlyRateTextBox.Size = new Size(150, 31);
            hourlyRateTextBox.TabIndex = 6;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(312, 226);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(121, 44);
            saveButton.TabIndex = 5;
            saveButton.Text = "Запази";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 18);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 3;
            label2.Text = "Длъжност";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(88, 18);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(47, 25);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Име";
            // 
            // positionTextBox
            // 
            positionTextBox.Location = new Point(302, 46);
            positionTextBox.Name = "positionTextBox";
            positionTextBox.Size = new Size(139, 31);
            positionTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(88, 46);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(172, 31);
            nameTextBox.TabIndex = 0;
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(832, 600);
            Controls.Add(formPanel);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(employeesGridView);
            Name = "EmployeesForm";
            Text = "Служители";
            ((System.ComponentModel.ISupportInitialize)employeesGridView).EndInit();
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView employeesGridView;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Panel formPanel;
        private Label label2;
        private Label nameLabel;
        private TextBox positionTextBox;
        private TextBox nameTextBox;
        private Button saveButton;
        private Label label4;
        private TextBox bonusTextBox;
        private Label label3;
        private TextBox hoursWorkedTextBox;
        private Label label1;
        private TextBox hourlyRateTextBox;
        private Label label5;
        private TextBox deductionsTextBox;
    }
}