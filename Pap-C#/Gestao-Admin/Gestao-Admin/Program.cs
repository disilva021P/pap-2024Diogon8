using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_Admin
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string caminhoArquivo = @"C:\Users\Aorus\Desktop\Pap\Pap-C#\Gestao-Admin\Gestao-Admin\arquivos\ConfiguracoesParque.json";
            string jsonConteudo = File.ReadAllText(caminhoArquivo);
            JObject jsonObj = JObject.Parse(jsonConteudo);
            int confpago = Convert.ToInt32(jsonObj["configuracoes"][0]["ConfPago"]);
            int lugmarcados = Convert.ToInt32(jsonObj["configuracoes"][0]["LugaresMarcados"]);
            if (confpago == -1 && lugmarcados == -1)
            {
                Application.Run(new LoginAdmin());
            }
            else
            {
                Application.Run(new PopUp("mensagem de ativacao",1));
            }
        }
    }
}
