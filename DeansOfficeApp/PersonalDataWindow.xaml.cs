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
using System.Windows.Shapes;

namespace DeansOfficeApp
{
    /// <summary>
    /// Interaction logic for PersonalDataWindow.xaml
    /// </summary>
    public partial class PersonalDataWindow : Window
    {
        public PersonalDataWindow()
        {
            InitializeComponent();

            //Dane wpisy na semestr
            var wpisy = new List<Wpis>();
            wpisy.Add(new Wpis { Semestr = "2017/2018 letni", Studia = "Informatyka", Data = "2018.12.15"});
            wpisy.Add(new Wpis { Semestr = "2017/2018 zimowy", Studia = "Informatyka", Data = "2018.09.15" });
            WpisySemestralne.ItemsSource = wpisy;

            //Dane Statusy
            var statusy = new List<Status>();
            statusy.Add(new Status { Data = "11.09.2018", StatusName = "Student", Studia = "Informatyka"});
            statusy.Add(new Status { Data = "12.19.2018", StatusName = "Urlop", Studia = "Informatyka" });
            Status.ItemsSource = statusy;
        }

        private void TextValidated(object sender, System.EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                int price = int.Parse(textBox.Text);

                if (price < 0)
                    textBox.Background = Brushes.Red;
                else if (price > 0)
                    textBox.Background = Brushes.Green;
                else
                    textBox.Background = Brushes.White;
            } catch (Exception o){}
        }
    }
}
