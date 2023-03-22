namespace NetworkFormsApp
{
    public partial class Form1 : Form
    {
        ISubject theSubject = new NetworkProviders();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ConcreteObserver(theSubject);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}