namespace WinFormsApp1
{
    using System.Diagnostics;
    public class ArrayHandler
    {
        private int[] arr;
        private int _length;

        // Конструктор без параметров
        public ArrayHandler()
        {
            this._length = 10; // Устанавливаем по умолчанию количество элементов в 10
            this.arr = new int[_length];
        }

        // Конструктор с параметрами
        public ArrayHandler(int length)
        {
            this._length = length;
            this.arr = new int[_length];
        }

        // Метод для заполнения массива
        public void FillArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < _length; i++)
            {
                this.arr[i] = rnd.Next(-100, 100);
            }
        }

        // Метод для отображения массива
        public int[] GetArray()
        {
            return this.arr;
        }

        public int fMax()
        {
            return this.arr.Max();
        }

        public int fMin()
        {
            return this.arr.Min();
        }

        public double Avg()
        {
            double summ = 0;
            for (int i = 0; i < _length; i++)
                summ += arr[i];
            return (summ / _length);
        }

        public string TtlSort()
        {
            bool check11 = Mas(this.arr);
            int[] CopyArr = CopyMas(this.arr);

            //пузыри
            Stopwatch st1 = new Stopwatch();
            st1.Start();
            int[] SortArr = SortWithGnome(this.arr);
            st1.Stop();

            //выбор
            Stopwatch st2 = new Stopwatch();
            st2.Start();
            ShakeSort(CopyArr);
            st2.Stop();
            if (check11)
            {
                check11 = Mas(SortArr);
            }
            return $"Время гномьей сортировки {st1.Elapsed.TotalSeconds}, a время перемешиванием {st2.Elapsed.TotalSeconds}";
        }

        static int[] CopyMas(int[] a)
        {
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }
            return b;
        }

        static int[] SortWithGnome(int[] arr)
        {
            int n = arr.Length;
            int index = 0;

            while (index < n)
            {
                if (index == 0)
                {
                    index++;
                }
                if (arr[index] >= arr[index - 1])
                {
                    index++;
                }
                else
                {
                    // Меняем местами элементы
                    int temp = arr[index];
                    arr[index] = arr[index - 1];
                    arr[index - 1] = temp;
                    index--;
                }
            }
            return arr;
        }

        static void ShakeSort(int[] array)
        {
            int end = array.Length - 1;
            int start = 0;
            int remember = 0;
            bool swapped = true;

            while (swapped)
            {
                swapped = false;

                for (int i = start; i < end; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        swapped = true;
                        remember = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = remember;
                    }
                }
                end--;

                for (int i = end; i > start; i--)
                {
                    if (array[i] < array[i - 1])
                    {
                        swapped = true;
                        remember = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = remember;
                    }
                }
                start++;
            }
        }

        static bool Mas(int[] arr)
        {
            if (arr.Length < 11)
            {
                Console.Write("Ваш массив: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.Write("\n");
                return true;
            }
            else
            {
                Console.WriteLine("Массив не может быть выведен на экран, так как длина массива больше 10");
                return false;
            }
        }
    }

}
