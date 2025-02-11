namespace RestaurantSalaries
{
    partial class SalaryCalculationForm
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
            hoursWorkedLabel = new Label();
            hourlyRateLabel = new Label();
            bonusLabel = new Label();
            deductionsLabel = new Label();
            salaryLabel = new Label();
            employeeLabel = new Label();
            calculateBtn = new Button();
            hourlyRateTxt = new TextBox();
            deductionsTxt = new TextBox();
            bonusTxt = new TextBox();
            hoursWorkedTxt = new TextBox();
            employeesDropdown = new ComboBox();
            salaryTxt = new RichTextBox();
            SuspendLayout();
            // 
            // hoursWorkedLabel
            // 
            hoursWorkedLabel.Location = new Point(38, 130);
            hoursWorkedLabel.Name = "hoursWorkedLabel";
            hoursWorkedLabel.Size = new Size(177, 28);
            hoursWorkedLabel.TabIndex = 12;
            hoursWorkedLabel.Text = "Отработени часове";
            // 
            // hourlyRateLabel
            // 
            hourlyRateLabel.Location = new Point(332, 23);
            hourlyRateLabel.Name = "hourlyRateLabel";
            hourlyRateLabel.Size = new Size(145, 23);
            hourlyRateLabel.TabIndex = 11;
            hourlyRateLabel.Text = "Почсова ставка";
            // 
            // bonusLabel
            // 
            bonusLabel.Location = new Point(252, 130);
            bonusLabel.Name = "bonusLabel";
            bonusLabel.Size = new Size(100, 23);
            bonusLabel.TabIndex = 10;
            bonusLabel.Text = "Бонус";
            // 
            // deductionsLabel
            // 
            deductionsLabel.Location = new Point(386, 130);
            deductionsLabel.Name = "deductionsLabel";
            deductionsLabel.Size = new Size(100, 23);
            deductionsLabel.TabIndex = 9;
            deductionsLabel.Text = "Удръжки";
            // 
            // salaryLabel
            // 
            salaryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salaryLabel.Location = new Point(92, 242);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new Size(123, 47);
            salaryLabel.TabIndex = 8;
            salaryLabel.Text = "Заплата:";
            // 
            // employeeLabel
            // 
            employeeLabel.Location = new Point(38, 23);
            employeeLabel.Name = "employeeLabel";
            employeeLabel.Size = new Size(100, 23);
            employeeLabel.TabIndex = 7;
            employeeLabel.Text = "Служител";
            // 
            // calculateBtn
            // 
            calculateBtn.BackColor = SystemColors.Control;
            calculateBtn.Location = new Point(185, 337);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(167, 63);
            calculateBtn.TabIndex = 6;
            calculateBtn.Text = "Изчисли";
            calculateBtn.UseVisualStyleBackColor = false;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // hourlyRateTxt
            // 
            hourlyRateTxt.Location = new Point(332, 60);
            hourlyRateTxt.Name = "hourlyRateTxt";
            hourlyRateTxt.Size = new Size(145, 31);
            hourlyRateTxt.TabIndex = 5;
            // 
            // deductionsTxt
            // 
            deductionsTxt.Location = new Point(377, 161);
            deductionsTxt.Name = "deductionsTxt";
            deductionsTxt.Size = new Size(100, 31);
            deductionsTxt.TabIndex = 4;
            // 
            // bonusTxt
            // 
            bonusTxt.Location = new Point(238, 161);
            bonusTxt.Name = "bonusTxt";
            bonusTxt.Size = new Size(100, 31);
            bonusTxt.TabIndex = 3;
            // 
            // hoursWorkedTxt
            // 
            hoursWorkedTxt.Location = new Point(38, 161);
            hoursWorkedTxt.Name = "hoursWorkedTxt";
            hoursWorkedTxt.Size = new Size(165, 31);
            hoursWorkedTxt.TabIndex = 2;
            // 
            // employeesDropdown
            // 
            employeesDropdown.Location = new Point(38, 58);
            employeesDropdown.Name = "employeesDropdown";
            employeesDropdown.Size = new Size(261, 33);
            employeesDropdown.TabIndex = 1;
            // 
            // salaryTxt
            // 
            salaryTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salaryTxt.Location = new Point(209, 242);
            salaryTxt.Name = "salaryTxt";
            salaryTxt.Size = new Size(143, 44);
            salaryTxt.TabIndex = 0;
            salaryTxt.Text = "";
            // 
            // SalaryCalculationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(548, 450);
            Controls.Add(salaryTxt);
            Controls.Add(employeesDropdown);
            Controls.Add(hoursWorkedTxt);
            Controls.Add(bonusTxt);
            Controls.Add(deductionsTxt);
            Controls.Add(hourlyRateTxt);
            Controls.Add(calculateBtn);
            Controls.Add(employeeLabel);
            Controls.Add(salaryLabel);
            Controls.Add(deductionsLabel);
            Controls.Add(bonusLabel);
            Controls.Add(hourlyRateLabel);
            Controls.Add(hoursWorkedLabel);
            Name = "SalaryCalculationForm";
            Text = "Изчисляване на заплата";
            Load += SalaryCalculationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label hoursWorkedLabel;
        private Label hourlyRateLabel;
        private Label bonusLabel;
        private Label deductionsLabel;
        private Label salaryLabel;
        private Label employeeLabel;
        private Button calculateBtn;
        private TextBox hourlyRateTxt;
        private TextBox deductionsTxt;
        private TextBox bonusTxt;
        private TextBox hoursWorkedTxt;
        private ComboBox employeesDropdown;
        private RichTextBox salaryTxt;
    }
}
