using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ExamTaskAlgorythmAndSearching
{
    public partial class MainForm : Form
    {
        private static readonly Random Random = new Random();
        private int[] _array;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnBubbleSort.Enabled = false;
            btnInsertionSort.Enabled = false;
            btnQuickSort.Enabled = false;
            btnSelectionSort.Enabled = false;
            rdbRandom.Checked = true;
            richTextSourse.Text = "Выберите случай для сортированной коллекции и нажмите\"Создать\"";
            richSteps.Text = "Здесь будут отображены итоги сортировки";

            btnLinearSearch.Enabled = false;
            btnBinarySearch.Enabled = false;
            rdbSorted.Checked = true;
            richInfoTab2.Text = "Выберите структуру коллекции и нажмите\"Создать\"";
            richResultTab2.Text = "Здесь будут отображены итоги поиска";
            numericSearchBar.Value = Random.Next(0, 1000);
            InitialGrid();

            richINfoTab3.Text =
                @"Hash-таблица - это структура данных, основанная на массиве, запись в который 
осуществляется не последовательно, а исходя из Hash-кода помещаемого узла. В таблице отображены исходные записи. Hash-код генерируется по полю Имя.";

        }

        #region Tab1Sort
        StringBuilder str2 = new StringBuilder();
        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            richTextSourse.Text = string.Empty;
            richSteps.Text = string.Empty;
            str2.Length = 0;
            str2.Capacity = 0;
            btnBubbleSort.Enabled = true;
            btnInsertionSort.Enabled = true;
            btnQuickSort.Enabled = true;
            btnSelectionSort.Enabled = true;

            FillArray();
            StringBuilder str = new StringBuilder();
            str.Append("Исходная коллекция: " + Environment.NewLine);
            foreach (var item in _array)
            {
                str.Append(item + " ");
            }
            richTextSourse.Text = str.ToString();

        }

        private void FillArray()
        {
            _array = new int[(int)numericArraySize.Value];

            if (rdbRandom.Checked)
            {
                for (int i = 0; i < _array.Length; i++)
                {
                    _array[i] = Random.Next(0, 100);
                }
            }
            else if (rdbBest.Checked)
            {
                for (int i = 0; i < _array.Length; i++)
                {
                    _array[i] = i;
                }
            }
            else if (rdbWorst.Checked)
            {
                for (int i = 0, j = _array.Length; i < _array.Length && j > 0; i++, j--)
                {
                    _array[i] = j;
                }
            }
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            int[] arr = new int[_array.Length];
            _array.CopyTo(arr, 0);

            DateTime start, en;
            TimeSpan result;
            start = DateTime.Now;
            int st, end;
            int count = 0;
            int cycle = 0;
            StringBuilder str = new StringBuilder();
            str.Append("Пузырьковая сортировка" + Environment.NewLine);
            for (end = arr.Length - 1; end > 0; end--)
            {
                for (st = 0; st < end; st++)
                {
                    count++;
                    if (arr[st] >= arr[st + 1])
                    {
                        var tmp = arr[st];
                        arr[st] = arr[st + 1];
                        arr[st + 1] = tmp;

                        cycle++;
                    }
                }
            }

            en = DateTime.Now;
            result = en - start;
            str.Append(Environment.NewLine);
            str.Append("Результат сортировки:" + Environment.NewLine);


            str.Append(
                string.Format("Количество сравнений: {0:0,0}\nВремя сортировки: {1}\nКоличество перестановок: {2:0,0}", count, result, cycle));
            str2.Append(str + Environment.NewLine + Environment.NewLine);
            richSteps.Text = str2.ToString();

        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            int[] arr = new int[_array.Length];
            _array.CopyTo(arr, 0);

            DateTime start, en;
            TimeSpan result;
            int i, j, min;
            int count = 0;
            int cycle = 0;
            StringBuilder str = new StringBuilder();

            str.Append("Сортировка выбором" + Environment.NewLine);
            str.Append(Environment.NewLine);
            start = DateTime.Now;

            for (i = 0; i < arr.Length; i++)
            {
                min = i;
                for (j = i + 1; j < arr.Length; j++)
                {
                    count++;
                    if (arr[min] > arr[j])
                    {
                        cycle++;
                        min = j;
                    }
                }
                if (arr[i] > arr[min])
                {
                    int tmp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = tmp;
                    cycle++;
                }
            }

            str.Append("Результат сортировки:" + Environment.NewLine);
            richSteps.Text = str.ToString();
            en = DateTime.Now;
            result = en - start;
            
            str.Append(
                string.Format("Количество сравнений: {0:0,0}\nВремя сортировки: {1}\nКоличество перестановок: {2:0,0}", count, result, cycle));
            str2.Append(str + Environment.NewLine + Environment.NewLine);

            richSteps.Text = str2.ToString();
        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            int[] arr = new int[_array.Length];
            _array.CopyTo(arr, 0);

            DateTime start, en;
            TimeSpan result;
            int i, o, tmp;
            int count = 0;
            int cycle = 0;
            StringBuilder str = new StringBuilder();

            str.Append("Сортировка вставками" + Environment.NewLine);
            start = DateTime.Now;
            for (o = 1; o < arr.Length; o++)
            {
                i = o;
                tmp = arr[o];
                while (i > 0 && arr[i - 1] > tmp)
                {
                    count++;
                    cycle++;
                    arr[i] = arr[i - 1];
                    --i;
                }

                arr[i] = tmp;
                count++;
            }

            str.Append(Environment.NewLine);
            str.Append("Результат сортировки:" + Environment.NewLine);
            richSteps.Text = str.ToString();
            en = DateTime.Now;
            result = en - start;

            str.Append(
                string.Format("Количество сравнений: {0:0,0}\nВремя сортировки: {1}\nКоличество перестановок: {2:0,0}", count, result, cycle));
            str2.Append(str + Environment.NewLine + Environment.NewLine);

            richSteps.Text = str2.ToString();
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            int[] arr = new int[_array.Length];
            _array.CopyTo(arr, 0);
            StringBuilder str = new StringBuilder();

            str.Append("Быстрая сортировка" + Environment.NewLine);
            DateTime start, en;
            TimeSpan result;
            start = DateTime.Now;

            Quicksort(arr, 0, arr.Length - 1);

            en = DateTime.Now;
            result = en - start;

            str.Append(Environment.NewLine);
            str.Append("Результат сортировки:" + Environment.NewLine);

            str.Append(
                string.Format("Количество сравнений: {0:0,0}\nВремя сортировки: {1}\nКоличество перестановок: {2:0,0}", compar, result, swap));
            str2.Append(str + Environment.NewLine + Environment.NewLine);

            richSteps.Text = str2.ToString();
        }

        private int Partition(int[] array, int start, int end, ref int count, ref int cycle)
        {
            int temp;//swap helper
            int marker = start;//divides left and right subarrays
            for (int i = start; i <= end; i++)
            {
                count++;
                if (array[i] < array[end]) //array[end] is pivot
                {
                    temp = array[marker]; // swap
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                    cycle++;
                }
            }
            //put pivot(array[end]) between left and right subarrays
            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;
            cycle++;
            return marker;
        }

        public int compar = 0;
        public int swap = 0;

        void Quicksort(int[] array, int start, int end)
        {
            compar++;

            if (start >= end)
            {
                return;
            }

            int pivot = Partition(array, start, end, ref compar, ref swap);
            Quicksort(array, start, pivot - 1);
            Quicksort(array, pivot + 1, end);
        }


        #endregion

        #region Tab2Search
        private void btnCreateArrayTab2_Click(object sender, EventArgs e)
        {
            richResultTab2.Text = string.Empty;
            richInfoTab2.Text = string.Empty;

            if (rdbSorted.Checked)
                btnBinarySearch.Enabled = true;
            btnLinearSearch.Enabled = true;

            _array = new int[(int)nmrArrSizeTab2.Value];

            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = Random.Next(0, 5000);
            }
            if (rdbSorted.Checked)
            {
                Array.Sort(_array);
            }

            StringBuilder str = new StringBuilder();
            str.Append("Исходная коллекция: " + Environment.NewLine);
            foreach (var item in _array)
            {
                str.Append(item + " ");
            }
            richInfoTab2.Text = str.ToString();
        }

        private void btnLinearSearch_Click(object sender, EventArgs e)
        {
            richResultTab2.Text = First().Append(FindAll()).ToString();
        }

        private StringBuilder First()
        {
            int count = 0;
            StringBuilder str = new StringBuilder();
            str.Append(@"Линейный поиск осуществляется перебором всех элементов списка по порядку." + Environment.NewLine);
            str.Append(@"Поиск элемента " + numericSearchBar.Value + Environment.NewLine);
            str.Append(Environment.NewLine + "Поиск до первого совпадения. " + Environment.NewLine);
            foreach (var i in _array)
            {
                count++;
                //if (rdbSorted.Checked && _array[i] > (int)numericSearchBar.Value)
                //    break;
                if (i == (int)numericSearchBar.Value)
                {
                    return str.Append(string.Format("Элемент найден.\nКоличество сравнений: " + count + Environment.NewLine));
                }
            }
            return str.Append(string.Format("Элемент не найден.\nКоличество сравнений: " + count + Environment.NewLine));
        }

        private StringBuilder FindAll()
        {
            int count = 0;
            int quantity = 0;
            StringBuilder str = new StringBuilder();
            str.Append(Environment.NewLine + "Поиск всех элементов. " + Environment.NewLine);
            for (int i = 0; i < _array.Length; i++)
            {
                count++;
                if (_array[i] == (int)numericSearchBar.Value)
                {
                    quantity++;
                }
                if (rdbSorted.Checked && _array[i] > (int)numericSearchBar.Value)
                    break;
            }
            return quantity == 0 ? str.Append(string.Format("Элемент не найден.\nКоличество сравнений " + count + Environment.NewLine)) :
                str.Append(string.Format("Элемент найден.\nКоличество сравнений: " + count + ", количесвто совпадений: " + quantity + Environment.NewLine));
            ;
        }

        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            string s =
                "Алгоритм Двоичного поиска:\n\nОпределение значения элемента в середине структуры данных. \nПолученное значение сравнивается с ключом."
                + "Если ключ меньше значения середины, то поиск осуществляется в первой половине элементов, иначе — во второй."
                + "\nПоиск сводится к тому, что вновь определяется значение серединного элемента в выбранной половине и сравнивается с ключом."
                + "\nПроцесс продолжается до тех пор, пока не будет найден элемент со значением ключа или не станет пустым интервал для поиска.\n\n";
            richResultTab2.Text = s + BinarySearch(_array, (int)numericSearchBar.Value);
        }

        private string BinarySearch(int[] a, int x)
        {
            StringBuilder str = new StringBuilder();
            int comparer = 0;

            comparer++;
            if ((a.Length == 0) || (x < a[0]) || (x > a[a.Length - 1]))
                return string.Format("Элемент не найден. Количество сравнений: " + comparer);

            int first = 0;
            int last = a.Length;

            comparer++;
            while (first < last)
            {
                int mid = first + (last - first) / 2;

                comparer++;
                if (x <= a[mid])
                    last = mid;
                else
                    first = mid + 1;
            }

            if (a[last] == x)
                return string.Format("Элемент найден. Количество сравнений: " + comparer);

            return string.Format("Элемент не найден. Количество сравнений: " + comparer);
        }

        private void rdbUnsorted_CheckedChanged(object sender, EventArgs e)
        {
            if (_array == null)
                return;
            btnBinarySearch.Enabled = rdbSorted.Checked;
        }


        #endregion

        #region HashTable

        HashTable ht = new HashTable(100);

        public class DataItem
        {
            public string Data { get; set; }
            public int Hash { get; set; }
            public int Index { get; set; }

            public DataItem(string data)
            {
                Data = data;
            }

            public override int GetHashCode()
            {
                return Data.GetHashCode() & 0x7FFFFFFF;
            }
        }

        public class HashTable : IEnumerable
        {
            private DataItem[] hashArray;
            private int _arraySize;
            public int ArraySize
            {
                get { return _arraySize; }
                set
                {
                    if (value < 5)
                        _arraySize = 5;
                    else
                        _arraySize = value;
                }
            }

            public List<DataItem> ToList()
            {
                List<DataItem> list = new List<DataItem>();
                foreach (var item in hashArray)
                {
                    if(item != null)
                        list.Add(item);
                }
                return list;
            }

            public IEnumerator GetEnumerator()
            {
                foreach (var i in hashArray)
                {
                    yield return i;
                }
            }

            public HashTable(int size)
            {
                ArraySize = size;
                hashArray = new DataItem[ArraySize];
            }

            public void InsertData(string data)
            {
                var node = new DataItem(data);
                int hashCode = node.GetHashCode();
                int index = hashCode % ArraySize;

                if (hashArray[index] == null)
                {
                    hashArray[index] = node;
                    node.Hash = hashCode;
                    node.Index = index;
                }
                else
                {
                    if (MessageBox.Show("Ячейка занята. Перезаписать?", "Предупреждение", MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        hashArray[index] = node;
                        node.Hash = hashCode;
                        node.Index = index;
                    }
                }
            }

            public void DeleteData(string key)
            {
                int hash = key.GetHashCode();
                int index = hash % ArraySize;
                if (hashArray[index] == null)
                {
                    MessageBox.Show("Ячейка пуста.", "Предупреждение",  MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show($"Элемент с ключом {hashArray[index].Data} успешно удален", "Предупреждение",  MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                hashArray[index] = null;
            }

            public DataItem SearchData(string key)
            {
                int hash = key.GetHashCode() & 0x7FFFFFFF;
                int index = hash % ArraySize;
                if (hashArray[index] == null)
                {
                    
                    return null;
                }
                return hashArray[index];
            }

        }

        public void InitialGrid()
        {
            ht.InsertData("Иванов Иван");
            ht.InsertData("Петров Петр");
            ht.InsertData("Сидоров Алексей");
            ht.InsertData("Андреев Николай");
            ht.InsertData("Юсупов Азамат");
            ht.InsertData("Алексеева Диана");
            ht.InsertData("Дайнарова Зинара");
            ht.InsertData("Самойлова Марина");
            ht.InsertData("Иранова Виктория");
            RefreshGrid(ht);
            
        }

        public void RefreshGrid(HashTable ht)
        {
            List<DataItem> list = ht.ToList();
            var query = list.Where(x => x.Data != null).OrderBy(x => x.Index).ToList();

            grid.DataSource = query.Select(x => new
            {
                x.Data,
                x.Index,
                x.Hash
            }).OrderBy(x => x.Index).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ht.InsertData(txtSearchBar.Text);
            RefreshGrid(ht);

            richINfoTab3.Text =
                @"Запись в таблицу начинается с анализа введенного строкового значения. 
Выполняется генерация Hash-кода с отбросом последнего бита, дабы 
исключить отрицательное значение целевого индекса в дальнейших вычислениях.
После вычисления hash-кода осуществляется вычисление индекса путем деления с остатком hash-кода на размер исходного массива. 
Остаток от деления и будет индексом целевой ячейки массива.";
            txtSearchBar.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            richINfoTab3.Text =
                @"Поиск в таблице выполняется так же, как и добавление в таблицу. После вычисления Hash-суммы и целевой ячейки массива осуществляется проверка на наличие в ней данных. 
Если данные есть - элемент найден, и наоборот, если ячейка пуста";
            var item = ht.SearchData(txtSearchBar.Text);
            if (item == null)
            {
                MessageBox.Show("Элемент не найден", "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show(String.Format($"Элемент найден\nИмя: {item.Data}\nЗанимает ячейку в массиве {item.Index} из {ht.ArraySize}\nХеш-код: {item.Hash}"), "Поиск", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            txtSearchBar.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var item = ht.SearchData(txtSearchBar.Text);
            if (item == null)
            {
                MessageBox.Show("Элемент не найден", "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show(
                    String.Format(
                        $"Удалить элемент\nИмя: {item.Data}\nЗанимает ячейку в массиве {item.Index} из {ht.ArraySize}\nХеш-код: {item.Hash}?"),
                    "Удаление", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
            {
                ht.DeleteData(txtSearchBar.Text);
                RefreshGrid(ht);
            }
            txtSearchBar.Text = "";
        }

        #endregion

        


    }
}
