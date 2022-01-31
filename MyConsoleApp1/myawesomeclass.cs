using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace MyConsoleApp1
{
    class myawesomeclass: myawesomeinterface
    {
        //AF 31/1/22 corso pluralsight

        public string GestSomething(string one,
                                    string two,
                                    string three,
                                    DateTime four)
        {

            List<string> strings = new List<string>() { one, two, three };

#pragma warning disable CS8321 // La funzione locale è dichiarata, ma non viene mai usata
            IEnumerable<string> enumerable()
#pragma warning restore CS8321 // La funzione locale è dichiarata, ma non viene mai usata
            {
                foreach (var str in strings)
                {
                    if (str.Length < 2)
                    {
                        yield return str;
                    }
                }
                yield break;
            }

            return Assembly.GetExecutingAssembly().FullName;
        }
            
    }
}
