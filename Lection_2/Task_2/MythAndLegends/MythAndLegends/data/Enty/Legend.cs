namespace MythAndLegends.Data.Entity;

public class Legend : Object
{
    public string Object { get; set; }
}
    
public class Legend : StroryTell
    public override void Tell()
    {
        Console.WriteLine($"Legend {StoryCode} - {Name} \n" +
                          $"Legend tells about {Object} \n" +
                          $"{Content}");
        base.Tell();
    }
}

//Original child class wsa splited to follow the SRP reincipe
