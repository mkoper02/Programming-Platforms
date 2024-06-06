import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Random;

class ProblemTest {
    // Check if at least one item meets the constraints then at least one item is returned
    @Test
    public void SolveResult_ItemsLighterThanCapacity_ReturnNotEmptyList() {
        List<Item> items = new ArrayList<Item>();
        Random random = new Random();

        for (int i = 0; i < 5; i++) {
            items.add(new Item(random.nextInt(1, 10) + 1, random.nextInt(1, 10) + 1, i));
        }

        assertFalse(new Problem(items).Solve(20).items.isEmpty());
    }

    // Check if no item meets conditions an empty list is returned
    @Test
    public void SolveResult_ItemsHeavierThanCapacity_ReturnEmpty() {
        List<Item> items = new ArrayList<Item>();
        Random random = new Random();

        for (int i = 0; i < 5; i++) {
            items.add(new Item(random.nextInt(10, 20) + 1, random.nextInt(10, 20) + 1, i));
        }

        assertEquals(new Problem(items).Solve(5).items.size(), 0);
    }

    // Check if item's weight and value in within bounds
    @Test
    public void Items_ItemsWeightAndValueWithinBounds_ReturnTrue() {
        List<Item> items = new ArrayList<Item>();
        Random random = new Random();

        for (int i = 0; i < 5; i++) {
            items.add(new Item(random.nextInt(1, 10) + 1, random.nextInt(1, 10) + 1, i));
        }

        for (Item item : items) {
            assertTrue(item.weight >= 1 && item.weight <= 10);
            assertTrue(item.value >= 1 && item.value <= 10);
        }
    }

    // Validate the result for a specific instance
    @Test
    public void Result_CheckSpecificInstance_ReturnTrue() {
        List<Item> items = Arrays.asList(
            new Item(20, 9, 0),
            new Item(1, 1, 1)
        );

        int[] resultIndex = {0, 0, 0, 0, 0, 1, 1, 1, 1, 1};
        Result result = new Problem(items).Solve(50);

        for (int i = 0; i < result.items.size(); i++) {
            assertEquals(result.items.get(i).index, resultIndex[i]);
        }
    }
}