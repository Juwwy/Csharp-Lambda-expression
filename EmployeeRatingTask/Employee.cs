namespace EmployeeRatingTask
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Position { get; set; }

        public Employee(string firstName, string lastName, string position)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {Position}";
        }
    }
}