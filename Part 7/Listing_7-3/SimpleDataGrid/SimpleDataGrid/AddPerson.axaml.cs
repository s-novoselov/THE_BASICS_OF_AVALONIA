using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using SimpleDataGrid.Models;
using System;

namespace SimpleDataGrid
{
    public partial class AddPerson : Window
    {
        public Person itemPerson;
        public bool resultDialog;

        public string mode = "insert";
        public Person SelectPerson = new Person();

        public AddPerson()
        {
            InitializeComponent();

            var bSavePerson = this.FindControl<Button>("bSavePerson");
            bSavePerson.Click += SaveButton_Click;

            var bCancel = this.FindControl<Button>("bCancel");
            bCancel.Click += Cancel_Click;

            this.Activated += AddPerson_Activated;
        }

        private void AddPerson_Activated(object? sender, EventArgs e)
        {
            if (mode == "edit")
            {
                if (SelectPerson != null)
                {
                    this.FindControl<TextBox>("tDepartmentNumber").Text = SelectPerson.DepartmentNumber.ToString();
                    this.FindControl<TextBox>("tDeskLocation").Text = SelectPerson.DeskLocation.ToString();
                    this.FindControl<TextBox>("tFirstName").Text = SelectPerson.FirstName.ToString();
                    this.FindControl<TextBox>("tLastName").Text = SelectPerson.LastName.ToString();
                }
            }            
        }

        private void SaveButton_Click(object? sender, RoutedEventArgs e)
        {
            int departmentNumber = 0;
            bool saccessParseDN = int.TryParse(this.FindControl<TextBox>("tDepartmentNumber").Text, out departmentNumber);
            int DepartmentNumber = departmentNumber;

            string DeskLocation = this.FindControl<TextBox>("tDeskLocation").Text;
            string FirstName = this.FindControl<TextBox>("tFirstName").Text;
            string LastName = this.FindControl<TextBox>("tLastName").Text;

            string sql = "";
            if (mode == "insert")
            {


                sql = string.Format("Insert into Person (DepartmentNumber, DeskLocation, FirstName, LastName) " +
                    "Values ('{0}', '{1}', '{2}', '{3}');",
                    DepartmentNumber, DeskLocation, FirstName, LastName);
            }
            else
            {
                sql = string.Format("Update Person SET DepartmentNumber = '{0}', " +
                    "DeskLocation = '{1}', " +
                    "FirstName = '{2}', " +
                    "LastName = '{3}' " +
                    "Where EmployeeNumber = '{4}';",
                    DepartmentNumber, DeskLocation, FirstName, LastName, SelectPerson.EmployeeNumber);
            }
            resultDialog = Database.Exec_SQL(sql);

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
