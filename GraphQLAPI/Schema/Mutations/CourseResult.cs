using GraphQLAPI.Schema.Query;

namespace GraphQLAPI.Schema.Mutations
{
    public class CourseResult
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public subject Subject { get; set; }
        public Guid InstructerID { get; set; }
    }
}
