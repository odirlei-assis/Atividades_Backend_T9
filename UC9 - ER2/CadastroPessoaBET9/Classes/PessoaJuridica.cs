using CadastroPessoaBET9.Interfaces;

namespace CadastroPessoaBET9.Classes
{
    public class PessoaJuridica : Pessoa , IPessoaJuridica
    {
        public string? cnpj { get; set; }

        public string? razaoSocial { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}