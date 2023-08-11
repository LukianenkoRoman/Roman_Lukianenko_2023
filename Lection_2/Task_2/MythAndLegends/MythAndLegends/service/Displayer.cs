using MythAndLegends.Data;
using MythAndLegends.Data.Entity;
using MythAndLegends.Services.Interface;

namespace MythAndLegends.Services;

public class Display : IDisplay
{
    private readonly IStoryService _legendService;
    private readonly IStoryService _mythService;

    public Display(ILegendStoryService _legendService, IMythStoryService _mythService) //now this class gets values with constructor to follow DIP
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
        else if                   
        {
            Console.WriteLine($"No myth or legend with code {code}");
        }
    }

