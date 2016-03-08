using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CourseEnquiryApp.ViewModels
{
    public class LearnerCourseCreateViewModel : ViewModelBase
    {
        //Some Data Annotations
        [Required(ErrorMessage = "A Course Name is Required")]
        [DataType(DataType.Text)]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "the value for {0} must be between {2} and {50}.")]
        private string _name;

        public string Name   
        {
            get { return _name; }
            set { Set(ref _name, value); }
        }

        [Required(ErrorMessage = "Please enter a course summary")]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 25, ErrorMessage = "the value for {1} must be between {25} and {100}.")]
        private string _summary;

        public string Summary
        {
            get { return _summary; }
            set { Set(ref _summary, value); }
        }

        [Required(ErrorMessage = "Please enter a course overview description")]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 25, ErrorMessage = "the value for {1} must be between {25} and {100}.")]
        private string _overview;

        public string Overview
        {
            get { return _overview; }
            set { Set(ref _overview, value); }
        }

        [Required(ErrorMessage = "Please enter a valid Start date")]
        [DataType(DataType.DateTime)]
        private DateTime _startDate;

        public DateTime StartDate
        {
            get { return _startDate; }
            set { Set(ref _startDate, value); }
        }

        [Required(ErrorMessage = "Please enter a valid End date")]
        [DataType(DataType.DateTime)]
        private DateTime _endDate;

        public DateTime EndDate
        {
            get { return _endDate; }
            set { Set(ref _endDate, value); }
        }
    }
}
