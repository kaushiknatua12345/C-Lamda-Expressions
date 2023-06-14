namespace LinqQuery_AndLamdaExample1
{
    public class SessionEnrollment
    {
        public int SessionId { get; set; }        
        public int CourseId { get; set; }
        public string RegionName { get; set; }
        public int NumberOfParticipants { get; set; }

        public override string ToString()
        {
            return string.Format("{0,-20}{1,-20}{2,-20}{3}",
                SessionId, CourseId, RegionName, NumberOfParticipants);
        }
    }
}
