namespace MythAndLegends.Data.Entity;

public abstract class Story : Story 
{
    public string StoryCode { get; set; }
    public string Name { get; set; }
    public string Content { get; set; }
}

//The principe are following becouse every string have are same meaning  

public abstract class Story : StoryTell
    public virtual void Tell()
    {
        Console.WriteLine("------------------------------");
    }
}

//Original child class wsa splited to follow the SRP reincipe