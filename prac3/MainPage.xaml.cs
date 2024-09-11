namespace prac3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            if ((username == "Админ" || username == "Пользователь") && password == "123")
            {
                ElementsBlock.IsVisible = true;
            }
            else
            {
                DisplayAlert("Ошибка", "Неверное имя пользователя или пароль.", "OK");
            }
        }

        private void OnCloseButtonClicked(object sender, EventArgs e)
        {
            Application.Current.Quit();
        }
    }

}
