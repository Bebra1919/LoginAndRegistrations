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

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string login = txtLogin.Text;
            string password = txtPassword.Password;


            if (login == "admin" && password == "1234")
            {
                MessageBox.Show("Вход выполнен успешно");
            }
            else
            {
                Exaption.Text = "Неправильный  логин или пароль";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string name = txtName.Text;
            string email = txtEmail.Text;
            string gender = cmbGender.Name;
            string password = txtRegPassword.Password;
            string confirmPassword = txtRegPasswordConfirm.Password;

            if (password == confirmPassword)
            {
                MessageBox.Show("Регистрация выполнена успешно");
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }
    }
}