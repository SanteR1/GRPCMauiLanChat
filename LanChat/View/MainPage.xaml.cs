using LanChat.ViewModel;

namespace LanChat.View;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(MainViewModel viewModel/*Передать зависимость ViewModel*/)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

