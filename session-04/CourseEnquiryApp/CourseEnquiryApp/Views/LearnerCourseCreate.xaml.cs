using CourseEnquiryApp.DataAccess.Models;
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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CourseEnquiryApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LearnerCourseCreate : Page
    {
        public LearnerCourseCreate()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using(var context = new CourseEnquiryDbContext())
            {
                var learner = context.Learners.FirstOrDefault();
                learner.Courses.Add(new Course()
                {
                    Name = ViewModel.Name,
                    Summary = ViewModel.Summary,
                    Overview = ViewModel.Overview,
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Today.AddDays(14)
                });

                context.SaveChanges();
            }

            Frame.Navigate(typeof(LearnerCourseList), null, new EntranceNavigationTransitionInfo());
        }
    }
}
