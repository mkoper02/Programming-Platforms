namespace Threads {
    internal class Program {
        static void Main() { 
            Console.WriteLine("Enter number of threads you want to use: ");
            var threadNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the seed: ");
            var seed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter size of the matrix: ");
            var matrixSize = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < 5; i++) {
                var result = new MatrixMultiplication(matrixSize, seed);
                result.MultiplyMatricesWithThreads(threadNumber);
                result.MultiplyMatricesWithParrallel(threadNumber);
                Console.WriteLine();
            }
        }
    }
}
