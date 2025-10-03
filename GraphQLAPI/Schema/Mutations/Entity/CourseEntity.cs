using GraphQLAPI.Schema.Query;

namespace GraphQLAPI.Schema.Mutations.Entity
{
    public class CourseEntity
    {
        //public Guid ID { get; set; }
        public string Name { get; set; }
        public subject Subject { get; set; }
        public Guid InstructerID { get; set; }
    }
}
