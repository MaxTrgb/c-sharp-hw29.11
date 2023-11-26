namespace MySpace
{
    // Define the ISort interface
    interface ISort
    {
        void SortAsc();
        void SortDesc();
    }

    // Implement the ISort interface in a class
    class SortingExample : ISort
    {
        private int[] numbers;

        // Constructor
        public SortingExample(int[] array)
        {
            numbers = array;
        }

        // Method to display array elements
        public void DisplayArray()
        {
            Console.WriteLine("Array elements:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        // Implement the SortAsc method
        public void SortAsc()
        {
            Array.Sort(numbers);
            Console.WriteLine("Array sorted in ascending order.");
        }

        // Implement the SortDesc method
        public void SortDesc()
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
            Console.WriteLine("Array sorted in descending order.");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            // Example usage of the ISort interface
            int[] arrayToSort = { 5, 2, 8, 1, 3 };

            // Create an object of the SortingExample class
            SortingExample sorter = new SortingExample(arrayToSort);

            sorter.DisplayArray();

            sorter.SortAsc();
            sorter.DisplayArray();

            sorter.SortDesc();
            sorter.DisplayArray();
        }
    }
}
