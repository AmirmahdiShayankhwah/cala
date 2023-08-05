using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prodoct_cala
{
     public abstract class abccala
    {
        int id;
        string namecala;
        string medin;
        int price;
        string color;

        public void submitcala()
        {
            id = int.Parse(Console.ReadLine());
        }
        public void deletcala()
        {
            namecala = Console.ReadLine();
        }
        public void submitcolor()
        {
            color = Console.ReadLine();
        }
        public void selecalaonline()
        {
            
        }
        public void submitnamecala()
        {
            namecala = Console.ReadLine();
        }
        public void submitpricecala()
        {

        }
        public void submitgraphiccala()
        {

        }
       
    }
    public class lobtob : abccala
    {

    }
}
