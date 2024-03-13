using System.Runtime.CompilerServices;
using System.Security;
[assembly: InternalsVisibleTo("KnapsackTests")]
[assembly: InternalsVisibleTo("KnapsackGui"), InternalsVisibleTo("GUI")]

namespace KnapsackProblem {
    internal class Problem {
        public List<Item> items { get; set; }

        // constructor with random items and given seed
        public Problem(int n, int seed) {
            if (n < 0) throw new NegativeNumberException("Given size is negative number! Size cannot be negative");

            Random random = new(seed);
            items = new List<Item>(n);

            for (int i = 0; i < n; i++) {
                items.Add(new Item(random.Next(1, 10), random.Next(1, 10), i));
            }
        }

        // constructor with random items
        public Problem(int n) {
            if (n < 0) { throw new NegativeNumberException("Given size is negative number! Size cannot be negative"); }

            Random random = new();
            items = new List<Item>(n);

            for (int i = 0; i < n; i++) {
                items.Add(new Item(random.Next(1, 10), random.Next(1, 10), i));
            }
        }

        // constructor for a given instance
        public Problem(List<Item> items) {
            this.items = items;
        }

        private static double Ratio(Item item) => (double)item.value / item.weight;
        
        public Result Solve(int capacity) {
            if (capacity < 0) { throw new NegativeNumberException("Given size is negative number! Size cannot be negative"); }

            List<Item> sorted_items = items.OrderByDescending(Ratio).ThenBy(item => item.index).ToList();
            List<Item> result = [];

            foreach (Item item in sorted_items) {
                if (item.weight <= capacity) {
                    result.Add(item);
                    capacity -= item.weight;
                }
            }

            return new Result(result);
        }

        public override string ToString() {
            string str = "";
            foreach (Item item in items) str += item.ToString();
            return str;
        }
    }

    class NegativeNumberException(string message) : Exception(message) {}
}
