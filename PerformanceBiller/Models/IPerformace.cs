namespace PerformanceBiller.Models
{
    public interface IPerformace<T> where T : IPlay
    {
        IPlay Play { get; }

        int Audience { get; }

        decimal PerformaceTotal { get; }

        decimal CalculatePerformace();

        int CalculateVolumeCredits();
    }
}
