using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Log4Net
{
    internal class Program
    {
        private static readonly ILog Log = Logs.GetLogger();
        static void Main(string[] args)
        {
            var numero = "Hello world!";

            try
            {
                int.Parse(numero);
            }
            catch(Exception ex)
            {
                Log.Error(ex + "\n   " + "Valor del numero a castear a int: " + numero);
            }

        }
    }
}
