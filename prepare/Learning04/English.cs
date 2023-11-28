using System;

using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class English : Base
{
    protected string _title;

    public English()
    {

    }

    public string GetWritingInformation(string essayTopic)
    {
        _title = essayTopic;
        
        return $"{_studentName} - {_topic} - {_title}";
    }
    
}