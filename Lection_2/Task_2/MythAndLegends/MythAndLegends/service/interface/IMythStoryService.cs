using MythAndLegends.Data.Entity;

namespace MythAndLegends.Services.Interface;

public interface IMythStoryService
{
    public void AddMyth(Myth myth);

    public Story? GetMythByCode(string code);

    public string CreateMythCode(string name)
}

//to not violate interface segregation i decide to made two enother interfaces instead of "IStoryService"