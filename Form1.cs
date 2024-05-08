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

namespace LibraryProject
{
    public partial class Form1 : Form
    {
        // ============================================================================
        // ========================== Переменные Базы Данных ==========================
        // ============================================================================
        private static string dbCommand = "";
        private static BindingSource bindingSrc;
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
        }

        // ============================================================================
        // ========================== Обработка Событий Загрузки Формы ==========================
        // ============================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            openConnection();
            updateDataBiding();
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

                bindingSrc = new BindingSource();
                bindingSrc.DataSource = dataSt.Tables["Customers"];

                // Простая привязка данных
                IDTextBox.DataBindings.Add("Text", bindingSrc, "ID");
                firstNameTextBox.DataBindings.Add("Text", bindingSrc, "FirstName");
                lastNameTextBox.DataBindings.Add("Text", bindingSrc, "LastName");
                birthdayTextBox.DataBindings.Add("Text", bindingSrc, "Birthday");

                dataGridView1.Enabled = true;
                dataGridView1.DataSource = bindingSrc;

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
                foreach (Control c in groupBox4.Controls)
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

                bindingSrc = new BindingSource();
                bindingSrc.DataSource = dataSt.Tables["TabOrders"];

                orderIDTextBox.DataBindings.Clear();
                customerIDTextBox.DataBindings.Clear();
                bookIDTextBox.DataBindings.Clear();
                orderDateTextBox.DataBindings.Clear();
                returnDateTextBox.DataBindings.Clear();

                // Простая привязка данных
                orderIDTextBox.DataBindings.Add("Text", bindingSrc, "ID");
                customerIDTextBox.DataBindings.Add("Text", bindingSrc, "CustomerID");
                bookIDTextBox.DataBindings.Add("Text", bindingSrc, "BookID");
                orderDateTextBox.DataBindings.Add("Text", bindingSrc, "OrderDate");
                returnDateTextBox.DataBindings.Add("Text", bindingSrc, "ReturnDate");

                dataGridView2.Enabled = true;
                dataGridView2.DataSource = bindingSrc;

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

        // ============================================================================
        // ========================== Методы Отображения Позиции ======================
        // ============================================================================
        private void displayPosition()
        {
            positionLabel.Text = "Position: " + Convert.ToString(bindingSrc.Position + 1) + "/" + bindingSrc.Count.ToString();
        }

        private void displayPositionOrders()
        {
            positionLabel.Text = "Position: " + Convert.ToString(bindingSrc.Position + 1) + "/" + bindingSrc.Count.ToString();
        }

        // ============================================================================
        // ========================== Методы Навигации ==========================
        // ============================================================================
        private void moveFirstButton_Click(object sender, EventArgs e)
        {
            bindingSrc.MoveFirst();
            displayPosition();
        }

        private void movePreviousButton_Click(object sender, EventArgs e)
        {
            bindingSrc.MovePrevious();
            displayPosition();
        }

        private void moveNextButton_Click(object sender, EventArgs e)
        {
            bindingSrc.MoveNext();
            displayPosition();
        }

        private void moveLastButton_Click(object sender, EventArgs e)
        {
            bindingSrc.MoveLast();
            displayPosition();
        }

        private void moveFirstOrdersButton_Click(object sender, EventArgs e)
        {
            bindingSrc.MoveFirst();
            displayPosition();
        }

        private void movePreviousOrdersButton_Click(object sender, EventArgs e)
        {
            bindingSrc.MovePrevious();
            displayPosition();
        }

        private void moveNextOrdersButton_Click(object sender, EventArgs e)
        {
            bindingSrc.MoveNext();
            displayPosition();
        }

        private void moveLastOrdersButton_Click(object sender, EventArgs e)
        {
            bindingSrc.MoveLast();
            displayPosition();
        }

        // ============================================================================
        // ========================== Методы Управления Данной Записью ==========================
        // ============================================================================

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
            if (addNewButton.Text.Equals("Cancel"))
            {
                return;
            }

            updateDataBindingOrders();
        }

        // Кнопка добавления новой записи
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
                TextBox txt;
                foreach (Control c in groupBox1.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        txt = (TextBox)c;
                        txt.DataBindings.Clear();
                        txt.Text = "";
                        if (txt.Name.Equals("firstNameTextBox"))
                        {
                            if (txt.CanFocus)
                            {
                                txt.Focus();
                            }
                        }
                    }
                }
            }
            catch { }
        }

        // Метод для добавления параметров к SQL-команде
        private void addCmdParameters()
        {
            command.Parameters.Clear();
            command.CommandText = sql;

            command.Parameters.AddWithValue("FirstName", firstNameTextBox.Text.Trim());
            command.Parameters.AddWithValue("LastName", lastNameTextBox.Text.Trim());
            command.Parameters.AddWithValue("Birthday", birthdayTextBox.Text.Trim());

            if (dbCommand.ToUpper() == "UPDATE")
            {
                command.Parameters.AddWithValue("ID", IDTextBox.Text.Trim());
            }
        }

        // Кнопка сохранения данных
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text.Trim()) || string.IsNullOrEmpty(lastNameTextBox.Text.Trim()) || string.IsNullOrEmpty(birthdayTextBox.Text.Trim()))
            {
                MessageBox.Show("Please fill in the required fields.", "Add New Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            openConnection();

            try
            {
                if (addNewButton.Text == "Add New")
                {
                    if (IDTextBox.Text.Trim() == "" || string.IsNullOrEmpty(IDTextBox.Text.Trim()))
                    {
                        MessageBox.Show("Please select an item");
                        return;
                    }

                    if (MessageBox.Show("ID + " + IDTextBox.Text.Trim() + " -- Do you want to update the selected record?", "Visial C# and SQLite (UPDATE)", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        return;
                    }

                    dbCommand = "UPDATE";
                    sql = "UPDATE customers SET FirstName = @FirstName, LastName = @LastName, Birthday = @Birthday WHERE ID = @ID";
                    addCmdParameters();
                }
                else if (addNewButton.Text.Equals("Cancel"))
                {
                    DialogResult result;
                    result = MessageBox.Show("Do you want to add a new customer record?", "Visual C# and SQLite (INSERT)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dbCommand = "INSERT";
                        sql = "INSERT INTO customers(FirstName, LastName, Birthday) VALUES(@FirstName, @LastName, @Birthday)";
                        addCmdParameters();
                    }
                    else
                    {
                        return;
                    }
                }

                int executeResult = command.ExecuteNonQuery();
                if (executeResult == -1)
                {
                    MessageBox.Show("Data was not saved!", "Fail to save data.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MessageBox.Show("Your SQL " + dbCommand + " QUERY has been executed successfully.", "Visual C# and SQLite Database (SAVE)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateDataBiding();
                    addNewButton.Text = "Add New";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString(), "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbCommand = "";
                closeConnection();
            }
        }

        // Кнопка удаления данных
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

        // Кнопка поиска данных
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

        // ============================================================================
        // ========================== Прочие Методы ==========================
        // ============================================================================
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
