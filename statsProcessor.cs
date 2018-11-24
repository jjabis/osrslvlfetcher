using System;
using System.Threading.Tasks;

namespace statsgetter
{
    public class statsProcessor
    {
        private IStatsFetcher _StatsFetcher;

        public statsProcessor(IStatsFetcher StatsFetcher) {
            _StatsFetcher = StatsFetcher;
        }
        public Task<string> GetStats(string userName)
        {
            return _StatsFetcher.GetStats(userName);
        }


    }
}