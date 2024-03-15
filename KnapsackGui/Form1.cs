using KnapsackProblem;

namespace KnapsackGui {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void ButtonRunClick(object sender, EventArgs e) {
            // check if size was given and is positive number
            if (!int.TryParse(textBoxNumbOfItems.Text, out int size) || size < 0) {
                MessageBox.Show("Invalid number of items has been entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNumbOfItems.BackColor = Color.Red;
                return;
            }

            textBoxNumbOfItems.BackColor = Color.White;

            // check if capacity was given and is positive number
            if (!int.TryParse(textBoxCapacity.Text, out int capacity) || capacity < 0) {
                MessageBox.Show("Invalid capacity has been entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCapacity.BackColor = Color.Red;
                return;
            }

            textBoxCapacity.BackColor = Color.White;

            Problem problem;

            if (string.IsNullOrEmpty(textBoxSeed.Text)) problem = new(size);
            else if (int.TryParse(textBoxSeed.Text, out int seed)) problem = new(size, seed);
            else {
                MessageBox.Show("Invalid seed has been entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSeed.BackColor = Color.Red;
                return;
            }

            textBoxSeed.BackColor = Color.White;

            Result result = problem.Solve(capacity);

            textBoxInstance.Text = problem.ToString();
            textBoxResult.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
