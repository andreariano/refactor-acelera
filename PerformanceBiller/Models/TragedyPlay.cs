namespace PerformanceBiller.Models
{
    public class TragedyPlay : IPlay
    {
        public TragedyPlay(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
