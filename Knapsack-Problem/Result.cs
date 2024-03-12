namespace KnapsackProblem {
    internal class Result(List<Item> items) {
        public int total_weight { get; set; } = items.Sum(item => item.weight);
        public int total_value { get; set; } = items.Sum(item => item.value);
        public List<Item> items { get; set; } = items;

        public override string ToString() {
            string str = "Items: ";
            foreach (Item item in items) str += item.index.ToString() + " ";
            str += "\nTotal value: " + total_value;
            str += "\nTotal weight: " + total_weight;

            return str;
        }
    }
}
