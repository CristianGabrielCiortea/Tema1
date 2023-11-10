namespace ExercitiiSet1.Exercise7
{
    public class Teacher : Person
    {
        public string? University { get; set; }
        public string? Faculty { get; set; }
        public List<Course> Courses { get; set; }

        public Teacher(string? firstName, string? lastName, string? cnp, string? univeristy, string? faculty) 
            : base(firstName, lastName, cnp)
        {
            Courses = new List<Course>();
            University = univeristy;
            Faculty = faculty;
        }

        public override void ShowInformation()
        {
            Console.WriteLine("Teacher:");
            Console.WriteLine("FirstName: " + FirstName + " LastName: " + LastName + " CNP: " + CNP);
            Console.WriteLine("University: " + University + " Faculty: " + Faculty);
            Console.WriteLine("Course:");
            foreach(var course in Courses)
            {
                course.ShowInformation();
            }
        }
    }
}