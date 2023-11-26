namespace MySpace
{
    interface IOutput
    {
        void Show();
        void Show(string info);
    }

    interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }

    interface ISort
    {
        void SortAsc();
        void SortDesc();
    }
    class MyArray : IOutput, IMath, ISort
    {
        private int[] data;

        public MyArray(int[] array)
        {
            data = array;
        }

        public void Show()
        {
            Console.WriteLine("Array elements:");
            foreach (int num in data)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine($"Displaying information: {info}");
        }

        public int Max()
        {
            int max = data[0];
            foreach (int value in data)
            {
                if (value > max)
                {
                    max = value;
                }
            }
            return max;
        }

        public int Min()
        {
            int min = data[0];
            foreach (int value in data)
            {
                if (value < min)
                {
                    min = value;
                }
            }
            return min;
        }

        public float Avg()
        {
            int sum = 0;
            foreach (int value in data)
            {
                sum += value;
            }
            return (float)sum / data.Length;
        }

        public bool Search(int valueToSearch)
        {
            foreach (int value in data)
            {
                if (value == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }

        public void SortAsc()
        {
            Array.Sort(data);
            Console.WriteLine("Array sorted in ascending order.");
        }

        public void SortDesc()
        {
            Array.Sort(data);
            Array.Reverse(data);
            Console.WriteLine("Array sorted in descending order.");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            int[] myNumbers = { 5, 10, 3, 8, 15 };

            MyArray myArray = new MyArray(myNumbers);

            myArray.Show();
            myArray.Show("Additional Message");

            Console.WriteLine($"Maximum: {myArray.Max()}");
            Console.WriteLine($"Minimum: {myArray.Min()}");
            Console.WriteLine($"Average: {myArray.Avg():F2}");

            int valueToSearch = 8;
            if (myArray.Search(valueToSearch))
            {
                Console.WriteLine($"{valueToSearch} found in the array.");
            }
            else
            {
                Console.WriteLine($"{valueToSearch} not found in the array.");
            }

            myArray.SortAsc();
            myArray.Show();

            myArray.SortDesc();
            myArray.Show();
        }
    }
}
