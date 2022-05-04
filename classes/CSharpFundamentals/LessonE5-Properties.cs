using System;
public class Person
{
    string name;

      public void SetName(string value)
    {
        // if(value.Length > 2)
        // {
        //     name = value;
        // }
    }

    // full property syntax
    public string Name
    {
        get
        {
            return name;
        }

        set
        {
        if(value.Length > 2)
            name = value;
        
        }
    }
    // DateTime dob; 
    public DateTime Dob {get; set; } // private field auto implemented property

    // public string address;
    
    // Readonly property
    public string Address{get;}

    public char Gender{get; private set; } = 'F';


}