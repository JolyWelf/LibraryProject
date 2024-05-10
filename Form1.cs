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
    public partial class Form1 : Form
    {
        // ============================================================================
        // ========================== Переменные Базы Данных ==========================
        // ============================================================================
        private static string dbCommand = "";
        private static BindingSource bindingSrcCustomers, bindingSrcOrders, bindingSrcBooks;
        private static string dbPath = Application.StartupPath + "\\" + "LibraryProjectDB.db;";
        private static string conString = "Data Source=" + dbPath + "Version=3;New=False;Compress=True;";
        private static SQLiteConnection connection = new SQLiteConnection(conString);
        private static SQLiteCommand command = new SQLiteCommand("", connection);
        private static string sql;

        // ============================================================================
        // ========================== Инициализация Формы =============================
        // ============================================================================
        public Form1()
        {
            InitializeComponent();
            this.IDTextBox.Enabled = false; // Поле ID недоступно для редактирования
            this.orderIDTextBox.Enabled = false; // Поле ID недоступно для редактирования на вкладке заказов
            this.bookIDTextBox.Enabled = false; // Поле ID недоступно для редактирования на вкладке книг
        }

        // ============================================================================
        // ========================== Обработка Событий Загрузки Формы ==========================
        // ============================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            openConnection();
            updateDataBiding();
            updateDataBindingOrders();
            updateDataBindingBooks();
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
        private void updateDataBiding(SQLiteCommand cmd = null)
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
                sql = "SELECT * FROM customers ORDER BY ID ASC;";

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
                adapter.Fill(dataSt, "Customers");

                bindingSrcCustomers = new BindingSource();
                bindingSrcCustomers.DataSource = dataSt.Tables["Customers"];

                // Простая привязка данных
                IDTextBox.DataBindings.Add("Text", bindingSrcCustomers, "ID");
                firstNameTextBox.DataBindings.Add("Text", bindingSrcCustomers, "FirstName");
                lastNameTextBox.DataBindings.Add("Text", bindingSrcCustomers, "LastName");
                birthdayTextBox.DataBindings.Add("Text", bindingSrcCustomers, "Birthday");

                dataGridView1.Enabled = true;
                dataGridView1.DataSource = bindingSrcCustomers;

                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dataGridView1.Columns[0].Width = 70; // ID
                displayPosition();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Biding Error" + ex.Message.ToString(), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateDataBindingOrders(SQLiteCommand cmd = null)
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
                

                dbCommand = "SELECT";
                sql = "SELECT * FROM tabOrders ORDER BY ID ASC;";

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
                adapter.Fill(dataSt, "TabOrders");
                // Добавим проверку на наличие данных в таблице
                if (dataSt.Tables["TabOrders"].Rows.Count == 0)
                {
                    MessageBox.Show("No data found in tabOrders table!", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bindingSrcOrders = new BindingSource();
                bindingSrcOrders.DataSource = dataSt.Tables["TabOrders"];

                orderIDTextBox.DataBindings.Clear();
                customerIDOrdersTextBox.DataBindings.Clear();
                bookIDOrdersTextBox.DataBindings.Clear();
                orderDateTextBox.DataBindings.Clear();
                returnDateTextBox.DataBindings.Clear();


                // Простая привязка данных
                orderIDTextBox.DataBindings.Add("Text", bindingSrcOrders, "ID");
                customerIDOrdersTextBox.DataBindings.Add("Text", bindingSrcOrders, "CustomerID");
                bookIDOrdersTextBox.DataBindings.Add("Text", bindingSrcOrders, "BookID");
                orderDateTextBox.DataBindings.Add("Text", bindingSrcOrders, "OrderDate");
                returnDateTextBox.DataBindings.Add("Text", bindingSrcOrders, "ReturnDate");

                dataGridView2.Enabled = true;
                dataGridView2.DataSource = bindingSrcOrders;

                dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dataGridView2.Columns[0].Width = 70; // ID
                displayPositionOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при привязке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateDataBindingBooks(SQLiteCommand cmd = null)
        {
            try
            {
                // Очищаем привязку данных в текстовых полях
                TextBox tb;
                foreach (Control c in groupBox5.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        tb = (TextBox)c;
                        tb.DataBindings.Clear();
                        tb.Text = "";
                    }
                }


                dbCommand = "SELECT";
                sql = "SELECT * FROM books ORDER BY ID ASC;";

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
                adapter.Fill(dataSt, "Books");
               

                bindingSrcBooks = new BindingSource();
                bindingSrcBooks.DataSource = dataSt.Tables["Books"];


                bookIDTextBox.DataBindings.Clear();
                titleTextBox.DataBindings.Clear();
                authorTextBox.DataBindings.Clear();
                publicationYearTextBox.DataBindings.Clear();
                isbnTextBox.DataBindings.Clear();
                availableTextBox.DataBindings.Clear();

         
                // Простая привязка данных
                bookIDTextBox.DataBindings.Add("Text", bindingSrcBooks, "ID");
                titleTextBox.DataBindings.Add("Text", bindingSrcBooks, "Title");
                authorTextBox.DataBindings.Add("Text", bindingSrcBooks, "Author");
                publicationYearTextBox.DataBindings.Add("Text", bindingSrcBooks, "PublicationYear");
                isbnTextBox.DataBindings.Add("Text", bindingSrcBooks, "ISBN");
                availableTextBox.DataBindings.Add("Text", bindingSrcBooks, "Available");

                dataGridView3.Enabled = true;
                dataGridView3.DataSource = bindingSrcBooks;

                dataGridView3.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dataGridView3.Columns[0].Width = 70; // ID
                displayPositionBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при привязке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        // ====================================================================================================================================================
        // ================================================== Методы Отображения Позиции ======================================================================
        // ====================================================================================================================================================
        private void displayPosition()
        {
            positionLabel.Text = "Position: " + Convert.ToString(bindingSrcCustomers.Position + 1) + "/" + bindingSrcCustomers.Count.ToString();
        }

        private void displayPositionOrders()
        {
            positionLabel.Text = "Position: " + Convert.ToString(bindingSrcOrders.Position + 1) + "/" + bindingSrcOrders.Count.ToString();
        }

        private void displayPositionBooks()
        {
            positionLabel.Text = "Position: " + Convert.ToString(bindingSrcBooks.Position + 1) + "/" + bindingSrcBooks.Count.ToString();    
        }

        // ================================================================================================================================================================
        // ===================================================================== Методы Навигации =========================================================================
        // ================================================================================================================================================================
        private void moveFirstButton_Click(object sender, EventArgs e)
        {
            bindingSrcCustomers.MoveFirst();
            displayPosition();
        }

        private void movePreviousButton_Click(object sender, EventArgs e)
        {
            bindingSrcCustomers.MovePrevious();
            displayPosition();
        }

        private void moveNextButton_Click(object sender, EventArgs e)
        {
            bindingSrcCustomers.MoveNext();
            displayPosition();
        }

        private void moveLastButton_Click(object sender, EventArgs e)
        {
            bindingSrcCustomers.MoveLast();
            displayPosition();
        }

        private void moveFirstOrdersButton_Click(object sender, EventArgs e)
        {
            bindingSrcOrders.MoveFirst();
            displayPositionOrders();
        }

        private void movePreviousOrdersButton_Click(object sender, EventArgs e)
        {
            bindingSrcOrders.MovePrevious();
            displayPositionOrders();
        }

        private void moveNextOrdersButton_Click(object sender, EventArgs e)
        {
            bindingSrcOrders.MoveNext();
            displayPositionOrders();
        }

        private void moveLastOrdersButton_Click(object sender, EventArgs e)
        {
            bindingSrcOrders.MoveLast();
            displayPositionOrders();
        }


        private void moveFirstBookButton_Click(object sender, EventArgs e)
        {
            bindingSrcBooks.MoveFirst();    
            displayPositionBooks();
        }

        private void movePreviousBookButton_Click(object sender, EventArgs e)
        {
            bindingSrcBooks.MovePrevious();
            displayPositionBooks();
        }

        private void moveNextBookButton_Click(object sender, EventArgs e)
        {
            bindingSrcBooks.MoveNext();
            displayPositionBooks();
        }

        private void moveLastBookButton_Click(object sender, EventArgs e)
        {
            bindingSrcBooks.MoveLast();
            displayPositionBooks();
        }




        // ==============================================================================================================================================================================
        // ==================================================================== Методы обновления даты ==================================================================================
        // ==============================================================================================================================================================================

        // Кнопка обновления данных
        private void refreshDataButton_Click(object sender, EventArgs e)
        {
            if (addNewButton.Text.Equals("Cancel"))
            {
                return;
            }

            updateDataBiding();
        }

        private void refreshDataOrdersButton_Click(object sender, EventArgs e)
        {
            if (addNewOrdersButton.Text.Equals("Cancel"))
            {
                return;
            }

            updateDataBindingOrders();
        }

        // ================================================================================================================================================================
        // ==================================================================== Методы добавления новой записи ============================================================
        // ================================================================================================================================================================

        private void addNewButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (addNewButton.Text == "Add New")
                {
                    addNewButton.Text = "Cancel";
                    positionLabel.Text = "Position: 0/0";
                    dataGridView1.ClearSelection();
                    dataGridView1.Enabled = false;
                }
                else
                {
                    addNewButton.Text = "Add New";
                    updateDataBiding();
                    return;
                }

                // Очищаем поля ввода для добавления новой записи
                TextBox txt; // TextBox —  элемент управления, позволяющий пользовалю вводить текстовые данные.
                foreach (Control c in groupBox1.Controls) //перебираем все элементы в групп-боксе1 (лэйблы, текстбоксы, кнопки)
                {
                    if (c.GetType() == typeof(TextBox)) //если это текст-бокс
                    {
                        txt = (TextBox)c; //присвавание  переменной с в переменную txt 
                        txt.DataBindings.Clear(); //очистка существующих привязок даннных
                        txt.Text = ""; //установка пустой строки
                        if (txt.Name.Equals("firstNameTextBox"))
                        {
                            if (txt.CanFocus)
                            {
                                txt.Focus(); //фокус на имени пользователя
                            }
                        }
                    }
                }
            }
            catch { }
        }

        private void addNewOrdersButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (addNewOrdersButton.Text == "Add New")
                {
                    addNewOrdersButton.Text = "Cancel";
                    positionLabel.Text = "Position: 0/0";
                    dataGridView2.ClearSelection();
                    dataGridView2.Enabled = false;
                    //clearTextBoxBindings(groupBox3.Controls); // Очистка полей в группе Orders
                    customerIDOrdersTextBox.Focus();
                }
                else
                {
                    addNewOrdersButton.Text = "Add New";
                    updateDataBindingOrders();
                    return;
                }

                TextBox txt;
                foreach (Control c in groupBox3.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        txt = (TextBox)c;
                        txt.DataBindings.Clear();
                        txt.Text = ""; //установка пустой строки
                        if (txt.Name.Equals("customerIDOrdersTextBox"))
                        {
                            if (txt.CanFocus)
                            {
                                txt.Focus(); //фокус на имени пользователя
                            }
                        }
                    }
                }
            }
            catch { }
        }


        // ==================================================================================================================================================
        // ============================================================= Методы добавления параметров к sql-запросу  ========================================
        // ==================================================================================================================================================
        private void addCmdParameters()
        {
            command.Parameters.Clear();     // Очищаем все существующие параметры, чтобы предотвратить конфликты
            command.CommandText = sql;

            command.Parameters.AddWithValue("FirstName", firstNameTextBox.Text.Trim()); //trim() удаляет пробелы сначала в конце строки
            command.Parameters.AddWithValue("LastName", lastNameTextBox.Text.Trim());
            command.Parameters.AddWithValue("Birthday", birthdayTextBox.Text.Trim());

            if (dbCommand.ToUpper() == "UPDATE")
            {
                command.Parameters.AddWithValue("ID", IDTextBox.Text.Trim());
            }
        }

        private void addCmdParametersOrders()
        {
            command.Parameters.Clear();
            command.CommandText = sql;

            command.Parameters.AddWithValue("CustomerID", customerIDOrdersTextBox.Text.Trim());
            command.Parameters.AddWithValue("BookID", bookIDOrdersTextBox.Text.Trim());
            command.Parameters.AddWithValue("OrderDate", orderDateTextBox.Text.Trim());
            command.Parameters.AddWithValue("ReturnDate", returnDateTextBox.Text.Trim());

            if (dbCommand.ToUpper() == "UPDATE")
            {
                command.Parameters.AddWithValue("ID", orderIDTextBox.Text.Trim());
            }
        }

        // ========================================================================================================================================================
        // ========================================== Методы сохранения изменений/обновлений даты =================================================================
        // ========================================================================================================================================================

        private void saveButton_Click(object sender, EventArgs e)
        {
            // проверка на заполнение полей. если одно не заполнено - ошибка
            if (string.IsNullOrEmpty(firstNameTextBox.Text.Trim()) || string.IsNullOrEmpty(lastNameTextBox.Text.Trim()) || string.IsNullOrEmpty(birthdayTextBox.Text.Trim()))
            {
                MessageBox.Show("Please fill in the required fields.", "Add New Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            openConnection(); // отрываем коннект с бд

            try
            {
                // если текст кнопки add new - то обрабатываем как операцию обновления данных
                if (addNewButton.Text.Equals("Add New"))
                {
                    // Проверяем, выбрано ли значение ID. Если нет, уведомляем пользователя и выходим из метода
                    if (IDTextBox.Text.Trim() == "" || string.IsNullOrEmpty(IDTextBox.Text.Trim()))
                    {
                        MessageBox.Show("Please select an item");
                        return;
                    }

                    DialogResult result; // переменная с результатом диалога
                    result = MessageBox.Show("ID + " + IDTextBox.Text.Trim() + " -- Do you want to update the selected record?",
                        "Visial C# and SQLite (UPDATE)",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);//устанавливает, что по умолчанию выделенной будет кнопка N
                    if (result == DialogResult.No)
                    {
                        return; // Если пользователь не подтвердил обновление, выходим из метода

                    }

                    // Задаем команду как "UPDATE" и формируем SQL-запрос для обновления записи
                    dbCommand = "UPDATE";
                    sql = "UPDATE customers SET FirstName = @FirstName, LastName = @LastName, Birthday = @Birthday WHERE ID = @ID";
                    addCmdParameters(); // Добавляем параметры к команде
                }


                // если текст   кнопки Cancel - то обрабатываем как операцию добавления новых данных 
                else if (addNewButton.Text.Equals("Cancel"))
                {
                    // Запрашиваем у пользователя подтверждение добавления новой записи
                    DialogResult result;
                    result = MessageBox.Show("Do you want to add a new customer record?", "Visual C# and SQLite (INSERT)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        return;

                    }

                    dbCommand = "INSERT";
                    sql = "INSERT INTO customers(FirstName, LastName, Birthday) VALUES(@FirstName, @LastName, @Birthday)";
                    addCmdParameters();
                }

                // Выполняем SQL-команду в базе данных и проверяем результат выполнения
                int executeResult = command.ExecuteNonQuery();

                if (executeResult == -1) // Если результат -1, значит, произошла ошибка при сохранении данных
                {
                    MessageBox.Show("Data was not saved!", "Fail to save data.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MessageBox.Show("Your SQL " + dbCommand + " QUERY has been executed successfully.", "Visual C# and SQLite Database (SAVE)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateDataBiding(); // Обновляем привязку данных
                    addNewButton.Text = "Add New"; // Сбрасываем текст кнопки
                }
            }
            catch (Exception ex)
            {
                // Если произошло исключение, отображаем сообщение об ошибке
                MessageBox.Show("Error: " + ex.Message.ToString(), "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Очищаем переменную dbCommand и закрываем соединение с базой данных
                dbCommand = "";
                closeConnection();
            }
        }

        // кнопка сохранения для таба с заказами
        private void saveOrdersButton_Click(object sender, EventArgs e)
        {
            // Проверка на заполнение полей
            if (string.IsNullOrEmpty(customerIDOrdersTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(bookIDOrdersTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(orderDateTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(returnDateTextBox.Text.Trim()))
            {
                MessageBox.Show("Please fill in all required fields.", "Add New Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            openConnection();
            try
            {
                string bookId = bookIDOrdersTextBox.Text.Trim();
                if (addNewOrdersButton.Text.Equals("Add New"))
                {
                    // Режим обновления существующей записи
                    if (string.IsNullOrEmpty(orderIDTextBox.Text.Trim()))
                    {
                        MessageBox.Show("Please select an item to update.");
                        return;
                    }

                    // Подтверждение обновления записи
                    DialogResult result = MessageBox.Show($"ID: {orderIDTextBox.Text.Trim()} -- Do you want to update the selected record?",
                        "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.No) return;

                    dbCommand = "UPDATE";
                    sql = "UPDATE tabOrders SET CustomerID = @CustomerID, BookID = @BookID, OrderDate = @OrderDate, ReturnDate = @ReturnDate WHERE ID = @ID";
                    addCmdParametersOrders();

                    // Выполняем запрос на обновление заказа
                    int executeResult = command.ExecuteNonQuery();

                    // Если обновление успешно, обновляем статус доступности книги
                    if (executeResult != -1)
                    {
                        MessageBox.Show("Your SQL " + dbCommand + " QUERY has been executed successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Устанавливаем доступность книги в зависимости от наличия заказа
                        string updateBookSql = "UPDATE books SET Available = 0 WHERE ID = @BookID";
                        using (var updateBookCmd = new SQLiteCommand(updateBookSql, connection))
                        {
                            updateBookCmd.Parameters.AddWithValue("@BookID", bookId);
                            updateBookCmd.ExecuteNonQuery();
                        }

                        updateDataBindingOrders();
                        addNewOrdersButton.Text = "Add New";
                    }
                    else
                    {
                        MessageBox.Show("Data was not saved!", "Fail to save data", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else if (addNewOrdersButton.Text.Equals("Cancel"))
                {
                    // Подтверждение добавления новой записи
                    DialogResult result = MessageBox.Show("Do you want to add a new order record?", "Add Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) return;

                    dbCommand = "INSERT";
                    sql = "INSERT INTO tabOrders (CustomerID, BookID, OrderDate, ReturnDate) VALUES (@CustomerID, @BookID, @OrderDate, @ReturnDate)";
                    addCmdParametersOrders();

                    // Выполняем запрос на добавление нового заказа
                    int executeResult = command.ExecuteNonQuery();

                    // Если добавление успешно, обновляем статус доступности книги
                    if (executeResult != -1)
                    {
                        MessageBox.Show("Your SQL " + dbCommand + " QUERY has been executed successfully.", "Add Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Устанавливаем доступность книги как "недоступно" (0)
                        string updateBookSql = "UPDATE books SET Available = 0 WHERE ID = @BookID";
                        using (var updateBookCmd = new SQLiteCommand(updateBookSql, connection))
                        {
                            updateBookCmd.Parameters.AddWithValue("@BookID", bookId);
                            updateBookCmd.ExecuteNonQuery();
                        }

                        updateDataBindingOrders();
                        addNewOrdersButton.Text = "Add New";
                    }
                    else
                    {
                        MessageBox.Show("Data was not saved!", "Fail to save data", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbCommand = "";
                closeConnection();
            }
        }




        // =======================================================================================================================================================================================
        // =================================================================== Методы удаления даты ===============================================================================================
        // =======================================================================================================================================================================================

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (addNewButton.Text == "Cancel")
            {
                return;
            }

            if (addNewButton.Text.Trim() == "" || string.IsNullOrEmpty(IDTextBox.Text.Trim()))
            {
                MessageBox.Show("Please select an item from the list", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            openConnection();

            try
            {
                if (MessageBox.Show("ID: " + IDTextBox.Text.Trim() + " -- Do you want to delete the selected record", "Visual C# and SQLite (DELETE)", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }

                dbCommand = "DELETE";
                sql = "DELETE FROM customers WHERE ID = @ID";

                command.Parameters.Clear();
                command.CommandText = sql;
                command.Parameters.AddWithValue("ID", IDTextBox.Text.Trim());
                int executeResult = command.ExecuteNonQuery();
                if (executeResult == 1)
                {
                    MessageBox.Show("Your SQL " + dbCommand + " QUERY has been executed successfully", "Visual C# and SQLite Database (DELETE)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateDataBiding();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString(), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbCommand = "";
                closeConnection();
            }
        }

        private void deleteOrdersButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(orderIDTextBox.Text.Trim()))
            {
                MessageBox.Show("Please select an order to delete.", "Delete Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            openConnection();
            try
            {
                string orderId = orderIDTextBox.Text.Trim();
                DialogResult confirmation = MessageBox.Show("Do you want to delete the selected order (ID: " + orderId + ")?",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.No)
                {
                    return;
                }

                // Получение идентификатора книги из заказа
                string bookId = null;
                string selectBookQuery = "SELECT BookID FROM tabOrders WHERE ID = @OrderID";
                using (var selectCommand = new SQLiteCommand(selectBookQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@OrderID", orderId);
                    using (var reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bookId = reader["BookID"].ToString();
                            // Вывод идентификатора книги для проверки
                            Console.WriteLine("Book ID: " + bookId);
                        }
                        else
                        {
                            MessageBox.Show("Order ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                // Удаление заказа из таблицы `tabOrders`
                string deleteOrderQuery = "DELETE FROM tabOrders WHERE ID = @OrderID";
                using (var deleteOrderCommand = new SQLiteCommand(deleteOrderQuery, connection))
                {
                    deleteOrderCommand.Parameters.AddWithValue("@OrderID", orderId);
                    int rowsAffected = deleteOrderCommand.ExecuteNonQuery();

                    if (rowsAffected == 1)
                    {
                        // Проверка доступности книги
                        if (!string.IsNullOrEmpty(bookId))
                        {
                            // Обновление статуса доступности книги
                            string updateBookQuery = "UPDATE books SET Available = 1 WHERE ID = @BookID";
                            using (var updateBookCommand = new SQLiteCommand(updateBookQuery, connection))
                            {
                                updateBookCommand.Parameters.Clear();
                                updateBookCommand.Parameters.AddWithValue("@BookID", bookId);
                                int updateRows = updateBookCommand.ExecuteNonQuery();

                                // Проверка успешного обновления книги
                                if (updateRows == 1)
                                {
                                    Console.WriteLine("Book status updated successfully.");
                                }
                                else
                                {
                                    Console.WriteLine("Failed to update book status.");
                                }
                            }
                        }

                        MessageBox.Show("Order and book status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updateDataBindingOrders();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnection();
            }
        }


        // ========================================================================================================================================================
        // ======================================================== Методы поиска данных ==========================================================================
        // ========================================================================================================================================================
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (addNewButton.Text == "Cancel")
            {
                return;
            }

            openConnection();

            try
            {
                if (string.IsNullOrEmpty(keywordTextBox.Text.Trim()))
                {
                    updateDataBiding();
                    return;
                }

                sql = "SELECT * FROM customers ";
                sql += "WHERE FirstName LIKE @Keyword2 ";
                sql += "OR LastName LIKE @Keyword2 ";
                sql += "OR Birthday LIKE @Keyword2 ";
                sql += "ORDER BY ID ASC";
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Parameters.Clear();

                string keyword = string.Format("%{0}%", keywordTextBox.Text);

                command.Parameters.AddWithValue("Keyword1", keywordTextBox.Text);
                command.Parameters.AddWithValue("Keyword2", keyword);

                updateDataBiding(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message.ToString(), "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnection();
                keywordTextBox.Focus();
            }
        }

        private void searchOrdersButton_Click(object sender, EventArgs e)
        {
            if (addNewOrdersButton.Text == "Cancel")
            {
                return;
            }

            openConnection();

            try
            {
                if (string.IsNullOrEmpty(keywordOrdersTextBox.Text.Trim()))
                {
                    updateDataBindingOrders();
                    return;
                }

                // Строим SQL-запрос с параметризованными условиями
                sql = "SELECT * FROM tabOrders ";
                sql += "WHERE CustomerID LIKE @Keyword ";
                sql += "OR BookID LIKE @Keyword ";
                sql += "OR OrderDate LIKE @Keyword ";
                sql += "OR ReturnDate LIKE @Keyword ";
                sql += "ORDER BY ID ASC";

                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Parameters.Clear();

                string keyword = string.Format("%{0}%", keywordOrdersTextBox.Text);

                command.Parameters.AddWithValue("Keyword", keyword);

                // Обновляем привязку данных на основе найденных результатов
                updateDataBindingOrders(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message.ToString(), "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnection();
                keywordOrdersTextBox.Focus();
            }

        }


        private void searchBookButton_Click(object sender, EventArgs e)
        {
            openConnection();
            try
            {
                if (string.IsNullOrEmpty(keywordBookTextBox.Text.Trim()))
                {
                    updateDataBindingBooks();
                    return;
                }

                sql = "SELECT * FROM books WHERE title LIKE @Keyword OR author LIKE @Keyword OR publicationYear LIKE @Keyword OR isbn LIKE @Keyword OR available LIKE @Keyword ORDER BY ID ASC";

                command.CommandType= CommandType.Text;  
                command.CommandText = sql;
                command.Parameters.Clear();

                string keyword = string.Format("%{0}%", keywordBookTextBox.Text);
                command.Parameters.AddWithValue("Keyword", keyword);   
                updateDataBindingBooks(command);


            }
            catch(Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message.ToString(), "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                closeConnection();
                keywordOrdersTextBox.Focus();
            }

        }




        // =======================================================================================================================================================
        // ========================================================== Прочие Методы ==============================================================================
        // =======================================================================================================================================================
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            try
            {
                displayPosition();
            }
            catch (Exception) { }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                displayPositionOrders();
            }
            catch (Exception) { }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                displayPositionBooks();
            }
            catch (Exception) { }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void exitOrdersButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}