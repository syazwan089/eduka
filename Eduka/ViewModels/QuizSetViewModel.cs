using Eduka.Models;
using Eduka.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Eduka.ViewModels
{
    public class QuizSetViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public IRestApi _rest => DependencyService.Get<IRestApi>();

        private List<Soalan> SetSoalan;

        public List<Soalan> setSoalan
        {
            get { return SetSoalan; }
            set { SetSoalan = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("setSoalan"));
            }
        }

        private Soalan soalan;

        public Soalan Soalan
        {
            get { return soalan; }
            set { soalan = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Soalan"));
            }
        }


        private int Current;

        public int current
        {
            get { return Current; }
            set { Current = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("current"));
            }
        }

        public int Total { get; set; }


        private int Markah;

        public int markah
        {
            get { return Markah; }
            set { Markah = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("markah"));
            }
        }




        public QuizSetViewModel(string QuizId)
        {
            setSoalan = new List<Soalan>();
            Soalan = new Soalan();
            current = new int();
            markah = new int();
            markah = 0;
            current = 0;
            get(QuizId);
            A = new Command(AAnsw);
            B = new Command(BAnsw);
            C = new Command(CAnsw);
        }

    

        private void get(string QuizIds)
        {
            GetQuiz(QuizIds);
        }

        private async Task GetQuiz(string Quiz)
        {
            var result = await _rest.GetQuizSet(Quiz);

            if(result != null)
            {
                setSoalan = result;
                Total = setSoalan.Count;
                Total -= 1;
                ShowSoalan();
            }
        }


        private void ShowSoalan()
        {
            Soalan = setSoalan[current];
        }


        public Command A { get; set; }
        public Command B { get; set; }
        public Command C { get; set; }

        private void CAnsw(object obj)
        {
            string answers = obj as string;
            if(Soalan.task_ans == answers)
            {
                markah++;
                if(current != Total)
                {
                    current++;
                    ShowSoalan();
                }

                else
                {
                    App.Current.MainPage.DisplayAlert("Question End", $"Your result is {markah} / {Total + 1}", "Okay");
                }

            }

            else
            {
                if (current != Total)
                {
                    current++;
                    ShowSoalan();
                }

                else
                {
                    App.Current.MainPage.DisplayAlert("Question End", $"Your result is {markah} / {Total + 1}", "Okay");
                }
            }
        }

        private void BAnsw(object obj)
        {
            string answers = obj as string;
            if (Soalan.task_ans == answers)
            {
                markah++;
                if (current != Total)
                {
                    current++;
                    ShowSoalan();
                }

                else
                {
                    App.Current.MainPage.DisplayAlert("Question End", $"Your result is {markah} / {Total + 1}", "Okay");
                }
            }

            else
            {
                if (current != Total)
                {
                    current++;
                    ShowSoalan();
                }

                else
                {
                    App.Current.MainPage.DisplayAlert("Question End", $"Your result is {markah} / {Total + 1}", "Okay");
                }
            }
        }

        private void AAnsw(object obj)
        {
            string answers = obj as string;
            if (Soalan.task_ans == answers)
            {
                markah++;
                if (current != Total)
                {
                    current++;
                    ShowSoalan();
                }

                else
                {
                    App.Current.MainPage.DisplayAlert("Question End", $"Your result is {markah} / {Total+1}", "Okay");
                }
            }

            else
            {
                if (current != Total)
                {
                    current++;
                    ShowSoalan();
                }

                else
                {
                    App.Current.MainPage.DisplayAlert("Question End", $"Your result is {markah} / {Total + 1}", "Okay");
                }
            }
        }
    }
}
