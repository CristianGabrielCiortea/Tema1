namespace ExercitiiSet1.Exercise7
{
    public class Student : Person
    {
        public string? University { get; set; }
        public string? Faculty { get; set; }
        //the int represents the grade for the specific course
        public Dictionary<Course, int> Courses { get; set; }

        public Student(string? firstName, string? lastName, string? cnp, string? university, string? faculty)
            : base(firstName, lastName, cnp)
        {
            Courses = new Dictionary<Course, int>();
            University = university;
            Faculty = faculty;
        }

        public override void ShowInformation()
        {
            Console.WriteLine("Student:");
            Console.WriteLine("FirstName: " + FirstName + " LastName: " + LastName + " CNP: " + CNP);
            Console.WriteLine("University: " + University + " Faculty: " + Faculty);
            Console.WriteLine("Courses:");
            foreach (var pair in Courses)
            {
                pair.Key.ShowInformation();
                Console.WriteLine($"Grade: {pair.Value}");
            }
        }

        public void AddGrade(Course course, int grade)
        {
            if (Courses.ContainsKey(course))
            {
                Courses[course] = grade;
            }
            else
            {
                Courses.Add(course, grade);
            }
        }
    }
}