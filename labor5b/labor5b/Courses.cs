namespace labor5b
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AlgorithmId { get; set; }
        public Algorithms Algorithms { get; set; }
        public List<Courses_Authors> Courses_Authors { get; set; }
    }
}
