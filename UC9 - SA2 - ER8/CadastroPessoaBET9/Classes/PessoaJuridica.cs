using System.Text.RegularExpressions;
using CadastroPessoaBET9.Interfaces;

namespace CadastroPessoaBET9.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj { get; set; }

        public string? razaoSocial { get; set; }

        public string caminho { get; private set; } = "Database/PessoaJuridica.csv";

        //  Para Rendimentos até 3000, 3%
        // 	Para rendimentos entre 3000 e 6000, 5%
        // 	Para rendimentos entre 6000 e 10000, 7%
        // 	Para rendimentos acima de 10000, 9%
        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * .03f;

            }
            else if (rendimento <= 6000)
            {
                return rendimento * .05f;

            }
            else if (rendimento <= 10000)
            {
                return rendimento * .07f;

            }
            else
            {
                return rendimento * .09F;
            }
        }

        // XX.XXX.XXX/0001-XX
        // XXXXXXXX0001XX
        public bool ValidarCnpj(string cnpj)
        {
            bool retornoCnpjValido = Regex.IsMatch(cnpj, @"(^(\d{14})|(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})$)");

            //if(retornoCnpjValido == true)
            if (retornoCnpjValido)
            {

                if (cnpj.Length == 14)
                {
                    string subStringCnpj14 = cnpj.Substring(8, 4);

                    if (subStringCnpj14 == "0001")
                    {
                        return true;
                    }
                    return false;

                }

                string subStringCnpj18 = cnpj.Substring(11, 4);

                if (subStringCnpj18 == "0001")
                {
                   return true; 
                }
            }

            return false;
        }

        public void Inserir(PessoaJuridica pj){
            Utils.VerificarPastaArquivo(caminho);

            // Montando o que vai ser inserido
            string[] pjValores = {$"{pj.nome},{pj.cnpj},{pj.razaoSocial}"};

            File.AppendAllLines(caminho, pjValores);
        }

        // transforma o arquivo csv em uma lista
        public List<PessoaJuridica> LerArquivo(){
            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(caminho);

            // Nome Pj 1,62.401.115/0001-40,Razão Social Pj
            // nome, cnpj, razaosocial
            // 0, 1, 2
            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica novaPj = new PessoaJuridica();

                novaPj.nome = atributos[0];
                novaPj.cnpj = atributos[1];
                novaPj.razaoSocial = atributos[2];

                listaPj.Add(novaPj);
            }

            return listaPj;
        }
    }
}