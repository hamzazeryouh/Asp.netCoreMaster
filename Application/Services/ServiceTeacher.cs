using NetCoreMaster.Application.Interfaces;
using NetCoreMaster.Domain.Entities;

namespace NetCoreMaster.Application.Services
{
    public class ServiceTeacher :ISchoolService
    {
        public async Task<dynamic> GetTeacher()
        {
            return new List<Teacher> {
                new Teacher { Id=1,NameTeacher="hamza"},
                new Teacher { Id=2,NameTeacher="hamza2"}
            };
        }

        //public async Task<List<Teacher>> GetTeachers()
        //{
        //    return new List<Teacher> {
        //        new Teacher { Id=1,NameTeacher="hamza"},
        //        new Teacher { Id=2,NameTeacher="hamza2"}
        //    };
        //}
    }

}

