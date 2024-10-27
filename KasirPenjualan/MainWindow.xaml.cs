using System.Windows;

namespace KasirPenjualan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public LoginWindow LoginWindow { get; set; }
        public RegisterWindow RegisterWindow { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow = new LoginWindow();
            LoginWindow.Show();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow = new RegisterWindow();
            RegisterWindow.Show();
        }
    }
}
