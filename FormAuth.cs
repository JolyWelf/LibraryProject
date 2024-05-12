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

        public static class SessionData
        {
            public static int currentCustomerId { get; set; }
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
        private (bool isValid, int userType, int userId) ValidateUser(string login, string password)
        {
            openConnection();
            bool isValid = false;
            int userType = -1;
            int userId = -1; // Идентификатор пользователя


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
                    userId = Convert.ToInt32(result); // Получаем идентификатор пользователя
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

            return (isValid, userType, userId);
        }



        private void entryButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            //// Открываем форму библиотекаря сразу. для отладки
            //Form1 librarianForm = new Form1();
            //librarianForm.Show();
            //this.Hide(); // Скрываем форму авторизации


            // Проверка учетных данных и определение типа пользователя
            var (isValid, userType, userId) = ValidateUser(login, password);

            if (isValid)
            {
                //if (userType == 0) // Администратор
                //{
                //    MessageBox.Show("Добро пожаловать, администратор!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    FormAdmin adminForm = new FormAdmin(); // Замените на вашу форму администратора
                //    adminForm.Show();
                //}

                SessionData.currentCustomerId = userId;

                if (userType == 1) // Библиотекарь
                {
                    MessageBox.Show("Добро пожаловать, библиотекарь!",
                        "Authorization",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 librarianForm = new Form1(); // Форма для библиотекаря
                    librarianForm.Show();
                }
                else if (userType == 2) // Читатель
                {
                    MessageBox.Show("Добро пожаловать, читатель!",
                        "Authorization",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormReader readerForm = new FormReader(); // Форма для читателя
                    readerForm.Show();
                }

                this.Hide(); // Скрываем форму авторизации
            }
            else
            {
                MessageBox.Show("Неправильное имя пользователя или пароль.",
                    "Visual C# and SQLite (ERROR)",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
