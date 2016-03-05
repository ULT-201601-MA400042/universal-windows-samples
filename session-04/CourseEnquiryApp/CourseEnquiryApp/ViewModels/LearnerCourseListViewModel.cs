using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseEnquiryApp.ViewModels
{
    public class LearnerCourseListViewModel : ViewModelBase
    {
        public ObservableCollection<LearnerCourseListItem> CourseList { get; set; }

        public LearnerCourseListViewModel()
        {
            CourseList = new ObservableCollection<LearnerCourseListItem>()
            {
                new LearnerCourseListItem
                {
                    CourseName = "Mobile Application Development",
                    CourseSummary = "Learn UWP, Android, and iOS development"
                },
                new LearnerCourseListItem
                {
                    CourseName = "Cross-platform Mobile Apps with Telerik Platform",
                    CourseSummary = "Learn how to make JavaScript-based mobile apps for any platform"
                }
            };
        }

    }

    public class LearnerCourseListItem
    {
        public string CourseName { get; set; }
        public string CourseSummary { get; set; }
    }
}
