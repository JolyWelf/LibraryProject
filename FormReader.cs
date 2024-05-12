using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace LibraryProject
{
    public partial class FormReader : Form
    {
        // ============================================================================
        // ========================== Переменные Базы Данных ==========================
        // ============================================================================
        private static string dbCommand = "";
        private static BindingSource bindingAvailableBooks, bingingMyBooks;
        private static string dbPath = Application.StartupPath + "\\" + "LibraryProjectDB.db;";
        private static string conString = "Data Source=" + dbPath + "Version=3;New=False;Compress=True;";
        private static SQLiteConnection connection = new SQLiteConnection(conString);
        private static SQLiteCommand command = new SQLiteCommand("", connection);
        private static string sql;


        // ============================================================================
        // ========================== Инициализация Формы =============================
        // ============================================================================
        public FormReader()
        {
            InitializeComponent();
            this.bookIDAvailableBooksTextBox.Enabled = false;
        }


        // ============================================================================
        // ========================== Обработка Событий Загрузки Формы ==========================
        // ============================================================================
        private void FormReader_Load(object sender, EventArgs e)
        {
            openConnection();
            updateDataBingingAvailableBooks();
            updateDataBingingMyBooks();
            closeConnection();
        }

       

        // ============================================================================
        // ========================== Методы Соединения с БД =======================
        // ============================================================================
        private void openConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
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

        private void closeConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
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


        // ============================================================================
        // ========================== Методы Привязки Данных ==========================
        // ============================================================================
        private void updateDataBingingMyBooks(SQLiteCommand cmd = null)
        {
            try
            {
                // Очищаем привязку данных в текстовых полях
                TextBox tb;
                foreach (Control c in groupBox3.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        tb = (TextBox)c;
                        tb.DataBindings.Clear();
                        tb.Text = "";
                    }
                }

                // Получаем текущий идентификатор пользователя
                int currentCustomerId = FormAuth.SessionData.currentCustomerId;

                dbCommand = "SELECT";
                string sql = @"
                        SELECT
                            books.Title,
                            books.Author,
                            books.ISBN,
                            tabOrders.ReturnDate
                        FROM
                            tabOrders
                        INNER JOIN
                            books ON tabOrders.BookID = books.ID
                        WHERE
                            tabOrders.CustomerID = @currentCustomerId
                        ORDER BY
                            tabOrders.OrderDate ASC;
                    ";

                if (cmd == null)
                {
                    command.CommandText = sql;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@currentCustomerId", currentCustomerId);
                }
                else
                {
                    command = cmd;
                }

                // Заполнение данных в DataGridView
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataSet dataSt = new DataSet();
                adapter.Fill(dataSt, "ReservedBooks");

                bingingMyBooks = new BindingSource();
                bingingMyBooks.DataSource = dataSt.Tables["ReservedBooks"];

                // Привязка данных к текстовым полям
                TitleReaderTextBox.DataBindings.Add("Text", bingingMyBooks, "Title");
                authorReaderTextBox.DataBindings.Add("Text", bingingMyBooks, "Author");
                isbnReaderTextBox.DataBindings.Add("Text", bingingMyBooks, "ISBN");
                returnDateReaderTextBox.DataBindings.Add("Text", bingingMyBooks, "ReturnDate");

                dataGridView1.Enabled = true;
                dataGridView1.DataSource = bingingMyBooks;

                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                displayPositionAvailableBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Biding Error" + ex.Message.ToString(), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void updateDataBingingAvailableBooks(SQLiteCommand cmd = null)
        {
            try
            {
                // Очищаем привязку данных в текстовых полях
                TextBox tb;
                foreach (Control c in groupBox1.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        tb = (TextBox)c;
                        tb.DataBindings.Clear();
                        tb.Text = "";
                    }
                }


                dbCommand = "SELECT";

                string sql = @"
                        SELECT
                            books.ID,
                            books.Title,
                            books.Author,
                            books.PublicationYear,
                            books.ISBN
                        FROM
                            books
                        WHERE
                            books.Available = 1
                        ORDER BY
                            ID ASC;
                    ";


                if (cmd == null)
                {
                    command.CommandText = sql;
                }
                else
                {
                    command = cmd;
                }

                // Заполнение данных в DataGridView
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataSet dataSt = new DataSet();
                adapter.Fill(dataSt, "AvailableBooks");

                bindingAvailableBooks = new BindingSource();
                bindingAvailableBooks.DataSource = dataSt.Tables["AvailableBooks"];

                // Привязка данных к текстовым полям
                bookIDAvailableBooksTextBox.DataBindings.Add("Text", bindingAvailableBooks, "ID");
                TitleAvailableBooksTextBox.DataBindings.Add("Text", bindingAvailableBooks, "Title");
                authorAvailableBooksTextBox.DataBindings.Add("Text", bindingAvailableBooks, "Author");
                publicationYearAvailableBooksTextBox.DataBindings.Add("Text", bindingAvailableBooks, "PublicationYear");
                isbnAvailableBooksTextBox.DataBindings.Add("Text", bindingAvailableBooks, "ISBN");

                dataGridView2.Enabled = true;
                dataGridView2.DataSource = bindingAvailableBooks;

                dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                displayPositionAvailableBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Biding Error" + ex.Message.ToString(), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // ================================================================================================================================================================
        // ===================================================================== Методы Навигации =========================================================================
        // ================================================================================================================================================================
        private void moveFirstMyBookButton_Click(object sender, EventArgs e)
        {
            bingingMyBooks.MoveFirst();
            displayPositionMyBooks();
        }

        private void movePreviousMyBookButton_Click(object sender, EventArgs e)
        {
            bingingMyBooks.MovePrevious();
            displayPositionMyBooks();
        }

        private void moveNextMyBookButton_Click(object sender, EventArgs e)
        {
            bingingMyBooks.MoveNext();
            displayPositionMyBooks();
        }

        private void moveLastMyBookButton_Click(object sender, EventArgs e)
        {
            bingingMyBooks.MoveLast();
            displayPositionMyBooks();
        }

        private void moveFirstAvailableButton_Click(object sender, EventArgs e)
        {
            bindingAvailableBooks.MoveFirst();
            displayPositionAvailableBooks();
        }

        private void movePreviuosAvailableButton_Click(object sender, EventArgs e)
        {
            bindingAvailableBooks.MovePrevious();
            displayPositionAvailableBooks();
        }

        private void moveNextAvailableButton_Click(object sender, EventArgs e)
        {
            bindingAvailableBooks.MoveNext();
            displayPositionAvailableBooks();
        }

        private void moveLastAvailableButton_Click(object sender, EventArgs e)
        {
            bindingAvailableBooks.MoveLast();
            displayPositionAvailableBooks();
        }



        // ====================================================================================================================================================
        // ================================================== Методы Отображения Позиции ======================================================================
        // ====================================================================================================================================================
        private void displayPositionMyBooks()
        {
            positionReaderLabel.Text = "Position: " + Convert.ToString(bingingMyBooks.Position + 1) + "/" + bingingMyBooks.Count.ToString();
        }


        private void displayPositionAvailableBooks()
        {
            positionReaderLabel.Text = "Position: " + Convert.ToString(bindingAvailableBooks.Position + 1) + "/" + bindingAvailableBooks.Count.ToString();
        }


        // ====================================================================================================================================================
        // ================================================== Методы обновления данных ======================================================================
        // ====================================================================================================================================================
        private void refreshDataMyBook_Click(object sender, EventArgs e)
        {
            updateDataBingingMyBooks();
            displayPositionMyBooks();
        }

        private void refreshDataAvailableBooksButton_Click(object sender, EventArgs e)
        {
            updateDataBingingAvailableBooks();
            displayPositionAvailableBooks();
        }

      



        // ====================================================================================================================================================
        // ================================================== Другие методы ======================================================================
        // ====================================================================================================================================================
        private void exitMyBookButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void exitAvailableButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
