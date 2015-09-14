namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        // Foreign key property
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        // This property is an enum, the ? mark after the Grade type
        // declaration means that the property is nullable
        public Grade? Grade { get; set; }

        // Navigation property
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}