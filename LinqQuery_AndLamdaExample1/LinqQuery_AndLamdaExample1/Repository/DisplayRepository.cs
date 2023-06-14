using System.Collections.Generic;
using System.Linq;
using System;

namespace LinqQuery_AndLamdaExample1
{   
    public class DisplayRepository
    {
        static List<Course> courses = new List<Course>()
            {
            new Course{CourseId=1001,CourseName="C#",CourseDurationInHours=45},
            new Course{CourseId=1002,CourseName="ASP.NET MVC",CourseDurationInHours=89},
            new Course{CourseId=1003,CourseName="Entity Framework",CourseDurationInHours=30},
            new Course{CourseId=1004,CourseName="HTML5",CourseDurationInHours=15},
            new Course{CourseId=1005,CourseName="JQuery & TypeScript",CourseDurationInHours=35},
            new Course{CourseId=1006,CourseName="Angular 13",CourseDurationInHours=75},
            };

        static List<SessionEnrollment> sessions = new List<SessionEnrollment>()
            {
                new SessionEnrollment{SessionId=1,CourseId=1001,RegionName="APAC/EMEA",NumberOfParticipants=30},
                new SessionEnrollment{SessionId=2,CourseId=1001,RegionName="NA",NumberOfParticipants=40},
                new SessionEnrollment{SessionId=3,CourseId=1003,RegionName="NA",NumberOfParticipants=12},
                new SessionEnrollment{SessionId=4,CourseId=1004,RegionName="APAC/EMEA",NumberOfParticipants=10},
                new SessionEnrollment{SessionId=5,CourseId=1003,RegionName="APAC/EMEA",NumberOfParticipants=28},
                new SessionEnrollment{SessionId=5,CourseId=1001,RegionName="APAC/EMEA",NumberOfParticipants=11},
            };
        public static void Display()
        {           
            CourseRepository coureRepo = new CourseRepository();
            SessionRepository sessionRepo = new SessionRepository();
            string loopInput = string.Empty;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nMenu:\n1. Display All Courses\n2. Display All Sessions " +
               "\n3. Display Courses Where Duration>30 Hours\n4. Display Sessions Where Number Of Participants>15" +
               "\n5. Display Data From Courses and Sessions Based On Common Course Id\n"+
               "6. Display Total Candidates Registered For Each Courses");
                Console.ForegroundColor = ConsoleColor.White;
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        List<Course> displayAllCourses = coureRepo.DisplayEntireCourse(courses);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n{0,-20}{1,-20}{2}", "Course Id", "Course Name", "Course Duration(In Hours)");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        foreach (var data in displayAllCourses)
                        {
                            Console.WriteLine(data);
                        }

                        break;

                    case 2:
                        List<SessionEnrollment> displayAllSessions = sessionRepo.DisplayAllSessions(sessions);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n{0,-20}{1,-20}{2,-20}{3}", "Session Id", "Course Id",
                            "Region Name", "Number Of Participants");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        foreach (var data in displayAllSessions)
                        {
                            Console.WriteLine(data);
                        }

                        break;

                    case 3:
                        List<Course> displayFilteredCourseData = coureRepo.FilteredCoursesDisplay(courses);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n{0,-20}{1,-20}{2}", 
                            "Course Id", "Course Name", "Course Duration(In Hours)");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        foreach (var data in displayFilteredCourseData)
                        {
                            Console.WriteLine(data);
                        }
                        break;

                    case 4:
                        List<SessionEnrollment> displayFilteredSessionData = sessionRepo.FilteredSessionsDisplay(sessions);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n{0,-20}{1,-20}{2,-20}{3}", "Session Id", "Course Id",
                            "Region Name", "Number Of Participants");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        foreach (var data in displayFilteredSessionData)
                        {
                            Console.WriteLine(data);
                        }
                        break;

                    case 5:
                        DisplayJoinedData(courses, sessions);
                        break;

                    case 6:
                        sessionRepo.DisplayGroupedData(sessions);
                        break;
                }
                Console.WriteLine("\nEnter yes to continue..Any other key to terminate: ");
                loopInput = Console.ReadLine();
            }
            while (loopInput == "yes");
        }

        //Use Lamda to Join Courses and Sessions to display data from two collections
        //based on CourseId as primary-foreign key type relationship
        private static void DisplayJoinedData(List<Course> courses, List<SessionEnrollment> sessions)
        {
            var query = (from course in courses
                         join session in sessions
                         on course.CourseId equals session.CourseId
                         orderby session.NumberOfParticipants descending
                         select new
                         {
                             course.CourseName,
                             course.CourseId,
                             course.CourseDurationInHours,
                             session.SessionId,
                             session.RegionName,
                             session.NumberOfParticipants
                         }).ToList();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5}", "Course Name", "Course Id",
                "Duration(In Hours)", "Session Id", "Region", "Participant Count");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (var data in query)
            {
                Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5}", data.CourseName,
                    data.CourseId, data.CourseDurationInHours, data.SessionId, data.RegionName, data.NumberOfParticipants);
            }
        }

    }
}
