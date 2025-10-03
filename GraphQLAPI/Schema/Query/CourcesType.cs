namespace GraphQLAPI.Schema.Query
{
    public enum subject
    {
        Math,
        Science,
        History,
        Literature,
        Art,
        Music,
        PhysicalEducation,
        ComputerScience,
        html,
        css,
        javascript,
        bootstrap,
        jQuery,
        react,
        angular
    }
    public class CourcesType
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public subject Subject { get; set; }

        [GraphQLNonNullType]
        public InstructType Instructor { get; set; }
        public IEnumerable<StudentType> Students { get; set; }
    }
}