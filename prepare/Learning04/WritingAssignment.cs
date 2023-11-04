public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string StudentName, string Topic, string Title) : base(StudentName, Topic)
    {
        _title = Title;
    }

    public string GetWritingInformation()
    {
<<<<<<< HEAD
        return $"{_title} by {base.GetStudentName}";
=======
        return $"{_title} by {GetStudentName()}";
>>>>>>> b688a7961cd1c2b2bfd0aaf91773f581fd842f0d
    }
}