using CourseEnquiryApp.DataAccess.Models;
using CourseEnquiryApp.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
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
    public sealed partial class LearnerCourseDetail : Page
    {
        private Course SelectedCourse { get; set; }

        public LearnerCourseDetail()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            SelectedCourse = e.Parameter as Course;
            SystemNavigationManager systemNavigationManager = SystemNavigationManager.GetForCurrentView();
            systemNavigationManager.BackRequested += OnBackRequested;
        }

        private void OnBackRequested(object sender, BackRequestedEventArgs e)
        {
            // Check if we have a page to navigate back to, and whether the back request has already
            // been handled
            if (Frame.CanGoBack && e.Handled == false)
            {
                // This is to tell the navigation manager we handled the back request
                e.Handled = true;

                // We then tell the Frame to go back to the most recent page in its navigation history
                Frame.GoBack(new EntranceNavigationTransitionInfo());
            }
        }
    }
}
