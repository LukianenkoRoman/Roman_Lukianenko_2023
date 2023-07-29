namespace MythAndLegends.Data.Entity;

public class Myth : Story
{
    public string Fact { get; set; }
}

public class Myth : StoryTell
    public override void Tell()
    {
        Console.WriteLine($"Myth {StoryCode} - {Name} \n" +
                          $"{Content} \n" +
                          $"Fact: {Fact}");
        base.Tell();
    }
}

//Original child class wsa splited to follow the SRP reincipe