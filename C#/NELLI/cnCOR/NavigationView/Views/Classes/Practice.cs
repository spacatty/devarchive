using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace NavigationView.Views.Classes
{
    public class Practice
    {
        public Practice()
        {
            PracticeQuestions = new ObservableCollection<Question>();
        }

        public string Title { get; set; }
        public bool Credited { get; set; }
        public int Credits { get; set; }
        public ObservableCollection<Question> PracticeQuestions { get; private set; }
    }

    public class Question
    {
        public Question()
        {
            QuestionVariants = new ObservableCollection<Variant>();
        }
        public string Title { get; set; }
        public ObservableCollection<Variant> QuestionVariants { get; private set; }
    }

    public class Variant
    {
        public int ID { get; set; }
        public int QID { get; set; }
        public string Text { get; set; }
    }
}
