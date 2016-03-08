using CourseEnquiryApp.DataAccess.Models;
using CourseEnquiryApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class LearnerCourseList : Page
    {
        private Course selectedCourse;

        public LearnerCourseList()
        {
            this.InitializeComponent();
            // Need to give my OnLoaded event handler to the delegate, so that it is called when the Page
            // is first created.

            // Remember that this is using C# delegates.  In C++ or C these are known as function pointers.
            // In this case we are adding a REFERENCE to a method to the Loaded event.  The loaded event
            // contains a list of method references.  This is called the Invocation List.
            this.Loaded += OnLoaded;

            using (var context = new CourseEnquiryDbContext())
            {
                var courses = context.Courses.ToList();
                ViewModel.CourseList =
                    new ObservableCollection<Course>(courses);
            };
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        // Need to ensure an initial list item is selected, to avoid getting an
        // exception thrown.
        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            if (ViewModel.CourseList.Count > 0)
            {
                MasterListView.SelectedIndex = 0;
            }
        }

        private void MasterListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            selectedCourse = e.ClickedItem as Course;

            if (PageSizeStatesGroup.CurrentState == MobileState)
            {
                Frame.Navigate(typeof(LearnerCourseDetail), selectedCourse, new DrillInNavigationTransitionInfo());
            }
        }
    }
}
