namespace ExercitiiSet1.Exercise7
{
    public abstract class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CNP { get; set; }

        public Person(string? firstName, string? lastName, string? cnp)
        {
            FirstName = firstName;
            LastName = lastName;
            CNP = cnp;
        }

        public abstract void ShowInformation();
    }
}