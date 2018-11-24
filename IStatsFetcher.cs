using System.Threading.Tasks;

namespace statsgetter
{
    public interface IStatsFetcher
    {
         Task<string> GetStats(string userName);
    }
}