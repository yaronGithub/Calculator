namespace Calculator;

public partial class Ex : ContentPage
{
	public Ex()
	{
		InitializeComponent();

        myEntry.TextChanged += Ent_TextChanged;
	}

    private void Ent_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (myEntry.Text != "")
        {
            myLabel.Text = myEntry.Placeholder;
        }else
        {
            myLabel.Text = "";
        }
        if (!myEntry.Text.Contains('@') || myEntry.Text.Length < 10)
        {
            if (myEntry.Text != "")
            {
                errLabel.Text = "Bad Email";
            }else
            {
                errLabel.Text = "";
            }
        }else
        {
            errLabel.Text = "";
        }
    }
}