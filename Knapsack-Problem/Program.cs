namespace KnapsackProblem {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter the number of items: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the seed: ");
            int seed = int.Parse(Console.ReadLine());
            Problem problem = new(n, seed);

            foreach (Item item in problem.items) Console.WriteLine(item.ToString());

            Console.WriteLine("\nEnter the capacity: ");
            int capacity = int.Parse(Console.ReadLine());
            
            Result result = problem.Solve(capacity);
            Console.WriteLine(result.ToString());
        }
    }
}
