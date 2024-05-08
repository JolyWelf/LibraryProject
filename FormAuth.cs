using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class FormAuth : Form
    {
        // Инициализация переменных для работы с базой данных
        private static string dbCommand = "";
        private static BindingSource bindingSrc;
        private static string dbPath = Application.StartupPath + "\\" + "LibraryProjectDB.db;";

        // Строка подключения к базе данных SQLite
        private static string conString = "Data Source=" + dbPath + "Version=3;New=False;Compress=True;";
        private static SQLiteConnection connection = new SQLiteConnection(conString);
        private static SQLiteCommand command = new SQLiteCommand("", connection);
        private static string sql;

        public FormAuth()
        {
            InitializeComponent();
        }

        // Метод, вызываемый при загрузке формы
        private void FormAuth_Load(object sender, EventArgs e)
        {
            openConnection();

            //updateDataBiding();

            closeConnection();
        }

        // Метод для открытия подключения к базе данных
        private void openConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    // MessageBox.Show("Соединение установлено. Статус: " + connection.State.ToString(), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Ошибка при открытии соединения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Ошибка состояния объекта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для закрытия подключения к базе данных
        private void closeConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    //MessageBox.Show("Соединение закрыто. Статус: " + connection.State.ToString(), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Ошибка при закрытии соединения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Ошибка состояния объекта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Метод для проверки учетных данных и определения типа пользователя
        private (bool isValid, int userType) ValidateUser(string login, string password)
        {
            openConnection();
            bool isValid = false;
            int userType = -1;

            try
            {
                string sql = "SELECT UserType FROM customers WHERE Login  = @Login AND Password = @Password;";
                command.CommandText = sql;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    isValid = true;
                    userType = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка проверки учетных данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnection();
            }

            return (isValid, userType);
        }



        private void entryButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            // Проверка учетных данных и определение типа пользователя
            var (isValid, userType) = ValidateUser(login, password);

            if (isValid)
            {
                //if (userType == 0) // Администратор
                //{
                //    MessageBox.Show("Добро пожаловать, администратор!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    FormAdmin adminForm = new FormAdmin(); // Замените на вашу форму администратора
                //    adminForm.Show();
                //}
                if (userType == 1) // Библиотекарь
                {
                    MessageBox.Show("Добро пожаловать, библиотекарь!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 librarianForm = new Form1(); // Форма для библиотекаря
                    librarianForm.Show();
                }
                else if (userType == 2) // Читатель
                {
                    MessageBox.Show("Добро пожаловать, читатель!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormReader readerForm = new FormReader(); // Форма для читателя
                    readerForm.Show();
                }

                this.Hide(); // Скрываем форму авторизации
            }
            else
            {
                MessageBox.Show("Неправильное имя пользователя или пароль.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
