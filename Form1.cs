namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        textBox1.TextChanged += TextBox1_TextChanged;
    }

    private void TextBox1_TextChanged(object? sender, EventArgs e)
    {
        listBox1.Items.Clear();

        bool success = long.TryParse(textBox1.Text, out long number);

        if (!success) return;

        List<int> divisors = [];

        for (long x = 1; x < number / 2; x++)
        {
            if (number % x == 0)
            {
                listBox1.Items.Add(x);
            }

            
        }
        listBox1.Items.Add(number);
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        
    }
}
