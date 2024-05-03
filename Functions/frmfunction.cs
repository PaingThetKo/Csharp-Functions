namespace Functions
{
    public partial class frmfunction : Form
    {
        public frmfunction()
        {
            InitializeComponent();
        }

        private void txtgreeting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String greetingInput = txtgreeting.Text.ToString();
            funSayHello(greetingInput, "Greeting");
        }

        public void funSayHello(String greeting, String title)
        {
            MessageBox.Show(greeting, title);
        }

        public int funSum(int a,int b)
        {
            int sum = 0;
            sum = a + b;
            return sum;
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int total = 0;
            a = int.Parse(txta.Text.ToString());
            b = int.Parse(txtb.Text.ToString());
            total = funSum(a,b);
            txtsum.Text = total.ToString();
        }
    }
}
