namespace GraphQLAPI.Schema
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
        //public IEnumerable<instruc> Instructor { get; set; }
        public IEnumerable<StydentType> Students { get; set; }
    }
}
