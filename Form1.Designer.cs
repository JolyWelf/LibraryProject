namespace LibraryProject
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.positionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.moveFirstButton = new System.Windows.Forms.Button();
            this.movePreviousButton = new System.Windows.Forms.Button();
            this.moveNextButton = new System.Windows.Forms.Button();
            this.moveLastButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.refreshDataButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.returnDateTextBox = new System.Windows.Forms.TextBox();
            this.orderDateTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.exitOrdersButton = new System.Windows.Forms.Button();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.refreshDataOrdersButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.saveOrdersButton = new System.Windows.Forms.Button();
            this.customerIDOrdersTextBox = new System.Windows.Forms.TextBox();
            this.addNewOrdersButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteOrdersButton = new System.Windows.Forms.Button();
            this.bookIDOrdersTextBox = new System.Windows.Forms.TextBox();
            this.moveLastOrdersButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.moveNextOrdersButton = new System.Windows.Forms.Button();
            this.moveFirstOrdersButton = new System.Windows.Forms.Button();
            this.movePreviousOrdersButton = new System.Windows.Forms.Button();
            this.SearchOrdersButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1284, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // positionLabel
            // 
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(73, 17);
            this.positionLabel.Text = "Position: 0/0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(127, 32);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(211, 20);
            this.IDTextBox.TabIndex = 8;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(127, 58);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(211, 20);
            this.firstNameTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(127, 84);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(211, 20);
            this.lastNameTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Last Name";
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.Location = new System.Drawing.Point(127, 110);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(211, 20);
            this.birthdayTextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Birthday";
            // 
            // moveFirstButton
            // 
            this.moveFirstButton.Location = new System.Drawing.Point(44, 152);
            this.moveFirstButton.Name = "moveFirstButton";
            this.moveFirstButton.Size = new System.Drawing.Size(83, 33);
            this.moveFirstButton.TabIndex = 15;
            this.moveFirstButton.Text = "|<";
            this.moveFirstButton.UseVisualStyleBackColor = true;
            this.moveFirstButton.Click += new System.EventHandler(this.moveFirstButton_Click);
            // 
            // movePreviousButton
            // 
            this.movePreviousButton.Location = new System.Drawing.Point(133, 152);
            this.movePreviousButton.Name = "movePreviousButton";
            this.movePreviousButton.Size = new System.Drawing.Size(55, 33);
            this.movePreviousButton.TabIndex = 16;
            this.movePreviousButton.Text = "<";
            this.movePreviousButton.UseVisualStyleBackColor = true;
            this.movePreviousButton.Click += new System.EventHandler(this.movePreviousButton_Click);
            // 
            // moveNextButton
            // 
            this.moveNextButton.Location = new System.Drawing.Point(194, 152);
            this.moveNextButton.Name = "moveNextButton";
            this.moveNextButton.Size = new System.Drawing.Size(55, 33);
            this.moveNextButton.TabIndex = 17;
            this.moveNextButton.Text = ">";
            this.moveNextButton.UseVisualStyleBackColor = true;
            this.moveNextButton.Click += new System.EventHandler(this.moveNextButton_Click);
            // 
            // moveLastButton
            // 
            this.moveLastButton.Location = new System.Drawing.Point(255, 152);
            this.moveLastButton.Name = "moveLastButton";
            this.moveLastButton.Size = new System.Drawing.Size(83, 33);
            this.moveLastButton.TabIndex = 18;
            this.moveLastButton.Text = ">|";
            this.moveLastButton.UseVisualStyleBackColor = true;
            this.moveLastButton.Click += new System.EventHandler(this.moveLastButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(44, 191);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(83, 33);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.TabStop = false;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.ForeColor = System.Drawing.Color.Blue;
            this.addNewButton.Location = new System.Drawing.Point(133, 191);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(116, 33);
            this.addNewButton.TabIndex = 20;
            this.addNewButton.Text = "Add New";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.ForeColor = System.Drawing.Color.Red;
            this.saveButton.Location = new System.Drawing.Point(255, 191);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(83, 33);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // refreshDataButton
            // 
            this.refreshDataButton.Location = new System.Drawing.Point(44, 230);
            this.refreshDataButton.Name = "refreshDataButton";
            this.refreshDataButton.Size = new System.Drawing.Size(144, 35);
            this.refreshDataButton.TabIndex = 22;
            this.refreshDataButton.Text = "Refresh Data";
            this.refreshDataButton.UseVisualStyleBackColor = true;
            this.refreshDataButton.Click += new System.EventHandler(this.refreshDataButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(194, 230);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(144, 35);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = " Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(468, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 265);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(589, 246);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.birthdayTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.exitButton);
            this.groupBox1.Controls.Add(this.IDTextBox);
            this.groupBox1.Controls.Add(this.refreshDataButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.firstNameTextBox);
            this.groupBox1.Controls.Add(this.addNewButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.lastNameTextBox);
            this.groupBox1.Controls.Add(this.moveLastButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.moveNextButton);
            this.groupBox1.Controls.Add(this.moveFirstButton);
            this.groupBox1.Controls.Add(this.movePreviousButton);
            this.groupBox1.Location = new System.Drawing.Point(43, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 318);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детали клиента";
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keywordTextBox.Location = new System.Drawing.Point(517, 295);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.Size = new System.Drawing.Size(260, 24);
            this.keywordTextBox.TabIndex = 26;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(783, 295);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(233, 24);
            this.searchButton.TabIndex = 28;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(27, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1116, 440);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.searchButton);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.keywordTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1108, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SearchOrdersButton);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1108, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(479, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(544, 275);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Database";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(538, 256);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.returnDateTextBox);
            this.groupBox3.Controls.Add(this.orderDateTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.exitOrdersButton);
            this.groupBox3.Controls.Add(this.orderIDTextBox);
            this.groupBox3.Controls.Add(this.refreshDataOrdersButton);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.saveOrdersButton);
            this.groupBox3.Controls.Add(this.customerIDOrdersTextBox);
            this.groupBox3.Controls.Add(this.addNewOrdersButton);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.deleteOrdersButton);
            this.groupBox3.Controls.Add(this.bookIDOrdersTextBox);
            this.groupBox3.Controls.Add(this.moveLastOrdersButton);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.moveNextOrdersButton);
            this.groupBox3.Controls.Add(this.moveFirstOrdersButton);
            this.groupBox3.Controls.Add(this.movePreviousOrdersButton);
            this.groupBox3.Location = new System.Drawing.Point(43, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 319);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Детали Заказа";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Return Date";
            // 
            // returnDateTextBox
            // 
            this.returnDateTextBox.Location = new System.Drawing.Point(127, 136);
            this.returnDateTextBox.Name = "returnDateTextBox";
            this.returnDateTextBox.Size = new System.Drawing.Size(218, 20);
            this.returnDateTextBox.TabIndex = 24;
            // 
            // orderDateTextBox
            // 
            this.orderDateTextBox.Location = new System.Drawing.Point(127, 110);
            this.orderDateTextBox.Name = "orderDateTextBox";
            this.orderDateTextBox.Size = new System.Drawing.Size(218, 20);
            this.orderDateTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID";
            // 
            // exitOrdersButton
            // 
            this.exitOrdersButton.Location = new System.Drawing.Point(201, 251);
            this.exitOrdersButton.Name = "exitOrdersButton";
            this.exitOrdersButton.Size = new System.Drawing.Size(144, 35);
            this.exitOrdersButton.TabIndex = 23;
            this.exitOrdersButton.Text = " Exit";
            this.exitOrdersButton.UseVisualStyleBackColor = true;
            this.exitOrdersButton.Click += new System.EventHandler(this.exitOrdersButton_Click);
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.Location = new System.Drawing.Point(127, 32);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(218, 20);
            this.orderIDTextBox.TabIndex = 8;
            // 
            // refreshDataOrdersButton
            // 
            this.refreshDataOrdersButton.Location = new System.Drawing.Point(51, 251);
            this.refreshDataOrdersButton.Name = "refreshDataOrdersButton";
            this.refreshDataOrdersButton.Size = new System.Drawing.Size(144, 35);
            this.refreshDataOrdersButton.TabIndex = 22;
            this.refreshDataOrdersButton.Text = "Refresh Data";
            this.refreshDataOrdersButton.UseVisualStyleBackColor = true;
            this.refreshDataOrdersButton.Click += new System.EventHandler(this.refreshDataOrdersButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Customer ID";
            // 
            // saveOrdersButton
            // 
            this.saveOrdersButton.ForeColor = System.Drawing.Color.Red;
            this.saveOrdersButton.Location = new System.Drawing.Point(263, 212);
            this.saveOrdersButton.Name = "saveOrdersButton";
            this.saveOrdersButton.Size = new System.Drawing.Size(83, 33);
            this.saveOrdersButton.TabIndex = 21;
            this.saveOrdersButton.Text = "Save";
            this.saveOrdersButton.UseVisualStyleBackColor = true;
            this.saveOrdersButton.Click += new System.EventHandler(this.saveOrdersButton_Click);
            // 
            // customerIDOrdersTextBox
            // 
            this.customerIDOrdersTextBox.Location = new System.Drawing.Point(127, 58);
            this.customerIDOrdersTextBox.Name = "customerIDOrdersTextBox";
            this.customerIDOrdersTextBox.Size = new System.Drawing.Size(218, 20);
            this.customerIDOrdersTextBox.TabIndex = 10;
            // 
            // addNewOrdersButton
            // 
            this.addNewOrdersButton.ForeColor = System.Drawing.Color.Blue;
            this.addNewOrdersButton.Location = new System.Drawing.Point(141, 212);
            this.addNewOrdersButton.Name = "addNewOrdersButton";
            this.addNewOrdersButton.Size = new System.Drawing.Size(116, 33);
            this.addNewOrdersButton.TabIndex = 20;
            this.addNewOrdersButton.Text = "Add New";
            this.addNewOrdersButton.UseVisualStyleBackColor = true;
            this.addNewOrdersButton.Click += new System.EventHandler(this.addNewOrdersButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Book ID";
            // 
            // deleteOrdersButton
            // 
            this.deleteOrdersButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteOrdersButton.ForeColor = System.Drawing.Color.Red;
            this.deleteOrdersButton.Location = new System.Drawing.Point(52, 212);
            this.deleteOrdersButton.Name = "deleteOrdersButton";
            this.deleteOrdersButton.Size = new System.Drawing.Size(83, 33);
            this.deleteOrdersButton.TabIndex = 19;
            this.deleteOrdersButton.TabStop = false;
            this.deleteOrdersButton.Text = "Delete";
            this.deleteOrdersButton.UseVisualStyleBackColor = false;
            this.deleteOrdersButton.Click += new System.EventHandler(this.deleteOrdersButton_Click);
            // 
            // bookIDOrdersTextBox
            // 
            this.bookIDOrdersTextBox.Location = new System.Drawing.Point(127, 84);
            this.bookIDOrdersTextBox.Name = "bookIDOrdersTextBox";
            this.bookIDOrdersTextBox.Size = new System.Drawing.Size(218, 20);
            this.bookIDOrdersTextBox.TabIndex = 12;
            // 
            // moveLastOrdersButton
            // 
            this.moveLastOrdersButton.Location = new System.Drawing.Point(263, 173);
            this.moveLastOrdersButton.Name = "moveLastOrdersButton";
            this.moveLastOrdersButton.Size = new System.Drawing.Size(83, 33);
            this.moveLastOrdersButton.TabIndex = 18;
            this.moveLastOrdersButton.Text = ">|";
            this.moveLastOrdersButton.UseVisualStyleBackColor = true;
            this.moveLastOrdersButton.Click += new System.EventHandler(this.moveLastOrdersButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Order Date";
            // 
            // moveNextOrdersButton
            // 
            this.moveNextOrdersButton.Location = new System.Drawing.Point(202, 173);
            this.moveNextOrdersButton.Name = "moveNextOrdersButton";
            this.moveNextOrdersButton.Size = new System.Drawing.Size(55, 33);
            this.moveNextOrdersButton.TabIndex = 17;
            this.moveNextOrdersButton.Text = ">";
            this.moveNextOrdersButton.UseVisualStyleBackColor = true;
            this.moveNextOrdersButton.Click += new System.EventHandler(this.moveNextOrdersButton_Click);
            // 
            // moveFirstOrdersButton
            // 
            this.moveFirstOrdersButton.Location = new System.Drawing.Point(52, 173);
            this.moveFirstOrdersButton.Name = "moveFirstOrdersButton";
            this.moveFirstOrdersButton.Size = new System.Drawing.Size(83, 33);
            this.moveFirstOrdersButton.TabIndex = 15;
            this.moveFirstOrdersButton.Text = "|<";
            this.moveFirstOrdersButton.UseVisualStyleBackColor = true;
            this.moveFirstOrdersButton.Click += new System.EventHandler(this.moveFirstOrdersButton_Click);
            // 
            // movePreviousOrdersButton
            // 
            this.movePreviousOrdersButton.Location = new System.Drawing.Point(141, 173);
            this.movePreviousOrdersButton.Name = "movePreviousOrdersButton";
            this.movePreviousOrdersButton.Size = new System.Drawing.Size(55, 33);
            this.movePreviousOrdersButton.TabIndex = 16;
            this.movePreviousOrdersButton.Text = "<";
            this.movePreviousOrdersButton.UseVisualStyleBackColor = true;
            this.movePreviousOrdersButton.Click += new System.EventHandler(this.movePreviousOrdersButton_Click);
            // 
            // SearchOrdersButton
            // 
            this.SearchOrdersButton.Location = new System.Drawing.Point(638, 317);
            this.SearchOrdersButton.Name = "SearchOrdersButton";
            this.SearchOrdersButton.Size = new System.Drawing.Size(75, 23);
            this.SearchOrdersButton.TabIndex = 29;
            this.SearchOrdersButton.Text = "search";
            this.SearchOrdersButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 579);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Библиотечная картотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel positionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button moveFirstButton;
        private System.Windows.Forms.Button movePreviousButton;
        private System.Windows.Forms.Button moveNextButton;
        private System.Windows.Forms.Button moveLastButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button refreshDataButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox orderDateTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exitOrdersButton;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.Button refreshDataOrdersButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveOrdersButton;
        private System.Windows.Forms.TextBox customerIDOrdersTextBox;
        private System.Windows.Forms.Button addNewOrdersButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button deleteOrdersButton;
        private System.Windows.Forms.TextBox bookIDOrdersTextBox;
        private System.Windows.Forms.Button moveLastOrdersButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button moveNextOrdersButton;
        private System.Windows.Forms.Button moveFirstOrdersButton;
        private System.Windows.Forms.Button movePreviousOrdersButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox returnDateTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button SearchOrdersButton;
    }
}
