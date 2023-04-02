namespace Tree
{
    public partial class Form1 : Form
    {
        private IEvaluable tree;
        class RealtimeAsker : IAnswersSet
        {
            public bool getAnswer(string question)
            {
                return MessageBox.Show(question, "Выберите", MessageBoxButtons.YesNo) == DialogResult.Yes;
            }
        }
        public Form1(IEvaluable tree)
        {
            InitializeComponent();
            this.tree = tree;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            label.Text = tree.Evaluate(new RealtimeAsker()).ToString();
        }
    }
}