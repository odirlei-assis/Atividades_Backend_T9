using CadastroPessoaBET9.Interfaces;

namespace CadastroPessoaBET9.Classes
{
    public class PessoaJuridica : Pessoa , IPessoaJuridica
    {
        public string? cnpj { get; set; }

        public string? razaoSocial { get; set; }

        //  Para Rendimentos até 3000, 3%
        // 	Para rendimentos entre 3000 e 6000, 5%
        // 	Para rendimentos entre 6000 e 10000, 7%
        // 	Para rendimentos acima de 10000, 9%
        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * .03f;

            }else if (rendimento <= 6000)
            {
                return rendimento * .05f;

            }else if (rendimento <= 10000)
            {
                return rendimento * .07f;

            }else
            {
                return rendimento * .09F;
            }
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}