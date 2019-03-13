using DeansOfficeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DeansOfficeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CloseMenuItem.Click += CloseMenuItem_Click;
            OpenPersonalData.Click += OpenPersonalData_Click;

            //Testowe dane dla TreeView
            TreeViewItem students = new TreeViewItem { Header = "Studenci" };

            var dzienne = new TreeViewItem { Header = "Dzienne" };
            students.Items.Add(dzienne);
            students.Items.Add(new TreeViewItem { Header = "Zaoczne" });
            students.Items.Add(new TreeViewItem { Header = "Internetowe" });

            dzienne.Items.Add(new TreeViewItem { Header = "Informatyka" });
            dzienne.Items.Add(new TreeViewItem { Header = "Grafika" });

            TreeViewItem employees = new TreeViewItem();
            employees.Header = "Pracownicy";

            employees.Items.Add(new TreeViewItem { Header = "Dydaktycy" });
            employees.Items.Add(new TreeViewItem { Header = "Administracja" });

            PersonTypeTreeView.Items.Add(students);
            PersonTypeTreeView.Items.Add(employees);

            //Testowe dane dla kontrolki Grid
            //Dane studentow
            var studenci = new List<Student>();
            studenci.Add(new Student { FirstName = "Jan", LastName = "Kowalski", IndexNumber = "s1234", Year = 2018, Semester = "2017/2018 letni", Specialization = "Bazy danych", Status = "Student", Notes = "Brak" });
            studenci.Add(new Student { FirstName = "Mariusz", LastName = "Kowalski", IndexNumber = "s1234", Year = 2018, Semester = "2017/2018 letni", Specialization = "Bazy danych", Status = "Student", Notes = "Brak" });
            studenci.Add(new Student { FirstName = "Andrzej", LastName = "Kowalski", IndexNumber = "s1234", Year = 2018, Semester = "2017/2018 letni", Specialization = "Bazy danych", Status = "Student", Notes = "Brak" });

            StudentsDataGrid.ItemsSource = studenci;
        }

        private void CloseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OpenPersonalData_Click(object sender, RoutedEventArgs e)
        {
            PersonalDataWindow personalDataWindow = new PersonalDataWindow();

            personalDataWindow.Show();
        }
    }
}
