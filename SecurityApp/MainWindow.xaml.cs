using SecurityApp.DataAccess;
using SecurityApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SecurityApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignInButtonClick(object sender, RoutedEventArgs e)
        {
            var login = loginTextBox.Text;
            var password = passwordBox.Password;
            
            if(string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter data");
                return;
            }

            using (var context = new SecurityContext())
            {
                var user = context.Users.SingleOrDefault(u => u.Login == login);
                
                if(user == null || !SecurityHasher.VerifyPassword(password,user.Password))
                {
                    MessageBox.Show("Login or password isn't correct!");
                }
                else
                {
                    MessageBox.Show("Success!");
                }
            }
        }
    }
}
