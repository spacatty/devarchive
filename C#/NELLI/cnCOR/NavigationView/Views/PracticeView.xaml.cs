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
    public sealed partial class PracticeView : Page
    {
        DateTime startDate = DateTime.Now;
        public PracticeView()
        {
            this.InitializeComponent();
            PopulateActivities();
        }
        private void PopulateActivities()
        {
            List<Article> Projects = new List<Article>();
            Article newProject = new Article();
            newProject.Name = "Базовая информация";
            newProject.Activities.Add(new Activity()
            { Name = "Модель OSI", Complete = true, DueDate = startDate.AddDays(4) });
            newProject.Activities.Add(new Activity()
            { Name = "Типы компьютерных сетей", Complete = true, DueDate = startDate.AddDays(5) });
            Projects.Add(newProject);

            newProject = new Article();
            newProject.Name = "Маршрутизация";
            newProject.Activities.Add(new Activity()
            { Name = "Динамическая маршрутизация", Complete = true, DueDate = startDate.AddDays(2) });
            newProject.Activities.Add(new Activity()
            { Name = "Статическая маршрутизация", Complete = false, DueDate = startDate.AddDays(3) });
            newProject.Activities.Add(new Activity()
            { Name = "Протокол OSPFv3", Complete = false, DueDate = startDate.AddDays(5) });
            newProject.Activities.Add(new Activity()
            { Name = "Протокол EIGRP", Complete = false, DueDate = startDate.AddDays(63) });
            Projects.Add(newProject);

            newProject = new Article();
            newProject.Name = "Безопасность";
            newProject.Activities.Add(new Activity()
            { Name = "Протокол удалённого доступа Telnet", Complete = true, DueDate = startDate.AddDays(2) });
            newProject.Activities.Add(new Activity()
            { Name = "Протокол удалённого доступа SSH", Complete = false, DueDate = startDate.AddDays(3) });
            newProject.Activities.Add(new Activity()
            { Name = "Модель AAA", Complete = false, DueDate = startDate.AddDays(5) });
            newProject.Activities.Add(new Activity()
            { Name = "Списки доступа ACL", Complete = false, DueDate = startDate.AddDays(63) });
            Projects.Add(newProject);
            cvsPractices.Source = Projects;
        }
    }
}

