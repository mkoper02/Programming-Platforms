import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Problem {
    private final int lowerBound = 1;
    private final int upperBound = 10;
    public List<Item> items;

    public Problem(int numberOfItems, int seed, int lowerBound, int upperBound) {
        if (numberOfItems < lowerBound || numberOfItems > upperBound) {
            throw new IllegalArgumentException("Number of items must be between " + lowerBound + " and " + upperBound);
        }

        items = new ArrayList<Item>();
        Random random = new Random(seed);

        for (int i = 0; i < numberOfItems; i++) {
            items.add(new Item(random.nextInt(lowerBound, upperBound) + 1, random.nextInt(lowerBound, upperBound) + 1, i));
        }
    }

    public Problem(int numberOfItems, int seed) {
        if (numberOfItems < lowerBound || numberOfItems > upperBound) {
            throw new IllegalArgumentException("Number of items must be between 1 and 10");
        }

        items = new ArrayList<Item>();
        Random random = new Random(seed);

        
        for (int i = 0; i < numberOfItems; i++) {
            items.add(new Item(random.nextInt(lowerBound, upperBound) + 1, random.nextInt(lowerBound, upperBound) + 1, i));
        }
    }

    public Problem(int numberOfItems) {
        if (numberOfItems < lowerBound || numberOfItems > upperBound) {
            throw new IllegalArgumentException("Number of items must be between 1 and 10");
        }

        items = new ArrayList<Item>();
        Random random = new Random();

        for (int i = 0; i < numberOfItems; i++) {
            items.add(new Item(random.nextInt(lowerBound, upperBound) + 1, random.nextInt(lowerBound, upperBound) + 1, i));
        }
    } 

    public Problem(List<Item> items) {
        this.items = items;
    }

    private static double Ratio(Item item) {
        return (double) item.value / item.weight;
    }

    public Result Solve(int capacity) {
        if (capacity < 0) {
            throw new IllegalArgumentException("Capacity must be greater than or equal to 0");
        }

        List<Item> sortedItems = new ArrayList<Item>(items);
        sortedItems.sort((a, b) -> Double.compare(Ratio(b), Ratio(a)));

        List<Item> selectedItems = new ArrayList<Item>();

        for (Item item : sortedItems) {
            while (item.weight <= capacity) {
                selectedItems.add(item);
                capacity -= item.weight;
            }
        }

        return new Result(selectedItems);
    }
}
