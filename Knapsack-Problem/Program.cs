namespace KnapsackProblem {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter the number of items: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the seed: ");
            int seed = Convert.ToInt32(Console.ReadLine());
            Problem problem = new(n, seed);

            foreach (Item item in problem.items) Console.WriteLine(item.ToString());

            Console.WriteLine("\nEnter the capacity: ");
            int capacity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(problem.Solve(capacity).ToString());
        }
    }
}
