using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using SimpleDataGrid.Models;

namespace SimpleDataGrid
{
    public partial class MainWindow : Window
    {
        public People ThePeople { get; } = new People();

        public MainWindow()
        {
            InitializeComponent();

            var bAddPerson = this.FindControl<Button>("bAddPerson");
            bAddPerson.Click += AddPerson_Click;
        }

        async private void AddPerson_Click(object? sender, RoutedEventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            await addPerson.ShowDialog(this);
            if (addPerson.resultDialog == true)
            {
                Person p = addPerson.itemPerson;
                ThePeople.Add(p);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
