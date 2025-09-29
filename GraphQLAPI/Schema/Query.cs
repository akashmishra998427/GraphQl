using Bogus;

namespace GraphQLAPI.Schema
{
    public class Query
    {

        [GraphQLName("Courses")]
        public IEnumerable<CourcesType> GetCources()
        {
            var studentFaker = new Faker<StydentType>()
                .RuleFor(s => s.ID, f => Guid.NewGuid())   
                .RuleFor(s => s.FristName, f => f.Name.FirstName())
                .RuleFor(s => s.LastName, f => f.Name.LastName())
                .RuleFor(s => s.CGPA, f => f.Random.Double(2.0, 4.0).ToString("0.00"))
                .RuleFor(s => s.Salary, f => f.Random.Double(1000, 5000));

            var courseFaker = new Faker<CourcesType>()
                .RuleFor(c => c.ID, f => Guid.NewGuid())   
                .RuleFor(c => c.Name, f => f.Company.CompanyName())
                .RuleFor(c => c.Subject, f => f.PickRandom<subject>())
                .RuleFor(c => c.Students, f => studentFaker.Generate(5));  

            return courseFaker.Generate(100);  
        }

        [GraphQLName("CoursesByID")]
        public async Task<CourcesType?> GetCourseByIDAsync(Guid id)
        {
            await Task.Delay(100);

            var courses = GetCources();

            var course = courses.FirstOrDefault(c => c.ID == id);

            return course;
        }



        [GraphQLDeprecated("This method is deprecated")]
        public string Instructions() => "Hello, GraphQL with HotChocolate!";
    }
}
