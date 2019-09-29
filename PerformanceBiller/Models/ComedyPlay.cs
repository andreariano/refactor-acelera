namespace PerformanceBiller.Models
{
    public class ComedyPlay : IPlay
    {
        public ComedyPlay(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
