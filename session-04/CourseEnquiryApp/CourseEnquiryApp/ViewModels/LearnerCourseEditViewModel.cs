using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEnquiryApp.ViewModels
{
    class LearnerCourseEditViewModel : ViewModelBase
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
        private DateTime _startDate;

        public DateTime Startdate
        {
            get { return _startDate; }
            set { Set(ref _startDate, value); }
        }
        private DateTime _endDate;

        public DateTime EndDate
        {
            get { return _endDate; }
            set { Set(ref _endDate, value); }
        }
    }
}
