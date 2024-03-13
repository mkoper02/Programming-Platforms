using KnapsackProblem;

namespace KnapsackGui {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e) {
            if (!int.TryParse(textBoxNumbOfItems.Text, out int size) || !int.TryParse(textBoxSeed.Text, out int seed) || !int.TryParse(textBoxCapacity.Text, out int capacity)) {
                MessageBox.Show("Invalid data has been entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Problem problem = new(size, seed);
            Result result = problem.Solve(capacity);

            textBoxInstance.Text = problem.ToString();
            textBoxResult.Text = result.ToString();
        }
    }
}
