namespace KnapsackProblem {
    internal class Item(int value, int weight, int index) {
        public int value { get; set; } = value;
        public int weight { get; set; } = weight;
        public int index { get; set; } = index;

        public override string ToString() {
            return "no." +  index + "\tv: " + value + "\tw:" + weight;
        }
    }
}
