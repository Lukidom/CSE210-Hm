using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123","testcity", "testState", "12345");
        OutdoorGathering outdoorGathering = new OutdoorGathering("camping", "outdoor gathering for men and sons", "april 5", "2;00 pm", address, "partly cloudy");
        Console.WriteLine(outdoorGathering.DisplayStandardDetails());
        Console.WriteLine(outdoorGathering.DisplayExtraDetails());
        Console.WriteLine(outdoorGathering.DisplayShortDescription());

        Lecture lecture = new Lecture("Lecure on faith", "Learn about the power of faith and what it can do for you", "Fabuary 10", "6pm", address, "Chuck norris", 50);
        Console.WriteLine(lecture.DisplayExtraDetails());
        Console.WriteLine(lecture.DisplayStandardDetails());
        Console.WriteLine(lecture.DisplayShortDescription());

        Reception reception = new Reception("marrage of people", "Reception folling the wedding of smith and angela", "1904", "4:00", address, "Sunny");
        Console.WriteLine(reception.DisplayStandardDetails());
        Console.WriteLine(reception.DisplayShortDescription());

        


    }

}