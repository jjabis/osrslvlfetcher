using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace statsgetter
{
    public class OsrsStatsFetcher : IStatsFetcher {

        

        public async Task<string> GetStats(string userName){
        HttpClient jotain = new HttpClient();

        var sivu = new Uri("https://secure.runescape.com/m=hiscore_oldschool/index_lite.ws?player="+userName);
        
        string v = await jotain.GetStringAsync(sivu);
        
        var stringData = v;
        string f = stringData;

        return f;
        }

    }
}