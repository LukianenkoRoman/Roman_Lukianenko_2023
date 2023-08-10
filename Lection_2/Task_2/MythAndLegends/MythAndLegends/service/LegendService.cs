using MythAndLegends.Data;
using MythAndLegends.Data.Entity;
using MythAndLegends.Services.Interface;

namespace MythAndLegends.Services;

public class LegendService : ILegendStoryService
{
    public void AddLegend(Legend legend)
    {
        if (string.IsNullOrEmpty(legend.StoryCode))
        {
            legend.StoryCode = CreateLegendCode(legend.Name);
        }

        Storage.Legends.Add(legend);
    }

    public Story? GetLegendByCode(string code)
    {
        return Storage.Legends.FirstOrDefault(x => x.StoryCode.Equals(code));
    }

    private string CreateLegendCode(string name)
    {
        var code = $"{name.First()}{name.Last()}-{name.Length}";

        return code;
    }
}

