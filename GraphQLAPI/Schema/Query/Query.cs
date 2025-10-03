using Bogus;

namespace GraphQLAPI.Schema.Query
{
    public class Query
    {
        [GraphQLName("Courses")]
        public IEnumerable<CourcesType> GetCources()
        {
            var studentFaker = new Faker<StudentType>()
                .RuleFor(s => s.ID, f => Guid.NewGuid())
                .RuleFor(s => s.FristName, f => f.Name.FirstName())
                .RuleFor(s => s.LastName, f => f.Name.LastName())
                .RuleFor(s => s.CGPA, f => f.Random.Double(2.0, 4.0).ToString("0.00"))
                .RuleFor(s => s.Salary, f => f.Random.Double(1000, 5000));

            var instructorFaker = new Faker<InstructType>()
                .RuleFor(i => i.ID, f => Guid.NewGuid())
                .RuleFor(i => i.FullName, f => f.Name.FullName())
                .RuleFor(i => i.Experience, f => f.Random.Int(1, 20));

            var courseFaker = new Faker<CourcesType>()
                .RuleFor(c => c.ID, f => Guid.NewGuid())
                .RuleFor(c => c.Name, f => f.Company.CompanyName())
                .RuleFor(c => c.Subject, f => f.PickRandom<subject>())
                .RuleFor(c => c.Instructor, f => instructorFaker.Generate())  
                .RuleFor(c => c.Students, f => studentFaker.Generate(5));

            return courseFaker.Generate(100);
        }

        [GraphQLName("CoursesByID")]
        public async Task<CourcesType?> GetCourseByIDAsync(Guid id)
        {
            var courses = GetCources();
            return await Task.FromResult(courses.FirstOrDefault(c => c.ID == id));
        }

        [GraphQLDeprecated("This method is deprecated")]
        public string Instructions() => "Hello, GraphQL with HotChocolate!";
    }
}
