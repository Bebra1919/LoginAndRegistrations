using System.Collections.Generic;
using System.Windows;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public List<User> users = new List<User>();
        public MainWindow()
        {
            InitializeComponent();
            users.Add(new User("admin", "1234"));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string login = txtLogin.Text;
            string password = txtPassword.Password;

            foreach (User user in users)
            {
                if (user.Login == login && user.Password == password)
                {
                    MessageBox.Show("Вход выполнен успешно");
                    if (user.Login != login && user.Password != password)
                    {
                        MessageBox.Show("Неправильный логин или пароль");
                    }
                }
            }
        }
    

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string name = txtName.Text;
            string email = txtEmail.Text;
            string gender = cmbGender.Name;
            string password = txtRegPassword.Password;
            string confirmPassword = txtRegPasswordConfirm.Password;

            if (password == "" && name == "" && email == "" && (GenderM.IsChecked != true || GenderF.IsChecked != true))
            {
                MessageBox.Show("Пройдите регистрацию");
            }
            else if (name == "")
            {
                MessageBox.Show("Введите имя");
            }
            else if (email == "")
            {
                MessageBox.Show("Введите Эл.Почту");
            }else if (GenderM.IsChecked != true && GenderF.IsChecked != true)
            {
                MessageBox.Show("Укажите пол");
            } else if (password == "")
            {
                MessageBox.Show("Введите пароль");
            }else if (confirmPassword == "" || confirmPassword != password)
            {
                MessageBox.Show("Введите пароль повторно");
            } else
            {
                if (GenderM.IsChecked == true)
                {
                    users.Add(new User(name, email, "Мужской", password));
                    MessageBox.Show("Регистрация выполнена успешно");
                    txtName.Text = "";
                    txtEmail.Text = "";
                    GenderM.IsChecked = false;
                    txtRegPassword.Password = "";
                    txtRegPasswordConfirm.Password = "";
                    LogIn.IsSelected = true;
                } else if (GenderF.IsChecked == true)
                {
                    users.Add(new User(name, email, "Женский", password));
                    MessageBox.Show("Регистрация выполнена успешно");
                    txtName.Text = "";
                    txtEmail.Text = "";
                    GenderM.IsChecked = false;
                    txtRegPassword.Password = "";
                    txtRegPasswordConfirm.Password = "";
                    LogIn.IsSelected = true;
                }
            }


        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}