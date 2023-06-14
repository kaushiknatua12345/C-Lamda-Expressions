using System.Collections.Generic;
using System.Linq;

namespace LinqQuery_AndLamdaExample1
{
    public class CourseRepository
    {
        public List<Course> DisplayEntireCourse(List<Course> courses)
        {
            return courses;
        }

        //use Linq Query to Sort Courses in Descending Manner By course name where course duration>30 hours
        public List<Course> FilteredCoursesDisplay(List<Course> courses)
        {
            //select * from courses where CourseDurationInHours>30
            var filteredData = (from course in courses
                                where course.CourseDurationInHours > 30
                                orderby course.CourseName
                                descending
                                select course).ToList();
            return filteredData;
        }

        //Note: The above linq query can be shortened by Lamda Expression which we will
        //see in SessionRepository class

    }
}
