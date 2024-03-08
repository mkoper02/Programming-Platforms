namespace KnapsackProblem {
    internal class Problem {
        public List<Item> items;

        // constructor with random items
        public Problem(int n, int seed) {
            Random random = new(seed);
            items = new List<Item>(n);

            for (int i = 0; i < n; i++) {
                items.Add(new Item(random.Next(1, 10), random.Next(1, 10), i));
            }
        }

        // constructor for a given instance
        public Problem(List<Item> items) {
            this.items = items;
        }

        private double Ratio(Item item) => (double)item.value / item.weight;
        
        public Result Solve(int capacity) {
            List<Item> sorted_items = items.OrderByDescending(item => Ratio(item)).ToList();
            List<Item> result = [];

            foreach (Item item in sorted_items) {
                if (item.weight <= capacity) {
                    result.Add(item);
                    capacity -= item.weight;
                }
            }

            return new Result(result);
        }
    }
}
