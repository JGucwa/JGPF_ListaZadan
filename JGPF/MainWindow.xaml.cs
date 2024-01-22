using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JGPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Zadanie> tmp = new Database().WyswietlWszystko();
            tmp.Reverse();
            Lista.ItemsSource = tmp;
        }
        public void DodajZadanie(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Nazwa.Text) && !string.IsNullOrWhiteSpace(Opis.Text))
            {
                new Database().DodajZadanie(new Zadanie() { Data = Data.SelectedDate.Value, Nazwa = Nazwa.Text, Opis = Opis.Text, Priorytet = Priorytet.Text });

                Nazwa.Text = Opis.Text = String.Empty;

                List<Zadanie> tmp = new Database().WyswietlWszystko();
                tmp.Reverse();
                Lista.ItemsSource = tmp;

                MessageBox.Show("Dodano pomyslnie zadanie");
            }
            else
            {
                MessageBox.Show("Dane sa bledne");
            }
        }
    }
}