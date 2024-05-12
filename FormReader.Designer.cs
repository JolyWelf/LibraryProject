namespace LibraryProject
{
    partial class FormReader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isbnAvailableBooksTextBox = new System.Windows.Forms.TextBox();
            this.authorAvailableBooksTextBox = new System.Windows.Forms.TextBox();
            this.publicationYearAvailableBooksTextBox = new System.Windows.Forms.TextBox();
            this.TitleAvailableBooksTextBox = new System.Windows.Forms.TextBox();
            this.bookIDAvailableBooksTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.refreshDataAvailableBooksButton = new System.Windows.Forms.Button();
            this.exitAvailableButton = new System.Windows.Forms.Button();
            this.moveLastAvailableButton = new System.Windows.Forms.Button();
            this.moveNextAvailableButton = new System.Windows.Forms.Button();
            this.movePreviuosAvailableButton = new System.Windows.Forms.Button();
            this.moveFirstAvailableButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.returnDateReaderTextBox = new System.Windows.Forms.TextBox();
            this.isbnReaderTextBox = new System.Windows.Forms.TextBox();
            this.authorReaderTextBox = new System.Windows.Forms.TextBox();
            this.TitleReaderTextBox = new System.Windows.Forms.TextBox();
            this.refreshDataMyBook = new System.Windows.Forms.Button();
            this.exitMyBookButton = new System.Windows.Forms.Button();
            this.moveLastMyBookButton = new System.Windows.Forms.Button();
            this.moveNextMyBookButton = new System.Windows.Forms.Button();
            this.movePreviousMyBookButton = new System.Windows.Forms.Button();
            this.moveFirstMyBookButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.positionReaderLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(49, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 468);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1065, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Доступные книги";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(492, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(478, 235);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.isbnAvailableBooksTextBox);
            this.groupBox1.Controls.Add(this.authorAvailableBooksTextBox);
            this.groupBox1.Controls.Add(this.publicationYearAvailableBooksTextBox);
            this.groupBox1.Controls.Add(this.TitleAvailableBooksTextBox);
            this.groupBox1.Controls.Add(this.bookIDAvailableBooksTextBox);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.refreshDataAvailableBooksButton);
            this.groupBox1.Controls.Add(this.exitAvailableButton);
            this.groupBox1.Controls.Add(this.moveLastAvailableButton);
            this.groupBox1.Controls.Add(this.moveNextAvailableButton);
            this.groupBox1.Controls.Add(this.movePreviuosAvailableButton);
            this.groupBox1.Controls.Add(this.moveFirstAvailableButton);
            this.groupBox1.Location = new System.Drawing.Point(55, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "О Книге";
            // 
            // isbnAvailableBooksTextBox
            // 
            this.isbnAvailableBooksTextBox.Location = new System.Drawing.Point(142, 129);
            this.isbnAvailableBooksTextBox.Name = "isbnAvailableBooksTextBox";
            this.isbnAvailableBooksTextBox.Size = new System.Drawing.Size(184, 20);
            this.isbnAvailableBooksTextBox.TabIndex = 32;
            // 
            // authorAvailableBooksTextBox
            // 
            this.authorAvailableBooksTextBox.Location = new System.Drawing.Point(142, 77);
            this.authorAvailableBooksTextBox.Name = "authorAvailableBooksTextBox";
            this.authorAvailableBooksTextBox.Size = new System.Drawing.Size(184, 20);
            this.authorAvailableBooksTextBox.TabIndex = 31;
            // 
            // publicationYearAvailableBooksTextBox
            // 
            this.publicationYearAvailableBooksTextBox.Location = new System.Drawing.Point(142, 103);
            this.publicationYearAvailableBooksTextBox.Name = "publicationYearAvailableBooksTextBox";
            this.publicationYearAvailableBooksTextBox.Size = new System.Drawing.Size(184, 20);
            this.publicationYearAvailableBooksTextBox.TabIndex = 30;
            // 
            // TitleAvailableBooksTextBox
            // 
            this.TitleAvailableBooksTextBox.Location = new System.Drawing.Point(142, 51);
            this.TitleAvailableBooksTextBox.Name = "TitleAvailableBooksTextBox";
            this.TitleAvailableBooksTextBox.Size = new System.Drawing.Size(184, 20);
            this.TitleAvailableBooksTextBox.TabIndex = 29;
            // 
            // bookIDAvailableBooksTextBox
            // 
            this.bookIDAvailableBooksTextBox.Location = new System.Drawing.Point(142, 26);
            this.bookIDAvailableBooksTextBox.Name = "bookIDAvailableBooksTextBox";
            this.bookIDAvailableBooksTextBox.Size = new System.Drawing.Size(184, 20);
            this.bookIDAvailableBooksTextBox.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(53, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "ISBN";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "PublicationYear";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Author";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Title";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "ID";
            // 
            // refreshDataAvailableBooksButton
            // 
            this.refreshDataAvailableBooksButton.ForeColor = System.Drawing.Color.Blue;
            this.refreshDataAvailableBooksButton.Location = new System.Drawing.Point(44, 207);
            this.refreshDataAvailableBooksButton.Name = "refreshDataAvailableBooksButton";
            this.refreshDataAvailableBooksButton.Size = new System.Drawing.Size(142, 36);
            this.refreshDataAvailableBooksButton.TabIndex = 21;
            this.refreshDataAvailableBooksButton.Text = "Refresh Data";
            this.refreshDataAvailableBooksButton.UseVisualStyleBackColor = true;
            this.refreshDataAvailableBooksButton.Click += new System.EventHandler(this.refreshDataAvailableBooksButton_Click);
            // 
            // exitAvailableButton
            // 
            this.exitAvailableButton.ForeColor = System.Drawing.Color.Red;
            this.exitAvailableButton.Location = new System.Drawing.Point(192, 207);
            this.exitAvailableButton.Name = "exitAvailableButton";
            this.exitAvailableButton.Size = new System.Drawing.Size(142, 36);
            this.exitAvailableButton.TabIndex = 20;
            this.exitAvailableButton.Text = "Exit";
            this.exitAvailableButton.UseVisualStyleBackColor = true;
            this.exitAvailableButton.Click += new System.EventHandler(this.exitAvailableButton_Click);
            // 
            // moveLastAvailableButton
            // 
            this.moveLastAvailableButton.Location = new System.Drawing.Point(266, 177);
            this.moveLastAvailableButton.Name = "moveLastAvailableButton";
            this.moveLastAvailableButton.Size = new System.Drawing.Size(68, 24);
            this.moveLastAvailableButton.TabIndex = 19;
            this.moveLastAvailableButton.Text = ">|";
            this.moveLastAvailableButton.UseVisualStyleBackColor = true;
            this.moveLastAvailableButton.Click += new System.EventHandler(this.moveLastAvailableButton_Click);
            // 
            // moveNextAvailableButton
            // 
            this.moveNextAvailableButton.Location = new System.Drawing.Point(192, 177);
            this.moveNextAvailableButton.Name = "moveNextAvailableButton";
            this.moveNextAvailableButton.Size = new System.Drawing.Size(68, 24);
            this.moveNextAvailableButton.TabIndex = 18;
            this.moveNextAvailableButton.Text = ">";
            this.moveNextAvailableButton.UseVisualStyleBackColor = true;
            this.moveNextAvailableButton.Click += new System.EventHandler(this.moveNextAvailableButton_Click);
            // 
            // movePreviuosAvailableButton
            // 
            this.movePreviuosAvailableButton.Location = new System.Drawing.Point(118, 177);
            this.movePreviuosAvailableButton.Name = "movePreviuosAvailableButton";
            this.movePreviuosAvailableButton.Size = new System.Drawing.Size(68, 24);
            this.movePreviuosAvailableButton.TabIndex = 17;
            this.movePreviuosAvailableButton.Text = "<";
            this.movePreviuosAvailableButton.UseVisualStyleBackColor = true;
            this.movePreviuosAvailableButton.Click += new System.EventHandler(this.movePreviuosAvailableButton_Click);
            // 
            // moveFirstAvailableButton
            // 
            this.moveFirstAvailableButton.Location = new System.Drawing.Point(44, 177);
            this.moveFirstAvailableButton.Name = "moveFirstAvailableButton";
            this.moveFirstAvailableButton.Size = new System.Drawing.Size(68, 24);
            this.moveFirstAvailableButton.TabIndex = 16;
            this.moveFirstAvailableButton.Text = "|<";
            this.moveFirstAvailableButton.UseVisualStyleBackColor = true;
            this.moveFirstAvailableButton.Click += new System.EventHandler(this.moveFirstAvailableButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1065, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Мои книги";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(509, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(497, 245);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Database";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(491, 226);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.returnDateReaderTextBox);
            this.groupBox3.Controls.Add(this.isbnReaderTextBox);
            this.groupBox3.Controls.Add(this.authorReaderTextBox);
            this.groupBox3.Controls.Add(this.TitleReaderTextBox);
            this.groupBox3.Controls.Add(this.refreshDataMyBook);
            this.groupBox3.Controls.Add(this.exitMyBookButton);
            this.groupBox3.Controls.Add(this.moveLastMyBookButton);
            this.groupBox3.Controls.Add(this.moveNextMyBookButton);
            this.groupBox3.Controls.Add(this.movePreviousMyBookButton);
            this.groupBox3.Controls.Add(this.moveFirstMyBookButton);
            this.groupBox3.Location = new System.Drawing.Point(59, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 308);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "О книге";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(43, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "Return Date";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(44, 99);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "ISBN";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(44, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Author";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(44, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Title";
            // 
            // returnDateReaderTextBox
            // 
            this.returnDateReaderTextBox.Location = new System.Drawing.Point(121, 120);
            this.returnDateReaderTextBox.Name = "returnDateReaderTextBox";
            this.returnDateReaderTextBox.Size = new System.Drawing.Size(216, 20);
            this.returnDateReaderTextBox.TabIndex = 25;
            // 
            // isbnReaderTextBox
            // 
            this.isbnReaderTextBox.Location = new System.Drawing.Point(121, 92);
            this.isbnReaderTextBox.Name = "isbnReaderTextBox";
            this.isbnReaderTextBox.Size = new System.Drawing.Size(216, 20);
            this.isbnReaderTextBox.TabIndex = 24;
            // 
            // authorReaderTextBox
            // 
            this.authorReaderTextBox.Location = new System.Drawing.Point(121, 66);
            this.authorReaderTextBox.Name = "authorReaderTextBox";
            this.authorReaderTextBox.Size = new System.Drawing.Size(216, 20);
            this.authorReaderTextBox.TabIndex = 23;
            // 
            // TitleReaderTextBox
            // 
            this.TitleReaderTextBox.Location = new System.Drawing.Point(121, 40);
            this.TitleReaderTextBox.Name = "TitleReaderTextBox";
            this.TitleReaderTextBox.Size = new System.Drawing.Size(216, 20);
            this.TitleReaderTextBox.TabIndex = 22;
            // 
            // refreshDataMyBook
            // 
            this.refreshDataMyBook.ForeColor = System.Drawing.Color.Blue;
            this.refreshDataMyBook.Location = new System.Drawing.Point(47, 234);
            this.refreshDataMyBook.Name = "refreshDataMyBook";
            this.refreshDataMyBook.Size = new System.Drawing.Size(142, 36);
            this.refreshDataMyBook.TabIndex = 21;
            this.refreshDataMyBook.Text = "Refresh Data";
            this.refreshDataMyBook.UseVisualStyleBackColor = true;
            this.refreshDataMyBook.Click += new System.EventHandler(this.refreshDataMyBook_Click);
            // 
            // exitMyBookButton
            // 
            this.exitMyBookButton.ForeColor = System.Drawing.Color.Red;
            this.exitMyBookButton.Location = new System.Drawing.Point(195, 234);
            this.exitMyBookButton.Name = "exitMyBookButton";
            this.exitMyBookButton.Size = new System.Drawing.Size(142, 36);
            this.exitMyBookButton.TabIndex = 20;
            this.exitMyBookButton.Text = "Exit";
            this.exitMyBookButton.UseVisualStyleBackColor = true;
            this.exitMyBookButton.Click += new System.EventHandler(this.exitMyBookButton_Click);
            // 
            // moveLastMyBookButton
            // 
            this.moveLastMyBookButton.Location = new System.Drawing.Point(269, 204);
            this.moveLastMyBookButton.Name = "moveLastMyBookButton";
            this.moveLastMyBookButton.Size = new System.Drawing.Size(68, 24);
            this.moveLastMyBookButton.TabIndex = 19;
            this.moveLastMyBookButton.Text = ">|";
            this.moveLastMyBookButton.UseVisualStyleBackColor = true;
            this.moveLastMyBookButton.Click += new System.EventHandler(this.moveLastMyBookButton_Click);
            // 
            // moveNextMyBookButton
            // 
            this.moveNextMyBookButton.Location = new System.Drawing.Point(195, 204);
            this.moveNextMyBookButton.Name = "moveNextMyBookButton";
            this.moveNextMyBookButton.Size = new System.Drawing.Size(68, 24);
            this.moveNextMyBookButton.TabIndex = 18;
            this.moveNextMyBookButton.Text = ">";
            this.moveNextMyBookButton.UseVisualStyleBackColor = true;
            this.moveNextMyBookButton.Click += new System.EventHandler(this.moveNextMyBookButton_Click);
            // 
            // movePreviousMyBookButton
            // 
            this.movePreviousMyBookButton.Location = new System.Drawing.Point(121, 204);
            this.movePreviousMyBookButton.Name = "movePreviousMyBookButton";
            this.movePreviousMyBookButton.Size = new System.Drawing.Size(68, 24);
            this.movePreviousMyBookButton.TabIndex = 17;
            this.movePreviousMyBookButton.Text = "<";
            this.movePreviousMyBookButton.UseVisualStyleBackColor = true;
            this.movePreviousMyBookButton.Click += new System.EventHandler(this.movePreviousMyBookButton_Click);
            // 
            // moveFirstMyBookButton
            // 
            this.moveFirstMyBookButton.Location = new System.Drawing.Point(47, 204);
            this.moveFirstMyBookButton.Name = "moveFirstMyBookButton";
            this.moveFirstMyBookButton.Size = new System.Drawing.Size(68, 24);
            this.moveFirstMyBookButton.TabIndex = 16;
            this.moveFirstMyBookButton.Text = "|<";
            this.moveFirstMyBookButton.UseVisualStyleBackColor = true;
            this.moveFirstMyBookButton.Click += new System.EventHandler(this.moveFirstMyBookButton_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionReaderLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // positionReaderLabel
            // 
            this.positionReaderLabel.Name = "positionReaderLabel";
            this.positionReaderLabel.Size = new System.Drawing.Size(73, 17);
            this.positionReaderLabel.Text = "Position: 0/0";
            // 
            // FormReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 518);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormReader";
            this.Text = "FormReader";
            this.Load += new System.EventHandler(this.FormReader_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refreshDataAvailableBooksButton;
        private System.Windows.Forms.Button exitAvailableButton;
        private System.Windows.Forms.Button moveLastAvailableButton;
        private System.Windows.Forms.Button moveNextAvailableButton;
        private System.Windows.Forms.Button movePreviuosAvailableButton;
        private System.Windows.Forms.Button moveFirstAvailableButton;
        private System.Windows.Forms.Button refreshDataMyBook;
        private System.Windows.Forms.Button exitMyBookButton;
        private System.Windows.Forms.Button moveLastMyBookButton;
        private System.Windows.Forms.Button moveNextMyBookButton;
        private System.Windows.Forms.Button movePreviousMyBookButton;
        private System.Windows.Forms.Button moveFirstMyBookButton;
        private System.Windows.Forms.TextBox returnDateReaderTextBox;
        private System.Windows.Forms.TextBox isbnReaderTextBox;
        private System.Windows.Forms.TextBox authorReaderTextBox;
        private System.Windows.Forms.TextBox TitleReaderTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel positionReaderLabel;
        private System.Windows.Forms.TextBox isbnAvailableBooksTextBox;
        private System.Windows.Forms.TextBox authorAvailableBooksTextBox;
        private System.Windows.Forms.TextBox publicationYearAvailableBooksTextBox;
        private System.Windows.Forms.TextBox TitleAvailableBooksTextBox;
        private System.Windows.Forms.TextBox bookIDAvailableBooksTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}