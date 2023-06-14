using System.Collections.Generic;
using System.Linq;
using System;

namespace LinqQuery_AndLamdaExample1
{
    public class SessionRepository
    {
        public List<SessionEnrollment> DisplayAllSessions(List<SessionEnrollment> sessions)
        {
            return sessions;
        }

        //Use Lamda Expressions to display sessions where number of participants is >15 in descending manner by participant count
        public List<SessionEnrollment> FilteredSessionsDisplay(List<SessionEnrollment> sessions)
        {
            var filteredData = sessions.Where(x => x.NumberOfParticipants > 15)
                                     .OrderByDescending(x => x.NumberOfParticipants)
                                     .Select(x => x).ToList();
            return filteredData;

            /* Note: Here lamda expressions are used to shorten Linq Queries. The same if 
             * we write using Linq Query will look like this:
             *  var filteredData=(from sessionData in sessions where sessionData.NumberOfParticipants>15
             *                   order by sessionData.NumberOfParticipants descending
             *                   select sessiondata).ToList();
             * */                  
        }

        //Display total number of candidates against each courses
        public void DisplayGroupedData(List<SessionEnrollment> sessions)
        {
            var grouped = sessions
                          .GroupBy(s => s.CourseId)
                          .Select(g => new { CourseId = g.Key, ParticipantCount = g.Sum(x=>x.NumberOfParticipants) });
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n{0,-20}{1}", "Course Id", "Total Number Of Participants");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (var items in grouped)
            {
                Console.WriteLine("{0,-20}{1}", items.CourseId, items.ParticipantCount);
            }

        }

    }
}
