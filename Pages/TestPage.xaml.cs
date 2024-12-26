using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Controls;

namespace SemestrControl.Pages
{
    public partial class TestPage : Page
    {
        public List<Question> Questions { get; set; } = new List<Question>();

        public TestPage(string lastName, string firstName)
        {
            InitializeComponent();

            DataContext = this;

            LoadQuestions();
        }

        public class Question : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            private string _currentQuestion;
            public string CurrentQuestion
            {
                get { return _currentQuestion; }
                set { _currentQuestion = value; OnPropertyChanged(nameof(CurrentQuestion)); }
            }

            public string[] Answers { get; set; }
            public string SelectedAnswer { get; set; }
            public string CorrectAnswer { get; set; }

            public string question;

            public Question(string v1, string[] strings, string v2)
            {
            }

            public string GetQuestion()
            {
                return question;
            }

            internal void SetQuestion(string value)
            {
                question = value;
            }

            protected virtual void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void LoadQuestions()
        {
            Questions.Add(new Question("Какой язык программирования используется для создания приложений под Windows?", new[] { "C++", "Python", "C#" },
                "C#"));
            Questions.Add(new Question("Что такое WPF?", new[] { "Графическая библиотека", "Фреймворк для веб-разработки", "Система управления базами данных" }, "Графическая библиотека"));
            // Добавить еще 3 вопроса аналогично
        }

        public int CalculateCorrectAnswers()
        {
            return Questions.Count(q => q.SelectedAnswer == q.CorrectAnswer);
        }
    }
}
