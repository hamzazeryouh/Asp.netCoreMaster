using NetCoreMaster.Application.Interfaces;
using NetCoreMaster.Domain.Entities;

namespace NetCoreMaster.Application.Services
{
    public class ServiceSudent
    {

    //public async Task<List<Student>>  GetStudent()
    //    {
    //        return  new List<Student> {
    //            new Student { Id=1,NameStudent="hamza"},
    //            new Student { Id=2,NameStudent="hamza2"}
    //        };
    //    }

       public async  Task<dynamic> GetStudent()
        {
            return new List<Student> {
                new Student { Id=1,NameStudent="hamza"},
                new Student { Id=2,NameStudent="hamza2"}
            };
        }
    }
}
