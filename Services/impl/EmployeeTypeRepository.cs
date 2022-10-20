using EmploedServes.Models;

namespace EmploedServes.Services.impl
{
    public class EmployeeTypeRepository : IEmployeeTypeRepository
    {
        

        public int Create(EmployeeType data)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

       

        public void Update(EmployeeType data)
        {
            throw new NotImplementedException();
        }

        IList<EmployeeType> IRepository<EmployeeType, int>.GetAll()
        {
            throw new NotImplementedException();
        }

        EmployeeType IRepository<EmployeeType, int>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
