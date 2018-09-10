using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SystemSchool.Models;
using SystemSchool.Models.SchoolViewModels;

namespace SystemSchool.Pages.Instructors
{
    public class IndexModel : PageModel
    {
        private readonly SystemSchool.Models.SystemContext _context;

        public IndexModel(SystemSchool.Models.SystemContext context)
        {
            _context = context;
        }

        public InstructorIndexData Instructor { get; set; }
        public int InstructorID { get; set; }
        public int CourseID { get; private set; }

        // public IList<Instructor> Instructor { get;set; }

        public async Task OnGetAsync(int ? id,int? courseID)
        {
            Instructor = new InstructorIndexData();
            Instructor.Instructors = await _context.Instructors
                  .Include(i => i.OfficeAssignment)
                  .Include(i => i.CourseAssignments)
                    .ThenInclude(i => i.Course)
                     .ThenInclude(i => i.Department)
                      .Include(i => i.CourseAssignments)
            .ThenInclude(i => i.Course)
                .ThenInclude(i => i.Enrollments)
                    .ThenInclude(i => i.Student)
                    .AsNoTracking()
                  .OrderBy(i => i.LastName)
                  .ToListAsync();

            if (id != null)
            {
                InstructorID = id.Value;
                Instructor instructor = Instructor.Instructors.Where(
            i => i.ID == id.Value).Single();
                Instructor.Courses = instructor.CourseAssignments.Select(s => s.Course);

            }
            if (courseID != null)
            {
                CourseID = courseID.Value;
                Instructor.Enrollments = Instructor.Courses.Where(
                    x => x.CourseID == courseID).Single().Enrollments;
            }


        }

    }
}
