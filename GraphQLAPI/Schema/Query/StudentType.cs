namespace GraphQLAPI.Schema.Query
{
    public class StudentType
    {
        public Guid ID { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string CGPA { get; set; }
        public double Salary { get; set; }
    }
}
