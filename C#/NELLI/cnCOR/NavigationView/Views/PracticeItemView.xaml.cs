using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using NavigationView.Views.Classes;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace NavigationView.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PracticeItemView : Page
    {
        public Practice OSIPractice = new Practice();
        public PracticeItemView()
        {
            this.InitializeComponent();
            OSIPractice.Title = "Тест: Сетевая модель OSI";
            OSIPractice.Credited = false;
            OSIPractice.Credits = 0;

            Question Q1 = new Question() { Title = "Первый уровень модели OSI" };
            Q1.QuestionVariants.Add(new Variant() {ID = 0,  Text = "Канальный", QID = 0});
            Q1.QuestionVariants.Add(new Variant() {ID = 1,  Text = "Приложений", QID = 0 });
            Q1.QuestionVariants.Add(new Variant() {ID = 2,  Text = "Физический", QID = 0 });
            Q1.QuestionVariants.Add(new Variant() {ID = 3,  Text = "Сетевой", QID = 0 });

            Question Q2 = new Question() { Title = "Тип данных Канального уровня" };
            Q2.QuestionVariants.Add(new Variant() { ID = 0, Text = "Кадры", QID = 1 });
            Q2.QuestionVariants.Add(new Variant() { ID = 1, Text = "Пакеты", QID = 1 });
            Q2.QuestionVariants.Add(new Variant() { ID = 2, Text = "Биты", QID = 1 });
            Q2.QuestionVariants.Add(new Variant() { ID = 3, Text = "Блоки", QID = 1 });

            Question Q3 = new Question() { Title = "Кодирование производится на уровне ..." };
            Q3.QuestionVariants.Add(new Variant() { ID = 0, Text = "Физический", QID = 2 });
            Q3.QuestionVariants.Add(new Variant() { ID = 1, Text = "Представлений", QID = 2 });
            Q3.QuestionVariants.Add(new Variant() { ID = 2, Text = "Сетевой", QID = 2 });
            Q3.QuestionVariants.Add(new Variant() { ID = 3, Text = "Приложений", QID = 2 });

            OSIPractice.PracticeQuestions.Add(Q1);
            OSIPractice.PracticeQuestions.Add(Q2);
            OSIPractice.PracticeQuestions.Add(Q3);
        }
     
    }
}
