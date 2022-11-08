namespace Pagination;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private void Btn_To_Page2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Page2());
    }

    private void Btn_To_Page3_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Page3());
    }

    private void Btn_To_Main_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new MainPage());
    }
}