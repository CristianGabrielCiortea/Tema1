namespace ExercitiiSet1.Exercise7
{
    public class Course
    {
        public string? Name { get; set; }
        public int Duration { get; set; }
        public int NumberOfSeats { get; set; }
        public List<Student> Students { get; set; }
        public Teacher? Teacher { get; set; }

        public Course(string? name, int duration, int numberOfSeats, Teacher teacher) 
        {
            Students = new List<Student>();
            Name = name;
            Duration = duration;
            NumberOfSeats = numberOfSeats;
            Teacher = teacher;
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Course name: {Name}, Duration: {Duration}, Number of seats: {NumberOfSeats}");
        }
    }
}