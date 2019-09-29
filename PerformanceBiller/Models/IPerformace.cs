namespace PerformanceBiller.Models
{
    public interface IPerformace<T> where T : IPlay
    {
        decimal CalculatePerformace();

        int CalculateVolumeCredits();
    }
}
