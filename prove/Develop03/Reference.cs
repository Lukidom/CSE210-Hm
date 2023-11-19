using System;
using System.IO;
using System.IO.Enumeration;

public class Reference
{
public Reference()
{

}
string filename = "";
string inputScripture = "";
public void StoreScripture()
{
    // filename = Console.ReadLine();

    StreamWriter scripture = new StreamWriter(filename);


}
public void LoadScripture()
{
    StreamReader scripture = new StreamReader(filename);
}
}

