using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiApp6;
public class MainPageViewModel : BindableBase
{
    private ObservableCollection<string> _items = new() { "First item", "Second item" };
    public ObservableCollection<string> Items 
    { 
        get { return _items; }
        set { SetProperty(ref _items, value, nameof(Items)); }
    }

    private int _counter;

    public Command AddItemCommand => new(AddItem);
    private void AddItem()
    {
        _counter++;
        Items.Add("Added item #" + _counter);

        //Workaround
        //var newList = Items.ToList();
        //Items = new(newList);
    }
}
