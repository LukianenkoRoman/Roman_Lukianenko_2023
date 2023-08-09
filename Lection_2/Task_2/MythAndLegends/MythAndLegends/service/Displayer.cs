using MythAndLegends.Data;
using MythAndLegends.Data.Entity;
using MythAndLegends.Services.Interface;

namespace MythAndLegends.Services;

public class Display : IDisplay
{
    private readonly IStoryService _legendService;
    private readonly IStoryService _mythService;

    public Display(IStoryService _legendService, IStoryService _mythService) //now this class gets values with constructor to follow DIP
    {
        _legendService = LegendService();
        _mythService = MythService();
    }

    public void DisplayByCode(string code)
    {
        var legend = _legendService.GetLegendByCode(code);
        var myth = _mythService.GetMythByCode(code);

        if (legend is not null)
        {
            legend.Tell();
        }
        else if (myth is not null)
        {
            myth.Tell();
        }
        else if     //we cannot use "else" becouse we need to keep abilyty of adding finctional without refactoring                
        {
            Console.WriteLine($"No myth or legend with code {code}");
        }
    }

public class Dysplay : AddNewStory() //Here i decide split class to follow the single reponsibility pryniple  
    {
        Console.WriteLine("Enter story type (myth/legend)");
        var input = Console.ReadLine();

        if (input == "legend")
        {
            Console.WriteLine("Enter name of the legend");
            var name = Console.ReadLine();
            Console.WriteLine("Enter object of the legend");
            var storyObject = Console.ReadLine();
            Console.WriteLine("Enter the story");
            var storyText = Console.ReadLine();

            var story = new Legend()
            {
                Name = name,
                Object = storyObject,
                Content = storyText
            };

            Storage.Legends.Add(story);
        }
        else if (input == "myth")
        {
            Console.WriteLine("Enter name of the myth");
            var name = Console.ReadLine();
            Console.WriteLine("Enter the story");
            var storyText = Console.ReadLine();
            Console.WriteLine("Enter some fact");
            var fact = Console.ReadLine();

            var story = new Myth()
            {
                Name = name,
                Fact = fact,
                Content = storyText
            };

            Storage.Myths.Add(story);
        }

        Console.WriteLine("Oops, wrong input");
    }
}