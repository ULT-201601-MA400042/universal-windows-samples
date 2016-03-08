using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEnquiryApp.ViewModels
{
    public class LearnerCourseCreateViewModel : ViewModelBase
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { Set(ref _name, value); }
        }

        private string _summary;

        public string Summary
        {
            get { return _summary; }
            set { Set(ref _summary, value); }
        }

        private string _overview;

        public string Overview
        {
            get { return _overview; }
            set { Set(ref _overview, value); }
        }

    }
}
