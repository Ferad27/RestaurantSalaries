using RestaurantSalaries.Data;

namespace RestaurantSalaries.Forms
{
    public partial class LoginForm : Form
    {
        private readonly RestaurantSalariesDbContext context;
        private readonly RestaurantService restaurantService;

        public LoginForm(RestaurantSalariesDbContext context)
        {
            InitializeComponent();
            this.context = context;
            this.restaurantService = new RestaurantService(context);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernameOrEmail = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(usernameOrEmail) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Моля, въведете потребителско име и парола.";
                lblError.Visible = true;
                return;
            }

            var user = context.Users.FirstOrDefault(u => (u.UserName == usernameOrEmail || u.Email == usernameOrEmail));

            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                lblError.Text = "Грешно потребителско име или парола.";
                lblError.Visible = true;
                return;
            }

            this.Hide();
            HomeForm homeForm = new HomeForm(restaurantService);
            homeForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm(context);
            registerForm.Show();
        }
    }
}