public class Item {
    public int weight;
    public int value;
    public int index;

    public Item(int value, int weight, int index) {
        this.weight = weight;
        this.value = value;
        this.index = index;
    }

    @Override
    public String toString() {
        return "Item " + index +": value = " + value + ", weight = " + weight;
    }
}
