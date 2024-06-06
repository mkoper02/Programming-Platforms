import java.util.Scanner;

public class Main {
    private static void gui() {
        new KnapsackGui();
    }

    private static void cli() {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter the number of items: ");
        int numberOfItems = scanner.nextInt();

        System.out.print("Enter the seed: ");
        int seed = scanner.nextInt();

        Problem problem = new Problem(numberOfItems, seed);

        for (Item item : problem.items) {
            System.out.println(item.toString());
        }

        System.out.print("\nEnter capacity: ");
        int capacity = scanner.nextInt();

        Result result = problem.Solve(capacity);
        System.out.println(result.toString());

        scanner.close();
    }

    public static void main(String[] args) {
        // cli();
        gui();
    }
}