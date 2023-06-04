using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.Input;

namespace LanChat.ViewModel;

public partial class MainViewModel : BaseViewModel
{
    //public ObservableCollection<Monkey> Monkeys { get; } = new();
    //MonkeyService monkeyService;
    public MainViewModel(/*MonkeyService monkeyService*/)
    {
        Title = "lan Chats";
        /*this.monkeyService = monkeyService;*/
    }

    [RelayCommand]
    async Task GetMonkeysAsync1()
    {
        if (IsBusy)
            return;

        try
        {
            //IsBusy = true;
            //var monkeys = await monkeyService.GetMonkeys();

            //if (Monkeys.Count != 0)
            //    Monkeys.Clear();

            //foreach (var monkey in monkeys)
            //    Monkeys.Add(monkey);

        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to get monkeys: {ex.Message}");
            await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
        }
        finally
        {
            IsBusy = false;
        }

    }
}