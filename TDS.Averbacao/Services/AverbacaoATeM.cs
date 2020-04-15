using net.r_eg.DllExport;
using TDS.Averbacao.br.com.averba.webserver;

namespace TDS.Averbacao.Services
{
    public class AverbacaoATeM
    {
        public readonly static ATMWebSvr client = new ATMWebSvr();

        [DllExport]
        public static string AverbarCTe()
        {
            var result = client.averbaCTe("usuario", "senha", "codatm", "xmlCte");
            return result.ToString();
        }
    }
}
