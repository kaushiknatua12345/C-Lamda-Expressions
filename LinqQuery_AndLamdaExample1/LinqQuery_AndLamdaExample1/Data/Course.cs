namespace LinqQuery_AndLamdaExample1
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public float CourseDurationInHours { get; set; }

        public override string ToString()
        {
            return string.Format("{0,-20}{1,-20}{2}", CourseId, CourseName, CourseDurationInHours);
        }
    }
}
