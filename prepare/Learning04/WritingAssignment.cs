using System;

public class WritingAssignment : Assignment
{
    private string _title;
    private string _studetName;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
        _studetName = studentName;

    }

    public string GetWritingInformation()
    {
        return _title + " - " + _studentName;
    }
}