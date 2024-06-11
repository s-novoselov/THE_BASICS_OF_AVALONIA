using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using SimpleDataGrid.Models;
using System;
using System.Collections.ObjectModel;

namespace SimpleDataGrid
{
    public partial class MainWindow : Window
    {
        public static String mPath = AppDomain.CurrentDomain.BaseDirectory;
        public static String mDBPath = mPath + "Employee.db";
        private People _selectedValue;
        private Person SelectPerson = new Person();

        public People ThePeople { get; } = new People();

        public MainWindow()
        {
            InitializeComponent();

            var bAddPerson = this.FindControl<Button>("bAddPerson");
            bAddPerson.Click += AddPerson_Click;

            var gDataGrid = this.FindControl<DataGrid>("gDataGrid");
            gDataGrid.SelectionChanged += mSelectionChanged;

            var bEditPerson = this.FindControl<Button>("bEditPerson");
            bEditPerson.Click += EditPerson_Click;

            var bDeletePerson = this.FindControl<Button>("bDeletePerson");
            bDeletePerson.Click += DeletePerson_Click;
        }

        private void DeletePerson_Click(object? sender, RoutedEventArgs e)
        {
            if (SelectPerson != null)
            {
                string sql = String.Format("Delete from Person where EmployeeNumber = '{0}'", SelectPerson.EmployeeNumber);
                Database.Exec_SQL(sql);
                SelectPerson = null;
                ThePeople.FillPeople();
            }
        }

        async private void AddPerson_Click(object? sender, RoutedEventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            addPerson.mode = "insert";
            await addPerson.ShowDialog(this);
            if (addPerson.resultDialog == true)
            {
                //Person p = addPerson.itemPerson
                //ThePeople.Add(p);
                ThePeople.FillPeople();
            }
        }

        async private void EditPerson_Click(object? sender, RoutedEventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            addPerson.mode = "edit";
            addPerson.SelectPerson = SelectPerson;
            await addPerson.ShowDialog(this);
            if (addPerson.resultDialog == true)
            {
                ThePeople.FillPeople();
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        async private void mSelectionChanged(object? sender, SelectionChangedEventArgs e)
        {
            DataGrid grid = (DataGrid)sender;
            dynamic selected_row = grid.SelectedItem;
            SelectPerson = selected_row;
        }

    }
}
