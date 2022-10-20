namespace EmploedServes.Models.Request
{
    public class CreateDepartmentRequest
    {
        public int DepartmentId { get; set; }
        public int EmployeeTypeId { get; set; }
        public string Description { get; set; }
    }
}
