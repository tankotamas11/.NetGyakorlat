namespace labor5b
{
    public class Courses_Authors
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int CourseId { get; set; }
        public Courses Courses { get; set; }
        public Authors Authors { get; set; }

    }
}
