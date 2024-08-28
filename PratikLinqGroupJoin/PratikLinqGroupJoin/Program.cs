using PratikLinqGroupJoin;

List<Student> students = new List<Student>();
students.Add(new Student() { StudentName = "Harun Tokel", ClassId = 1, StudentId = 1 });
students.Add(new Student() { StudentName = "Yağmur Kaya", ClassId = 3, StudentId = 2 });
students.Add(new Student() { StudentName = "Ramazan Koç", ClassId = 2, StudentId = 3 });
students.Add(new Student() { StudentName = "Selahattin Aksu", ClassId = 1, StudentId = 4 });
students.Add(new Student() { StudentName = "Emrullah Aksu", ClassId = 3, StudentId = 5 });

List<Class> classes = new List<Class>();
classes.Add(new Class { ClassId = 1, ClassName = "Matematik" });
classes.Add(new Class { ClassId = 2, ClassName = "Türkçe" });
classes.Add(new Class { ClassId = 3, ClassName = "Kimya" });


var groupedStudens = classes.GroupJoin(
    students,
    clas => clas.ClassId,
    student => student.ClassId,
    (clas, studentGroup) => new
    {
        ClassNames = clas.ClassName,
        Students = studentGroup.Select(s => s.StudentName).ToList()
    });

foreach (var group in groupedStudens)
{
    Console.WriteLine($"Dersler: {group.ClassNames}");
    foreach (var student in group.Students)
    {
        Console.WriteLine($"Ogrenciler: {student}");
    }
}