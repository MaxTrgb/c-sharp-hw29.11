namespace MySpace
{
    interface IOutput
    {
        void Show();
        void Show(string info);
    }

    class OutputExample : IOutput
    {
        // Implement the Show method
        public void Show()
        {
            Console.WriteLine("Displaying information.");
        }

        public void Show(string info)
        {
            Console.WriteLine($"Displaying information: {info}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            OutputExample outputExample = new OutputExample();

            outputExample.Show();

            outputExample.Show("Additional Message");
        }
    }
}
