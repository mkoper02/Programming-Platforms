namespace FizzBuzz {
    internal class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            FizzBuzz obj = new FizzBuzz(n);
            obj.display();
        }
    }
}
