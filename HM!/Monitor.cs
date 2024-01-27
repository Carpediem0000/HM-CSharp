using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_
{
    public class Monitor : Health
    {
        public string[] recommend {  get; set; }
        public Monitor(string[] racion, string[] fisical,
            string[] privichka) : base(racion, fisical,
                privichka)
        {
            recommend = new string[]
            {
                "Brosit kurit",
                "Zaryadka",
                "Progulka",
                "Run",
                "Fisical"
            };
        }

        public string Recommends(int index_rec)
        {
            if (index_rec < 0 || index_rec > recommend.Length)
            {
                return null;
            }
            return recommend[index_rec];
        }
        
    }
}
