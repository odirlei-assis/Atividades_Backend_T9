using CadastroPessoaBET9.Interfaces;

namespace CadastroPessoaBET9.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica
    {
        public string? cpf { get; set; }

        public DateTime dataNasc { get; set; }

        public string caminho { get; private set; } = "Database/PessoaFisica.csv";


//  Para rendimentos até 1500, isento
// 	Para rendimentos entre 1500 e 3500, 2%
// 	Para rendimentos entre 3500 e 6000, 3,5%
// 	para rendimentos acima de 6000, 5%
        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;
            }else if (rendimento > 1500 && rendimento <= 3500)
            {
                float resultado = (rendimento / 100) * 2;

                return resultado;

            }else if (rendimento > 3500 && rendimento <= 6000)
            {
                float resultado = (rendimento / 100) * 3.5f;

                return resultado;
                
            }else
            {
                float resultado = (rendimento / 100) * 5;

                return resultado;
            }

        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays / 365;

            Console.WriteLine(anos);
            
            if (anos >= 18)
            {
                return true;
            }
            
            return false;
            
        }


        public bool ValidarDataNasc(string dataNasc)
        {
            
            if (DateTime.TryParse(dataNasc, out DateTime dataConvertida))
            {
                DateTime dataAtual = DateTime.Today;

                double anos = (dataAtual - dataConvertida).TotalDays / 365;

                Console.WriteLine(anos);

                if (anos >= 18)
                {
                    return true;
                }
            }
            return false;
        }

        public void Inserir(PessoaFisica pf){
            Utils.VerificarPastaArquivo(caminho);

            // Montando o que vai ser inserido
            string[] pfValores = {$"{pf.nome},{pf.cpf},{pf.dataNasc}"};

            File.AppendAllLines(caminho, pfValores);
        }
    }
}