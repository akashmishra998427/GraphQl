using GraphQLAPI.Schema.Mutations.Entity;
using GraphQLAPI.Schema.Query;

namespace GraphQLAPI.Schema.Mutations
{
    public class Mutation
    {
        private readonly List<CourseResult> _courses;

        public Mutation()
        {
            _courses = new List<CourseResult>();
        }

        public CourseResult CreateCourse(CourseEntity Entity)
        {
            try
            {
                var course = new CourseResult
                {
                    ID = Guid.NewGuid(),
                    Name = Entity.Name,
                    Subject = Entity.Subject,
                    InstructerID = Entity.InstructerID
                };

                _courses.Add(course);
                return course;
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating course", ex);
            }
        }

        public CourseResult UpdateCourses( Guid ID ,CourseEntity Entity)
        {
            CourseResult couse = _courses.FirstOrDefault(c => c.ID == ID);
            if(couse == null)
            {
                throw new GraphQLException(new Error("Course Can't Fine"));
            }
            couse.Name = Entity.Name;
            couse.Subject = Entity.Subject;
            couse.InstructerID = Entity.InstructerID;
            return couse;
        }

        public CourseResult DeleteCourse(Guid id)
        {
            var course = _courses.FirstOrDefault(c => c.ID == id);
            if (course == null)
            {
                throw new GraphQLException(new Error("Course not found"));
            }
            _courses.Remove(course);
            return course;
        }
    }
}
