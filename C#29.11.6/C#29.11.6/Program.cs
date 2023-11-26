namespace MySpace
{
    interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }
    class MathOperations : IMath
    {
        private int[] dataContainer;

        public MathOperations(int[] container)
        {
            dataContainer = container;
        }

        public int Max()
        {
            int max = dataContainer[0];
            foreach (int value in dataContainer)
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
            int min = dataContainer[0];
            foreach (int value in dataContainer)
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
            foreach (int value in dataContainer)
            {
                sum += value;
            }
            return (float)sum / dataContainer.Length;
        }

        public bool Search(int valueToSearch)
        {
            foreach (int value in dataContainer)
            {
                if (value == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 3, 8, 15 };

            MathOperations mathOps = new MathOperations(numbers);

            Console.WriteLine($"Maximum: {mathOps.Max()}");
            Console.WriteLine($"Minimum: {mathOps.Min()}");
            Console.WriteLine($"Average: {mathOps.Avg():F2}");

            int valueToSearch = 8;
            if (mathOps.Search(valueToSearch))
            {
                Console.WriteLine($"{valueToSearch} found in the data container.");
            }
            else
            {
                Console.WriteLine($"{valueToSearch} not found in the data container.");
            }
        }
    }
}
