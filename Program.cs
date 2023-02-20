namespace FileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating an instance of the BackgroundOperation class
            BackgroundOperation bgOperation = new BackgroundOperation();

            // creating a loop to keep the program running
            while (true)
            {
                // displaying the console user interface to the user
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Write \"Hello World\"");
                Console.WriteLine("2. Write Current Date");
                Console.WriteLine("3. Write OS Version");
                Console.WriteLine("4. EXIT");

                // reading the user input
                var option = Console.ReadLine();

                // checking the user input and executing the appropriate method
                switch (option)
                {
                    case "1":
                        // creating a task to execute the WriteToFileAsync method in the background and not block the main thread
                        var task1 = bgOperation.WriteToFileAsync("Hello World");
                        break;
                    case "2":
                        var task2 = bgOperation.WriteToFileAsync(DateTime.Now.ToString("dd-MM-yyyy"));
                        break;
                    case "3":
                        var task3 = bgOperation.WriteToFileAsync(Environment.OSVersion.VersionString);
                        break;
                    case "4":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option selected.");
                        break;
                }
            }
        }
    }
    public class BackgroundOperation
    {
        public async Task WriteToFileAsync(string message)
        {
            await Task.Delay(3000);
            await File.WriteAllTextAsync("tmp.txt", message);
        }
    }

}


