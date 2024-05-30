namespace Threads {
    public class MyMatrix {
        public int[,] Matrix;
        private readonly int RandRange = 10;

        public MyMatrix(int[,] Matrix) {
            this.Matrix = Matrix;
        }

        public MyMatrix(int size) {
            Matrix = new int[size, size];
            var random = new Random();

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    Matrix[i, j] = random.Next(RandRange);
        }

        public MyMatrix(int size, int seed) {
            Matrix = new int[size, size];
            var random = new Random(seed);

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    Matrix[i, j] = random.Next(RandRange);
        }

        public override string ToString() {
            string str = "";

            for (int i = 0; i < Matrix.GetLength(0); i++) {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                    str += $"{Matrix[i, j]} ";
                str += "\n";
            }

            return str;
        }
    }
}
