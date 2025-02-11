using RestaurantSalaries.Data;
using RestaurantSalaries.Entities;

namespace RestaurantSalaries.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly RestaurantSalariesDbContext context;

        public RegisterForm(RestaurantSalariesDbContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                lblError.Text = "Всички полета са задължителни!";
                lblError.Visible = true;
                return;
            }

            if (password != confirmPassword)
            {
                lblError.Text = "Паролите не съвпадат!";
                lblError.Visible = true;
                return;
            }

            if (context.Users.Any(u => u.UserName == username || u.Email == email))
            {
                lblError.Text = "Този потребител вече съществува!";
                lblError.Visible = true;
                return;
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            User newUser = new User
            {
                UserName = username,
                Email = email,
                PasswordHash = hashedPassword,
            };

            context.Users.Add(newUser);
            context.SaveChanges();

            MessageBox.Show("Регистрацията е успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            LoginForm loginForm = new LoginForm(context);
            loginForm.Show();
        }
    }
}
