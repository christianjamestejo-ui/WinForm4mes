using LinqSample;

List<Student> students = new List<Student>();
students.Add(new Student
{
    Id = 1,
    FirstName = "Christian",
    LastName = "Tejo",
    Gender = 'M',
    Age = 20
});
students.Add(new Student
{
    Id = 2,
    FirstName = "Jovelyn",
    LastName = "Azcuna",
    Gender = 'F',
    Age = 19
});
students.Add(new Student
{
    Id = 3,
    FirstName = "Thea",
    LastName = "Baron",
    Gender = 'F',
    Age = 30
});
students.Add(new Student
{
    Id = 4,
    FirstName = "Norwitsky",
    LastName = "Betonio",
    Gender = 'M',
    Age = 5
});
students.Add(new Student
{
    Id = 5,
    FirstName = "Wendy",
    LastName = "Canada",
    Gender = 'F',
    Age = 60
});

// All

Console.WriteLine("All list of students");

var studentList = students.ToList();

foreach (var student in studentList)
{
    Console.WriteLine($"{student.Id}: {student.LastName}, {student.FirstName}");
}

Console.WriteLine("First Student");

var firstStudent = studentList.FirstOrDefault();

if (firstStudent == null)
{
    Console.WriteLine("No Student Found.");
    Console.ReadKey();
    return;
}

Console.WriteLine($"{firstStudent.Id}: {firstStudent.LastName}, {firstStudent.FirstName}");

Console.WriteLine("Female Students");

var femaleStudents = studentList.Where(student => student.Gender == 'F').ToList();

foreach (var student in femaleStudents)
{
    Console.WriteLine($"{student.Id}: {student.LastName}, {student.FirstName}");
}

Console.WriteLine("Young Students");

var youngStudents = studentList.Where(student => student.Age < 60).ToList();

foreach (var student in youngStudents)
{
    Console.WriteLine($"{student.Id}: {student.LastName}, {student.FirstName}");
}

Console.WriteLine("Legal Male Students");

var legalMaleStudents = studentList.Where(student => student.Age >= 18 && student.Gender == 'M').ToList();

foreach (var student in legalMaleStudents)
{
    Console.WriteLine($"{student.Id}: {student.LastName}, {student.FirstName}");
}

Console.ReadKey();