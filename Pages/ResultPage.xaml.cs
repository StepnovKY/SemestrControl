using System.Windows.Controls;

namespace SemestrControl.Pages
{
    public partial class ResultPage : Page
    {
        public string ResultMessage { get; set; }

        public ResultPage(int correctAnswers, int totalQuestions)
        {
            InitializeComponent();

            DataContext = this;

            double score = ((double)correctAnswers / totalQuestions) * 100;
            ResultMessage = $"Правильных ответов: {correctAnswers}/{totalQuestions} ({score:F2}%)";
        }
    }
}