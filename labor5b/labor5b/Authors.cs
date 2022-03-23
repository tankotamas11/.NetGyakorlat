namespace labor5b
{
    public class Authors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Courses_Authors> Courses_Authors { get; set; }
    }
}
