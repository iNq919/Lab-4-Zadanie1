using System;
using System.Text.RegularExpressions;
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


namespace Lab_4_Zad1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Student student;
        public Window1(Student student = null)
        {
            InitializeComponent();
            if(student != null)
            {
                tbImie.Text = student.imie;
                tbNazwisko.Text = student.nazwisko;
                tbNrAlbumu.Text = student.NrAlbumu.ToString();
                tbWydzial.Text = student.wydzial;
            }
            this.student = student ?? new Student();
        }

        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(tbImie.Text, @"^\p{Lu}\p{Ll}{1,12}$") ||
                !Regex.IsMatch(tbNazwisko.Text, @"^\p{Lu}\p{Ll}{1,30}$") ||
                !Regex.IsMatch(tbWydzial.Text, @"^\p{Lu}\p{Ll}{1,}$") ||
                !Regex.IsMatch(tbNrAlbumu.Text, @"^[0-9]{5}$")
            )
            {
                MessageBox.Show("Podano niepoprawne dane!");
                return;
            }
            else
            {
                student.imie = tbImie.Text;
                student.nazwisko = tbNazwisko.Text;
                student.NrAlbumu = int.Parse(tbNrAlbumu.Text);
                student.wydzial = tbWydzial.Text;

                this.DialogResult = true;
            }
                  
        }
    }
}
