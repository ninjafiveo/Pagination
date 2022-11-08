namespace Pagination;

public partial class Page3 : ContentPage
{
	public Page3()
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