namespace LR1
{
    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Specialization { get; set; }
        public int EmployeeCount { get; set; }

        public Company(string name, string address, string specialization, int employeeCount)
        {
            Name = name;
            Address = address;
            Specialization = specialization;
            EmployeeCount = employeeCount;
        }

        public override string ToString()
        {
            return $"\t\tCompany\nName: {Name}\nAddress: {Address}\nSpecialization: {Specialization}\nEmployees: {EmployeeCount}";
        }
    }
}