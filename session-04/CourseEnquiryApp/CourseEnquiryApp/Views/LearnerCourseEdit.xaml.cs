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
using Microsoft.Data.Entity;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CourseEnquiryApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LearnerCourseEdit : Page
    {
        public LearnerCourseEdit()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sebder, RoutedEventArgs e)
        {
            using (var context = new CourseEnquiryDbContext())
            {
                // need to recheck logic 
                var LearnerCourse = LearnerCourse.Get(LearnerId)
            }
        }
    }
}
