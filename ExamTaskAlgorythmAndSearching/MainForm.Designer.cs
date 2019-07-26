namespace ExamTaskAlgorythmAndSearching
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.tabHash = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.richINfoTab3 = new System.Windows.Forms.RichTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSorting = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.richSteps = new System.Windows.Forms.RichTextBox();
            this.richTextSourse = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericArraySize = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbBest = new System.Windows.Forms.RadioButton();
            this.rdbRandom = new System.Windows.Forms.RadioButton();
            this.rdbWorst = new System.Windows.Forms.RadioButton();
            this.btnCreateArray = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabControl();
            this.TabSearching = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.numericSearchBar = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLinearSearch = new System.Windows.Forms.Button();
            this.btnBinarySearch = new System.Windows.Forms.Button();
            this.richResultTab2 = new System.Windows.Forms.RichTextBox();
            this.richInfoTab2 = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.nmrArrSizeTab2 = new System.Windows.Forms.NumericUpDown();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbUnsorted = new System.Windows.Forms.RadioButton();
            this.rdbSorted = new System.Windows.Forms.RadioButton();
            this.btnCreateArrayTab2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.tabHash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.tabSorting.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericArraySize)).BeginInit();
            this.panel1.SuspendLayout();
            this.tab.SuspendLayout();
            this.TabSearching.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSearchBar)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrArrSizeTab2)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // tabHash
            // 
            this.tabHash.Controls.Add(this.label8);
            this.tabHash.Controls.Add(this.richINfoTab3);
            this.tabHash.Controls.Add(this.btnSearch);
            this.tabHash.Controls.Add(this.btnRemove);
            this.tabHash.Controls.Add(this.txtSearchBar);
            this.tabHash.Controls.Add(this.btnAdd);
            this.tabHash.Controls.Add(this.grid);
            this.tabHash.Location = new System.Drawing.Point(4, 22);
            this.tabHash.Name = "tabHash";
            this.tabHash.Size = new System.Drawing.Size(654, 428);
            this.tabHash.TabIndex = 2;
            this.tabHash.Text = "Хеширование";
            this.tabHash.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Информация";
            // 
            // richINfoTab3
            // 
            this.richINfoTab3.Location = new System.Drawing.Point(410, 102);
            this.richINfoTab3.Name = "richINfoTab3";
            this.richINfoTab3.Size = new System.Drawing.Size(236, 318);
            this.richINfoTab3.TabIndex = 5;
            this.richINfoTab3.Text = "";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(409, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Искать";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(490, 34);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchBar.Location = new System.Drawing.Point(409, 8);
            this.txtSearchBar.MaxLength = 100;
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(237, 20);
            this.txtSearchBar.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(571, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKey,
            this.colCode,
            this.colIndex});
            this.grid.Location = new System.Drawing.Point(8, 8);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(395, 412);
            this.grid.TabIndex = 0;
            // 
            // colKey
            // 
            this.colKey.DataPropertyName = "Data";
            this.colKey.HeaderText = "Данные";
            this.colKey.Name = "colKey";
            this.colKey.ReadOnly = true;
            this.colKey.Width = 150;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Hash";
            this.colCode.HeaderText = "Hash-код";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // colIndex
            // 
            this.colIndex.DataPropertyName = "Index";
            this.colIndex.HeaderText = "Индекс";
            this.colIndex.Name = "colIndex";
            this.colIndex.ReadOnly = true;
            // 
            // tabSorting
            // 
            this.tabSorting.Controls.Add(this.panel3);
            this.tabSorting.Controls.Add(this.richSteps);
            this.tabSorting.Controls.Add(this.richTextSourse);
            this.tabSorting.Controls.Add(this.panel2);
            this.tabSorting.Controls.Add(this.panel1);
            this.tabSorting.Controls.Add(this.btnCreateArray);
            this.tabSorting.Location = new System.Drawing.Point(4, 22);
            this.tabSorting.Name = "tabSorting";
            this.tabSorting.Padding = new System.Windows.Forms.Padding(3);
            this.tabSorting.Size = new System.Drawing.Size(654, 428);
            this.tabSorting.TabIndex = 0;
            this.tabSorting.Text = "Сортировка";
            this.tabSorting.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnBubbleSort);
            this.panel3.Controls.Add(this.btnSelectionSort);
            this.panel3.Controls.Add(this.btnQuickSort);
            this.panel3.Controls.Add(this.btnInsertionSort);
            this.panel3.Location = new System.Drawing.Point(10, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 91);
            this.panel3.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Рассмотренные алгоритмы сортировки";
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(5, 31);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(100, 23);
            this.btnBubbleSort.TabIndex = 9;
            this.btnBubbleSort.Text = "Пузырьковая";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Location = new System.Drawing.Point(5, 60);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(100, 23);
            this.btnSelectionSort.TabIndex = 10;
            this.btnSelectionSort.Text = "Выбором";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(124, 60);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(97, 23);
            this.btnQuickSort.TabIndex = 12;
            this.btnQuickSort.Text = "Быстрая";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Location = new System.Drawing.Point(124, 31);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(97, 23);
            this.btnInsertionSort.TabIndex = 11;
            this.btnInsertionSort.Text = "Вставками";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // richSteps
            // 
            this.richSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richSteps.Location = new System.Drawing.Point(244, 6);
            this.richSteps.Name = "richSteps";
            this.richSteps.ReadOnly = true;
            this.richSteps.Size = new System.Drawing.Size(402, 412);
            this.richSteps.TabIndex = 13;
            this.richSteps.Text = "";
            // 
            // richTextSourse
            // 
            this.richTextSourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextSourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextSourse.Location = new System.Drawing.Point(9, 206);
            this.richTextSourse.Name = "richTextSourse";
            this.richTextSourse.ReadOnly = true;
            this.richTextSourse.Size = new System.Drawing.Size(229, 115);
            this.richTextSourse.TabIndex = 1;
            this.richTextSourse.Text = "";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numericArraySize);
            this.panel2.Location = new System.Drawing.Point(8, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 55);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите количество \r\nэлементов массива";
            // 
            // numericArraySize
            // 
            this.numericArraySize.Location = new System.Drawing.Point(130, 16);
            this.numericArraySize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericArraySize.Name = "numericArraySize";
            this.numericArraySize.Size = new System.Drawing.Size(75, 20);
            this.numericArraySize.TabIndex = 0;
            this.numericArraySize.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rdbBest);
            this.panel1.Controls.Add(this.rdbRandom);
            this.panel1.Controls.Add(this.rdbWorst);
            this.panel1.Location = new System.Drawing.Point(8, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 104);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Характер коллекции";
            // 
            // rdbBest
            // 
            this.rdbBest.AutoSize = true;
            this.rdbBest.Location = new System.Drawing.Point(6, 76);
            this.rdbBest.Name = "rdbBest";
            this.rdbBest.Size = new System.Drawing.Size(147, 17);
            this.rdbBest.TabIndex = 6;
            this.rdbBest.TabStop = true;
            this.rdbBest.Text = "Коллекция упорядочена";
            this.rdbBest.UseVisualStyleBackColor = true;
            // 
            // rdbRandom
            // 
            this.rdbRandom.AutoSize = true;
            this.rdbRandom.Location = new System.Drawing.Point(6, 30);
            this.rdbRandom.Name = "rdbRandom";
            this.rdbRandom.Size = new System.Drawing.Size(134, 17);
            this.rdbRandom.TabIndex = 4;
            this.rdbRandom.TabStop = true;
            this.rdbRandom.Text = "Случайная генерация";
            this.rdbRandom.UseVisualStyleBackColor = true;
            // 
            // rdbWorst
            // 
            this.rdbWorst.AutoSize = true;
            this.rdbWorst.Location = new System.Drawing.Point(6, 53);
            this.rdbWorst.Name = "rdbWorst";
            this.rdbWorst.Size = new System.Drawing.Size(191, 17);
            this.rdbWorst.TabIndex = 5;
            this.rdbWorst.TabStop = true;
            this.rdbWorst.Text = "Коллекция обратно упорядочена";
            this.rdbWorst.UseVisualStyleBackColor = true;
            // 
            // btnCreateArray
            // 
            this.btnCreateArray.Location = new System.Drawing.Point(8, 177);
            this.btnCreateArray.Name = "btnCreateArray";
            this.btnCreateArray.Size = new System.Drawing.Size(229, 23);
            this.btnCreateArray.TabIndex = 2;
            this.btnCreateArray.Text = "Создать";
            this.btnCreateArray.UseVisualStyleBackColor = true;
            this.btnCreateArray.Click += new System.EventHandler(this.btnCreateArray_Click);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabSorting);
            this.tab.Controls.Add(this.TabSearching);
            this.tab.Controls.Add(this.tabHash);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(662, 454);
            this.tab.TabIndex = 0;
            // 
            // TabSearching
            // 
            this.TabSearching.Controls.Add(this.label7);
            this.TabSearching.Controls.Add(this.numericSearchBar);
            this.TabSearching.Controls.Add(this.panel5);
            this.TabSearching.Controls.Add(this.richResultTab2);
            this.TabSearching.Controls.Add(this.richInfoTab2);
            this.TabSearching.Controls.Add(this.panel4);
            this.TabSearching.Controls.Add(this.panel6);
            this.TabSearching.Controls.Add(this.btnCreateArrayTab2);
            this.TabSearching.Location = new System.Drawing.Point(4, 22);
            this.TabSearching.Name = "TabSearching";
            this.TabSearching.Padding = new System.Windows.Forms.Padding(3);
            this.TabSearching.Size = new System.Drawing.Size(654, 428);
            this.TabSearching.TabIndex = 3;
            this.TabSearching.Text = "Поиск";
            this.TabSearching.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Искомое значение";
            // 
            // numericSearchBar
            // 
            this.numericSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericSearchBar.Location = new System.Drawing.Point(137, 325);
            this.numericSearchBar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericSearchBar.Name = "numericSearchBar";
            this.numericSearchBar.Size = new System.Drawing.Size(97, 20);
            this.numericSearchBar.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.btnLinearSearch);
            this.panel5.Controls.Add(this.btnBinarySearch);
            this.panel5.Location = new System.Drawing.Point(10, 353);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(228, 65);
            this.panel5.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Рассмотренные алгоритмы поиска";
            // 
            // btnLinearSearch
            // 
            this.btnLinearSearch.Location = new System.Drawing.Point(5, 30);
            this.btnLinearSearch.Name = "btnLinearSearch";
            this.btnLinearSearch.Size = new System.Drawing.Size(100, 23);
            this.btnLinearSearch.TabIndex = 9;
            this.btnLinearSearch.Text = "Линейный";
            this.btnLinearSearch.UseVisualStyleBackColor = true;
            this.btnLinearSearch.Click += new System.EventHandler(this.btnLinearSearch_Click);
            // 
            // btnBinarySearch
            // 
            this.btnBinarySearch.Location = new System.Drawing.Point(124, 30);
            this.btnBinarySearch.Name = "btnBinarySearch";
            this.btnBinarySearch.Size = new System.Drawing.Size(97, 23);
            this.btnBinarySearch.TabIndex = 11;
            this.btnBinarySearch.Text = "Бинарный";
            this.btnBinarySearch.UseVisualStyleBackColor = true;
            this.btnBinarySearch.Click += new System.EventHandler(this.btnBinarySearch_Click);
            // 
            // richResultTab2
            // 
            this.richResultTab2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richResultTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richResultTab2.Location = new System.Drawing.Point(244, 6);
            this.richResultTab2.Name = "richResultTab2";
            this.richResultTab2.ReadOnly = true;
            this.richResultTab2.Size = new System.Drawing.Size(402, 412);
            this.richResultTab2.TabIndex = 13;
            this.richResultTab2.Text = "";
            // 
            // richInfoTab2
            // 
            this.richInfoTab2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richInfoTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richInfoTab2.Location = new System.Drawing.Point(9, 156);
            this.richInfoTab2.Name = "richInfoTab2";
            this.richInfoTab2.ReadOnly = true;
            this.richInfoTab2.Size = new System.Drawing.Size(229, 163);
            this.richInfoTab2.TabIndex = 1;
            this.richInfoTab2.Text = "";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.nmrArrSizeTab2);
            this.panel4.Location = new System.Drawing.Point(8, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 55);
            this.panel4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Выберите количество \r\nэлементов массива";
            // 
            // nmrArrSizeTab2
            // 
            this.nmrArrSizeTab2.Location = new System.Drawing.Point(130, 16);
            this.nmrArrSizeTab2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrArrSizeTab2.Name = "nmrArrSizeTab2";
            this.nmrArrSizeTab2.Size = new System.Drawing.Size(75, 20);
            this.nmrArrSizeTab2.TabIndex = 0;
            this.nmrArrSizeTab2.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.rdbUnsorted);
            this.panel6.Controls.Add(this.rdbSorted);
            this.panel6.Location = new System.Drawing.Point(8, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(229, 54);
            this.panel6.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Характер \r\nколлекции\r\n";
            // 
            // rdbUnsorted
            // 
            this.rdbUnsorted.AutoSize = true;
            this.rdbUnsorted.Location = new System.Drawing.Point(72, 26);
            this.rdbUnsorted.Name = "rdbUnsorted";
            this.rdbUnsorted.Size = new System.Drawing.Size(159, 17);
            this.rdbUnsorted.TabIndex = 6;
            this.rdbUnsorted.TabStop = true;
            this.rdbUnsorted.Text = "Коллекция неупорядочена";
            this.rdbUnsorted.UseVisualStyleBackColor = true;
            this.rdbUnsorted.CheckedChanged += new System.EventHandler(this.rdbUnsorted_CheckedChanged);
            // 
            // rdbSorted
            // 
            this.rdbSorted.AutoSize = true;
            this.rdbSorted.Location = new System.Drawing.Point(72, 3);
            this.rdbSorted.Name = "rdbSorted";
            this.rdbSorted.Size = new System.Drawing.Size(147, 17);
            this.rdbSorted.TabIndex = 5;
            this.rdbSorted.TabStop = true;
            this.rdbSorted.Text = "Коллекция упорядочена";
            this.rdbSorted.UseVisualStyleBackColor = true;
            // 
            // btnCreateArrayTab2
            // 
            this.btnCreateArrayTab2.Location = new System.Drawing.Point(8, 127);
            this.btnCreateArrayTab2.Name = "btnCreateArrayTab2";
            this.btnCreateArrayTab2.Size = new System.Drawing.Size(229, 23);
            this.btnCreateArrayTab2.TabIndex = 2;
            this.btnCreateArrayTab2.Text = "Создать";
            this.btnCreateArrayTab2.UseVisualStyleBackColor = true;
            this.btnCreateArrayTab2.Click += new System.EventHandler(this.btnCreateArrayTab2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 454);
            this.Controls.Add(this.tab);
            this.MinimumSize = new System.Drawing.Size(647, 411);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Алгоритмы сортировки и поиска. Поиск хешированием.            Сине-Никольский А.А" +
    ".";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.tabHash.ResumeLayout(false);
            this.tabHash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.tabSorting.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericArraySize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab.ResumeLayout(false);
            this.TabSearching.ResumeLayout(false);
            this.TabSearching.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSearchBar)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrArrSizeTab2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabSorting;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.RichTextBox richSteps;
        private System.Windows.Forms.RichTextBox richTextSourse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericArraySize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbBest;
        private System.Windows.Forms.RadioButton rdbRandom;
        private System.Windows.Forms.RadioButton rdbWorst;
        private System.Windows.Forms.Button btnCreateArray;
        private System.Windows.Forms.TabPage TabSearching;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericSearchBar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLinearSearch;
        private System.Windows.Forms.Button btnBinarySearch;
        private System.Windows.Forms.RichTextBox richResultTab2;
        private System.Windows.Forms.RichTextBox richInfoTab2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmrArrSizeTab2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbUnsorted;
        private System.Windows.Forms.RadioButton rdbSorted;
        private System.Windows.Forms.Button btnCreateArrayTab2;
        private System.Windows.Forms.TabPage tabHash;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richINfoTab3;
    }
}

