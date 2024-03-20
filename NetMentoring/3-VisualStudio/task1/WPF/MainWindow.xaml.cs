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

namespace _3_2_wpf;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void submitButton_Click(object sender, RoutedEventArgs e)
    {
        // Показывает окно сообщения с приветствием с именем, введенным в nameTextBox
        MessageBox.Show("Hello, " + nameTextBox.Text + "!");
    }
}