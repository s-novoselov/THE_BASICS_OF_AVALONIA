using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using SimpleDataGrid.Models;

namespace SimpleDataGrid
{
    public partial class AddPerson : Window
    {
        public Person itemPerson;
        public bool resultDialog;

        public AddPerson()
        {
            InitializeComponent();

            var bSavePerson = this.FindControl<Button>("bSavePerson");
            bSavePerson.Click += SaveButton_Click;

            var bCancel = this.FindControl<Button>("bCancel");
            bCancel.Click += Cancel_Click;

#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void SaveButton_Click(object? sender, RoutedEventArgs e)
        {
            int departmentNumber = 0;
            bool saccessParseDN = int.TryParse(this.FindControl<TextBox>("tDepartmentNumber").Text, out departmentNumber);
            int DepartmentNumber = departmentNumber;

            int employeeNumber = 0;
            bool saccessParseEN = int.TryParse(this.FindControl<TextBox>("tEmployeeNumber").Text, out employeeNumber);
            int EmployeeNumber = employeeNumber;

            string DeskLocation = this.FindControl<TextBox>("tDeskLocation").Text;
            string FirstName = this.FindControl<TextBox>("tFirstName").Text;
            string LastName = this.FindControl<TextBox>("tLastName").Text;

            itemPerson = new Person();
            itemPerson.DepartmentNumber = DepartmentNumber;
            itemPerson.EmployeeNumber = EmployeeNumber;
            itemPerson.DeskLocation = DeskLocation;
            itemPerson.FirstName = FirstName;
            itemPerson.LastName = LastName;

            resultDialog = true;
            Close();
        }

        private void Cancel_Click(object? sender, RoutedEventArgs e)
        {
            resultDialog = false;
            Close();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
