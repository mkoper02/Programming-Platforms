using KnapsackProblem;

namespace KnapsackTests {
    [TestClass]
    public class UnitTest {

        // Check if at least one item meets the constraints then at least one item is returned
        [TestMethod]
        [DataRow(0, 10, 10)]
        [DataRow(10, 20, 20)]
        [DataRow (20, 30, 30)]
        public void SolveResult_ItemsLighterThanCapacity_ReturnNotEmptyList(int min_value, int max_value, int capacity) {
            List<Item> list = [];
            Random random = new();

            for (int i = 0; i < 5; i++) {
                list.Add(new Item(random.Next(min_value, max_value), random.Next(min_value, max_value), i));
            }

            Problem problem = new(list);
            Assert.IsTrue(problem.Solve(capacity).items.Count >= 1);
        }

        // Check if no item meets conditions an empty list is returned
        [TestMethod]
        [DataRow(10, 20, 5)]
        [DataRow(20, 30, 10)]
        [DataRow(30, 50, 25)]
        public void SolveResult_ItemsHeavierThanCapacity_ReturnEmpty(int min_value, int max_value, int capacity) {
            List<Item> list = [];
            Random random = new();

            for (int i = 0; i < 10; i++) {
                list.Add(new Item(random.Next(min_value, max_value), random.Next(min_value, max_value), i));
            }

            Assert.AreEqual(new Problem(list).Solve(capacity).items.Count, 0);
        }

        // Check whether the order of items affects the solution
        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(10, 20)]
        [DataRow(10, 35)]
        [DataRow(15, 50)]
        [DataRow(20, 80)]
        public void SolveResult_DifferentItemsOrder_NoDifference(int size, int capacity) {
            Problem problem1 = new(size);
            Problem problem2 = new(problem1.items.OrderBy(item => Random.Shared.Next()).ToList());

            CollectionAssert.AreEqual(problem1.Solve(capacity).items, problem2.Solve(capacity).items);
        }

        // Validate the result for a specific instance
        [TestMethod]
        public void TestMethod4() {
            List<Item> items = [new Item(5, 2, 0), new Item(2, 8, 1), new Item(9, 18, 2), new Item(6, 6, 3), new Item(7, 10, 4)];
            List<int> result_index = [ 0, 3, 4, 2, 1 ];

            Result result = new Problem(items).Solve(50);

            for (int i = 0; i < result.items.Count; i++) {
                Assert.AreEqual(result.items[i].index, result_index[i]);
            }
        }

        // Check if items with higher ratio are at the beginnig of the list
        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(10, 20)]
        [DataRow(10, 35)]
        [DataRow(15, 50)]
        [DataRow(20, 80)]
        public void TestMethod5(int size, int capacity) {
            Result result = new Problem(size).Solve(capacity);
            
            for (int i = 1; i < result.items.Count; i++) {
                Assert.IsTrue((result.items[i - 1].value / result.items[i - 1].weight) >= (result.items[i].value / result.items[i].weight));
            }
        }

        // Check if the total weight of items was summed up correctly
        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(10, 20)]
        [DataRow(15, 40)]
        [DataRow(20, 60)]
        [DataRow(25, 80)]
        public void TestMethod6(int size, int capacity) {
            Result result = new Problem(size).Solve(capacity);
            Assert.IsTrue(result.total_weight == result.items.Sum(item => item.weight));
        }

        // Check if given capacity is 0 then list should be empty
        [TestMethod]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(20)]
        [DataRow(30)]
        [DataRow(50)]
        public void SolveResut_CapacityIsZero_ReturnEmptyList(int size) {
            Result result = new Problem(size).Solve(0);
            Assert.IsTrue(result.items.Count == 0);
        }

        // Check if exception is thrown when size is negative
        [TestMethod]
        [DataRow(-1)]
        [DataRow(-5)]
        [DataRow(-10)]
        public void NegativeSizeGiven__ThrowException(int size) {
            Assert.ThrowsException<NegativeNumberException>(() => new Problem(size));
        }

        // Check if exception is thrown when capacity is negative
        [TestMethod]
        [DataRow(-1)]
        [DataRow(-5)]
        [DataRow(-10)]
        public void NegativeCapacityGiven__ThrowException(int capacity) {
            Assert.ThrowsException<NegativeNumberException>(() => new Problem(5).Solve(capacity));
        }
    }
}