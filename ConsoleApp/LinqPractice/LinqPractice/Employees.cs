namespace LinqPractice;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name} {LastName}, Age: {Age}, Salary: {Salary:C}, Department: {Department}";
    }
}

// Define the Employees class which holds the list of employees
public class Employees
{
    public List<Employee> EmployeeList { get; set; }

    public Employees()
    {
        EmployeeList = new List<Employee>
        {
            new Employee { Id = 1, Name = "John", LastName = "Doe", Age = 30, Salary = 60000, Department = "Engineering" },
            new Employee { Id = 2, Name = "Jane", LastName = "Smith", Age = 28, Salary = 55000, Department = "Marketing" },
            new Employee { Id = 3, Name = "Michael", LastName = "Johnson", Age = 45, Salary = 75000, Department = "HR" },
            new Employee { Id = 4, Name = "Emily", LastName = "Davis", Age = 35, Salary = 70000, Department = "Finance" },
            new Employee { Id = 5, Name = "David", LastName = "Wilson", Age = 50, Salary = 80000, Department = "Sales" },
            new Employee { Id = 6, Name = "Sarah", LastName = "Brown", Age = 40, Salary = 68000, Department = "Engineering" },
            new Employee { Id = 7, Name = "James", LastName = "Taylor", Age = 32, Salary = 62000, Department = "Marketing" },
            new Employee { Id = 8, Name = "Laura", LastName = "Anderson", Age = 27, Salary = 52000, Department = "HR" },
            new Employee { Id = 9, Name = "Robert", LastName = "Thomas", Age = 29, Salary = 58000, Department = "Finance" },
            new Employee { Id = 10, Name = "Jessica", LastName = "Harris", Age = 38, Salary = 72000, Department = "Sales" },
            new Employee { Id = 11, Name = "Chris", LastName = "Martinez", Age = 36, Salary = 74000, Department = "IT" },
            new Employee { Id = 12, Name = "Karen", LastName = "Garcia", Age = 34, Salary = 67000, Department = "Marketing" },
            new Employee { Id = 13, Name = "Daniel", LastName = "Rodriguez", Age = 42, Salary = 79000, Department = "HR" },
            new Employee { Id = 14, Name = "Amy", LastName = "Clark", Age = 31, Salary = 61000, Department = "Sales" },
            new Employee { Id = 15, Name = "Brian", LastName = "Lewis", Age = 39, Salary = 71000, Department = "Engineering" },
            new Employee { Id = 16, Name = "Olivia", LastName = "Walker", Age = 26, Salary = 50000, Department = "Finance" },
            new Employee { Id = 17, Name = "Brandon", LastName = "Robinson", Age = 41, Salary = 76000, Department = "IT" },
            new Employee { Id = 18, Name = "Sophia", LastName = "Young", Age = 29, Salary = 56000, Department = "Marketing" },
            new Employee { Id = 19, Name = "Eric", LastName = "Hall", Age = 33, Salary = 63000, Department = "HR" },
            new Employee { Id = 20, Name = "Michelle", LastName = "Allen", Age = 37, Salary = 73000, Department = "Engineering" },
            new Employee { Id = 21, Name = "Kyle", LastName = "Scott", Age = 44, Salary = 78000, Department = "Sales" },
            new Employee { Id = 22, Name = "Julia", LastName = "Adams", Age = 25, Salary = 49000, Department = "HR" },
            new Employee { Id = 23, Name = "Ethan", LastName = "Miller", Age = 47, Salary = 81000, Department = "Finance" },
            new Employee { Id = 24, Name = "Megan", LastName = "Turner", Age = 28, Salary = 55000, Department = "Marketing" },
            new Employee { Id = 25, Name = "Lucas", LastName = "Campbell", Age = 52, Salary = 83000, Department = "Engineering" },
            new Employee { Id = 26, Name = "Chloe", LastName = "Perez", Age = 31, Salary = 60000, Department = "IT" },
            new Employee { Id = 27, Name = "Liam", LastName = "Collins", Age = 38, Salary = 72000, Department = "Sales" },
            new Employee { Id = 28, Name = "Emma", LastName = "James", Age = 40, Salary = 68000, Department = "HR" },
            new Employee { Id = 29, Name = "Andrew", LastName = "Baker", Age = 46, Salary = 77000, Department = "Finance" },
            new Employee { Id = 30, Name = "Isabella", LastName = "Hughes", Age = 30, Salary = 64000, Department = "Marketing" },
            new Employee { Id = 31, Name = "George", LastName = "Wright", Age = 33, Salary = 67000, Department = "Engineering" },
            new Employee { Id = 32, Name = "Anna", LastName = "Lopez", Age = 29, Salary = 56000, Department = "HR" },
            new Employee { Id = 33, Name = "Tyler", LastName = "King", Age = 40, Salary = 78000, Department = "Sales" },
            new Employee { Id = 34, Name = "Ella", LastName = "Green", Age = 25, Salary = 50000, Department = "Marketing" },
            new Employee { Id = 35, Name = "Henry", LastName = "Carter", Age = 44, Salary = 82000, Department = "IT" },
            new Employee { Id = 36, Name = "Natalie", LastName = "Mitchell", Age = 35, Salary = 71000, Department = "Finance" },
            new Employee { Id = 37, Name = "Zach", LastName = "Lee", Age = 37, Salary = 76000, Department = "Engineering" },
            new Employee { Id = 38, Name = "Sophie", LastName = "Perez", Age = 27, Salary = 55000, Department = "HR" },
            new Employee { Id = 39, Name = "Jacob", LastName = "Scott", Age = 32, Salary = 67000, Department = "Sales" },
            new Employee { Id = 40, Name = "Grace", LastName = "Evans", Age = 30, Salary = 63000, Department = "Marketing" },
            new Employee { Id = 41, Name = "Sam", LastName = "Torres", Age = 43, Salary = 80000, Department = "IT" },
            new Employee { Id = 42, Name = "Emma", LastName = "Hill", Age = 26, Salary = 52000, Department = "Finance" },
            new Employee { Id = 43, Name = "Caleb", LastName = "Walker", Age = 50, Salary = 85000, Department = "Engineering" },
            new Employee { Id = 44, Name = "Mia", LastName = "Bennett", Age = 29, Salary = 58000, Department = "HR" },
            new Employee { Id = 45, Name = "Jack", LastName = "Gonzalez", Age = 41, Salary = 75000, Department = "Sales" },
            new Employee { Id = 46, Name = "Abigail", LastName = "Nelson", Age = 36, Salary = 69000, Department = "Marketing" },
            new Employee { Id = 47, Name = "Blake", LastName = "Reed", Age = 33, Salary = 67000, Department = "IT" },
            new Employee { Id = 48, Name = "Avery", LastName = "Campbell", Age = 48, Salary = 83000, Department = "Finance" },
            new Employee { Id = 49, Name = "Isaac", LastName = "Howard", Age = 39, Salary = 71000, Department = "Engineering" },
            new Employee { Id = 50, Name = "Lily", LastName = "Brooks", Age = 31, Salary = 62000, Department = "HR" }
        };
    }

}