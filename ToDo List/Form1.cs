namespace ToDo_List;

public partial class Form1 : Form
{
    private String newTask;

    public Form1() => InitializeComponent();

    // Exit the application when the quit button is pressed
    private void Quit_Click(object sender, EventArgs e) => Application.Exit();

    // Update the newTask string
    private void textBox1_TextChanged(object sender, EventArgs e) => newTask = newCheckbox.Text;

    private void Create_Click(object sender, EventArgs e)
    {
        // Adds the newTask string as a new checkList item
        checkList.Items.Add(newTask);
        // Resets the text input to nothing
        newCheckbox.Text = "";
    }
}