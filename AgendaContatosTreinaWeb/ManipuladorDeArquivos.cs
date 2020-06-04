using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AgendaContatosTreinaWeb
{
    public class ManipuladorDeArquivos
    {
        private static string EnderecoArquivo = AppDomain.CurrentDomain.BaseDirectory + "contato.txt";
        public static List<Contato> LerArquivo()
        {
            List<Contato> contatoList = new List<Contato>();
            if (File.Exists(@EnderecoArquivo))
            {
                using (StreamReader sr = File.OpenText(@EnderecoArquivo))
                {
                    while (sr.Peek() >= 0)
                    {
                        string linha = sr.ReadLine();
                        string[] linhaSplit = linha.Split(';');
                        if(linhaSplit.Count() == 3)
                        {
                            Contato contato = new Contato();
                            contato.Nome = linhaSplit[0];
                            contato.Email = linhaSplit[1];
                            contato.NumeroTelefone = linhaSplit[2];
                            contatoList.Add(contato);
                        }
                    }
                }
            }
            return contatoList;
        }
        public static void EscreverArquivo(List<Contato> contatosList)
        {

            using (StreamWriter sw = new StreamWriter(@EnderecoArquivo, false))
            {
                foreach (Contato contato in contatosList)
                {
                    string linha = string.Format("{0};{1};{2}", contato.Nome, contato.Email, contato.NumeroTelefone);
                    sw.WriteLine(linha);
                }
                //limpa buffer do arquivo
                sw.Flush();
            }
        }
    }
}
