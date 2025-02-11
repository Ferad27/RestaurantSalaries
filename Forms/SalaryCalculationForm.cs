using RestaurantSalaries.Data;

namespace RestaurantSalaries
{
    public partial class SalaryCalculationForm : Form
    {
        private readonly RestaurantService restaurantService;

        public SalaryCalculationForm(RestaurantService restaurantService)
        {
            this.restaurantService = restaurantService;
            InitializeComponent();
        }

        private void SalaryCalculationForm_Load(object sender, EventArgs e)
        {
            if (employeesDropdown.Items.Count == 0)
            {
                employeesDropdown.Items.AddRange(restaurantService.GetAllEmployees().Select(e => e.Name).ToArray());
            }
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int hoursWorked = int.Parse(hoursWorkedTxt.Text);
            decimal hourlyRate = decimal.Parse(hourlyRateTxt.Text);
            decimal bonus = decimal.Parse(bonusTxt.Text);
            decimal deductions = decimal.Parse(deductionsTxt.Text);

            decimal totalSalary = restaurantService.CalculateSalary(hoursWorked, hourlyRate, bonus, deductions);

            salaryTxt.Text = totalSalary.ToString();
        }        
    }
}