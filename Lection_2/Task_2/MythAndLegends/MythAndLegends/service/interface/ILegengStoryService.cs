using MythAndLegends.Data.Entity;

namespace MythAndLegends.Services.Interface;

public interface ILegendStoryService
{
    public void AddLegend(Legend legend);

    public Story? GetLegendByCode(string code);

    public string CreateLegendCode(string name)
}

//to not violate interface segregation i decide to made two enother interfaces instead of "IStoryService"