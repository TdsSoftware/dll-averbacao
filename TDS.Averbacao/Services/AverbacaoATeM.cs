using net.r_eg.DllExport;
using TDS.Averbacao.br.com.averba.webserver;

namespace TDS.Averbacao.Services
{
    public class AverbacaoATeM
    {
        public static readonly ATMWebSvr client = new ATMWebSvr();

        [DllExport]
        public static string Averbar(string usuario, string senha, string codAtm, string tipoDoc, string xml)
        {
            if (tipoDoc == "CT")
            {
                return client.averbaCTe(usuario, senha, codAtm, xml).Serialize<Retorno>();
            }
            else
            {
                return client.declaraMDFe(usuario, senha, codAtm, xml).Serialize<RetornoMDFe>();
            }
        }
    }
}
