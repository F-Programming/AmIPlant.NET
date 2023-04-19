namespace AmIPlant.Core.Entities;

public class Component
{
    public TimeSpan Turnover { get; set; }
    public Func<float>? PercentMass { get; set; }
}