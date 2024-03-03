namespace FizzBuzz {
    internal class FizzBuzz {
        private int _limit;

        public FizzBuzz(int _limit) {
            this._limit = _limit;
        }

        public void display() {
            for (int i = 1; i <= _limit; i++) {
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }
        }
    }
}
