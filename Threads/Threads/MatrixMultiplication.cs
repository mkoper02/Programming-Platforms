using System.Diagnostics;

namespace Threads {
    public class MatrixMultiplication {
        private readonly MyMatrix MatrixA;
        private readonly MyMatrix MatrixB;
        private MyMatrix ResultMatrix;

        public MatrixMultiplication(int size, int seed) {
            MatrixA = new MyMatrix(size, seed);
            MatrixB = new MyMatrix(size, seed + 1);
            ResultMatrix = new(new int[MatrixA.Matrix.GetLength(0), MatrixB.Matrix.GetLength(1)]);
        }

        public MatrixMultiplication(int size) {
            MatrixA = new MyMatrix(size);
            MatrixB = new MyMatrix(size);
            ResultMatrix = new(MatrixA.Matrix.GetLength(0), MatrixB.Matrix.GetLength(1));
        }

        private void Multiply(int startRow, int endRow) {
            for (var i = startRow; i < endRow; i++)
                for (var j = 0; j < MatrixA.Matrix.GetLength(1); j++) {
                    ResultMatrix.Matrix[i, j] = 0;
                    for (var k = 0; k < MatrixB.Matrix.GetLength(0); k++)
                        ResultMatrix.Matrix[i, j] += MatrixA.Matrix[i, k] * MatrixB.Matrix[k, j];
                }
        }

        public void MultiplyMatricesWithThreads(int threadsNumber) {
            var rowsPerThread = ResultMatrix.Matrix.GetLength(0) / threadsNumber;
            var threads = new Thread[threadsNumber];

            var stopwatch = Stopwatch.StartNew();

            for (var i = 0; i < threadsNumber; i++) {
                var startRow = i * rowsPerThread;
                var endRow = (i == threadsNumber - 1) ? ResultMatrix.Matrix.GetLength(0) : ((i + 1) * rowsPerThread);

                threads[i] = new Thread(() => Multiply(startRow, endRow));
                threads[i].Start();
            }

            foreach (var thread in threads)
                thread.Join();

            stopwatch.Stop();
            Console.WriteLine($"Time required to solve matrix multiplication using {threadsNumber} thread(s) is equal: {stopwatch.ElapsedMilliseconds} ms");
        }

        public void MultiplyMatricesWithParrallel(int threadsNumber) {
            var stopwatch = Stopwatch.StartNew();

            Parallel.For(
                0,
                ResultMatrix.Matrix.GetLength(0),
                //new ParallelOptions { MaxDegreeOfParallelism = threadsNumber },
                i => {
                    for (var j = 0; j < MatrixA.Matrix.GetLength(1); j++) {
                        ResultMatrix.Matrix[i, j] = 0;
                        for (var k = 0; k < MatrixB.Matrix.GetLength(0); k++)
                            ResultMatrix.Matrix[i, j] += MatrixA.Matrix[i, k] * MatrixB.Matrix[k, j];
                    }
                });

            stopwatch.Stop();
            Console.WriteLine($"Time required to solve matrix multiplication using Parrallel is equal: {stopwatch.ElapsedMilliseconds} ms");
        }

        public void ShowMatrices() {
            Console.WriteLine("Matrix A:");
            Console.WriteLine(MatrixA);
            Console.WriteLine("Matrix B:");
            Console.WriteLine(MatrixB);
            Console.WriteLine("Result Matrix:");
            Console.WriteLine(ResultMatrix);
        }
    }
}
