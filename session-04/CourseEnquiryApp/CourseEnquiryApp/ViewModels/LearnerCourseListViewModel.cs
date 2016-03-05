using CourseEnquiryApp.DataAccess.Models;
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
        public ObservableCollection<Course> CourseList { get; set; }

        public LearnerCourseListViewModel()
        {
        }

    }

    public class LearnerCourseListItem
    {
        public string CourseName { get; set; }
        public string CourseSummary { get; set; }
    }
}
