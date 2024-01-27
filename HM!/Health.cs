using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_
{
    public class Health
    {
        public string[] racion {  get; set; }
        public string[] fisical { get; set; }
        public string[] privichka { get; set; }

        public Health(string[] racion, string[] fisical, string[] privichka)
        {
            this.racion = racion;
            this.fisical = fisical;
            this.privichka = privichka;
        }

        public void Print_racion()
        {
            foreach (var r in racion)
            {
                Console.WriteLine(r);
            }
        }
        public void Print_fisical()
        {
            foreach (var f in fisical)
            {
                Console.WriteLine(f);
            }
        }
        public void Print_privichka()
        {
            foreach (var p in privichka)
            {
                Console.WriteLine(p);
            }
        }
    }
}
