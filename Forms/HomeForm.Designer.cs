namespace RestaurantSalaries.Forms
{
    partial class HomeForm
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
            calculatorBtn = new Button();
            employeesBtn = new Button();
            mainPanel = new Panel();
            returnButton = new Button();
            SuspendLayout();
            // 
            // calculatorBtn
            // 
            calculatorBtn.Location = new Point(12, 22);
            calculatorBtn.Name = "calculatorBtn";
            calculatorBtn.Size = new Size(129, 72);
            calculatorBtn.TabIndex = 0;
            calculatorBtn.Text = "Изчисляване на заплати";
            calculatorBtn.UseVisualStyleBackColor = true;
            calculatorBtn.Click += calculatorBtn_Click;
            // 
            // employeesBtn
            // 
            employeesBtn.Location = new Point(12, 111);
            employeesBtn.Name = "employeesBtn";
            employeesBtn.Size = new Size(129, 72);
            employeesBtn.TabIndex = 1;
            employeesBtn.Text = "Служители";
            employeesBtn.UseVisualStyleBackColor = true;
            employeesBtn.Click += employeesBtn_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(161, 12);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(927, 615);
            mainPanel.TabIndex = 2;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(12, 200);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(129, 68);
            returnButton.TabIndex = 2;
            returnButton.Text = "Начало";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1088, 633);
            Controls.Add(returnButton);
            Controls.Add(mainPanel);
            Controls.Add(employeesBtn);
            Controls.Add(calculatorBtn);
            Name = "HomeForm";
            Text = "Система за управление на възнагражденията в ресторант";
            ResumeLayout(false);
        }

        #endregion

        private Button calculatorBtn;
        private Button employeesBtn;
        private Panel mainPanel;
        private Button returnButton;
    }
}