using RestaurantSalaries.Data;
using RestaurantSalaries.Entities;

namespace RestaurantSalaries.Forms
{
    public partial class EmployeesForm : Form
    {
        private readonly RestaurantService restaurantService;
        private Employee selectedEmployee;

        public EmployeesForm(RestaurantService restaurantService)
        {
            InitializeComponent();
            this.restaurantService = restaurantService;
            LoadEmployees();
            formPanel.Visible = false;
        }

        private void LoadEmployees()
        {
            employeesGridView.DataSource = restaurantService.GetAllEmployees().ToList();
            employeesGridView.Columns["Id"].Visible = false;
            employeesGridView.Columns["Salaries"].Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            selectedEmployee = null;
            nameTextBox.Text = "";
            positionTextBox.Text = "";
            hourlyRateTextBox.Text = "";
            hoursWorkedTextBox.Text = "";
            bonusTextBox.Text = "";
            deductionsTextBox.Text = "";
            formPanel.Visible = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (employeesGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Моля, изберете служител за редактиране.");
                return;
            }

            int employeeId = (int)employeesGridView.SelectedRows[0].Cells["Id"].Value;
            selectedEmployee = restaurantService.GetEmployeeById(employeeId);

            nameTextBox.Text = selectedEmployee.Name;
            positionTextBox.Text = selectedEmployee.Position;
            hourlyRateTextBox.Text = selectedEmployee.HourlyRate.ToString();
            hoursWorkedTextBox.Text = selectedEmployee.HoursWorked.ToString();
            bonusTextBox.Text = selectedEmployee.Bonus.ToString();
            deductionsTextBox.Text = selectedEmployee.Deductions.ToString();
            formPanel.Visible = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (employeesGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Моля, изберете служител за изтриване.");
                return;
            }

            int employeeId = (int)employeesGridView.SelectedRows[0].Cells["Id"].Value;
            var result = MessageBox.Show("Сигурни ли сте, че искате да изтриете този служител?", "Потвърждение", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                restaurantService.DeleteEmployee(employeeId);
                LoadEmployees();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(hourlyRateTextBox.Text) ||
                string.IsNullOrWhiteSpace(hoursWorkedTextBox.Text) ||
                string.IsNullOrWhiteSpace(bonusTextBox.Text) ||
                string.IsNullOrWhiteSpace(deductionsTextBox.Text) ||
                string.IsNullOrWhiteSpace(positionTextBox.Text))
            {
                MessageBox.Show("Моля, попълнете всички полета.");
                return;
            }

            if (selectedEmployee == null)
            {
                // Добавяне на нов служител
                Employee newEmployee = new Employee
                {
                    Name = nameTextBox.Text,
                    Position = positionTextBox.Text,
                    HourlyRate = decimal.Parse(hourlyRateTextBox.Text),
                    HoursWorked = int.Parse(hoursWorkedTextBox.Text),
                    Bonus = decimal.Parse(bonusTextBox.Text),
                    Deductions = decimal.Parse(deductionsTextBox.Text)
                };

                restaurantService.AddEmployee(newEmployee);
            }
            else
            {
                // Редактиране на съществуващ служител
                selectedEmployee.Name = nameTextBox.Text;
                selectedEmployee.Position = positionTextBox.Text;
                selectedEmployee.HourlyRate = decimal.Parse(hourlyRateTextBox.Text);
                selectedEmployee.HoursWorked = int.Parse(hoursWorkedTextBox.Text);
                selectedEmployee.Bonus = decimal.Parse(bonusTextBox.Text);
                selectedEmployee.Deductions = decimal.Parse(deductionsTextBox.Text);

                restaurantService.UpdateEmployee(selectedEmployee);
            }

            formPanel.Visible = false;
            LoadEmployees();
        }
    }
}