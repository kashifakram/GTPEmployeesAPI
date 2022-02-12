namespace Employees.Domain
{
    public class EmployeeStatus
    {
        public int Id { get; set; }
        public ContractTypeEnum ContractTypeEnum { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public bool OnGoing { get; set; }
        public JobTypeEnum JobType { get; set; }
        public int HoursPerWeek { get; set; }
        public EmployeePersonalDetails? EmployeePersonalDetails { get; set; }
        public int EmployeePersonalDetailsId { get; set; }
    }

    public enum ContractTypeEnum
    {
        Permanent,
        Contract
    }

    public enum JobTypeEnum
    {
        FullTime,
        PartTime
    }
}
