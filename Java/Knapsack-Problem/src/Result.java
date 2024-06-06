import java.util.List;

public class Result {
    public int totalValue;
    public int totalWeight;
    public List<Item> items;

    public Result(List<Item> items) {
        this.items = items;

        totalValue = 0;
        totalWeight = 0;

        for (Item item : items) {
            totalValue += item.value;
            totalWeight += item.weight;
        }
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();

        sb.append("Total value: ").append(totalValue).append("\n");
        sb.append("Total weight: ").append(totalWeight).append("\n");
        sb.append("Items:\n");

        for (Item item : items) {
            sb.append(item.toString()).append("\n");
        }

        return sb.toString();
    }
}
