using System;
using System.Dynamic;

// base class
class Base
{
    protected string _studentName;

    protected string _topic;

    
    public Base()
    {


    }
    public void GetStudentNameandtopic(string studentName, string topic)
    {
        _studentName = studentName;
    
        _topic = topic;

    }

    // Displays students name and topic
    public string GetSummary()
    {
        return $"Students name: {_studentName} \n Topic: {_topic}";
    }
    // Need a constructor with two arguments?
   
    // getter and setter for student name and topic

}   