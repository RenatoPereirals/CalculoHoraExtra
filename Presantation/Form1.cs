namespace WorkHourCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string username = input_username.Text;
            string password = input_password.Text;

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Login bem-sucedido!");
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha incorretos");
            }
        }

        private void input_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}