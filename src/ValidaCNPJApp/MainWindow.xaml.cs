using ValidaCNPJCore;
using System.Windows;

namespace ValidaCNPJApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cnpj = txtCNPJ.Text;

            txtResultado.Text = Validar.CNPJ(cnpj) == true ? "O CNPJ é válido." : "O CNPJ não é válido.";
        }
    }
}
