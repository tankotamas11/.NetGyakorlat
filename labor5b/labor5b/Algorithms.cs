namespace labor5b
{
    public class Algorithms
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public string AlgorithmNickname { get; set; }
        public bool isPublished { get; set; }
        public DateTime CreationDate { get; set; }
        public List<Courses>? Courses { get; set; }

    }
}
