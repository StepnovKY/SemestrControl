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
using SemestrControl.Pages;

namespace SemestrControl
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
        private void NextPage_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.Content is StartTestPage introPage)
            {
                // Переход к странице теста
                MainFrame.Navigate(new TestPage(introPage.LastName, introPage.FirstName));
            }
            else if (MainFrame.Content is TestPage testPage)
            {
                // Завершение теста и переход к результатам
                int correctAnswers = testPage.CalculateCorrectAnswers();
                MainFrame.Navigate(new ResultPage(correctAnswers, testPage.Questions.Count));
            }
        }
    }
}