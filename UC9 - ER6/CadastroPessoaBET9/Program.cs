using CadastroPessoaBET9.Classes;

Console.Clear();
Console.WriteLine(@$"
=============================================
|   Bem vindo ao sistema de cadastro de     |
|       Pessoa Físicas e Juridícas          |
=============================================
");

Utils.BarraCarregamento("Carregando", 10, ".", 200);

string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
=============================================
|       Escolha uma das opções abaixo       |
|-------------------------------------------|
|           1 - Pessoa Física               |
|           2 - Pessoa Juridíca             |
|                                           |
|           0 - Sair                        |
=============================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            PessoaFisica novaPf = new PessoaFisica();
            Endereco novoEndPf = new Endereco();

            novaPf.nome = "Odirlei";
            novaPf.cpf = "1234567890";
            novaPf.rendimento = 6600.5f;
            novaPf.dataNasc = new DateTime(2000, 01, 01);

            novoEndPf.logradouro = "Rua Niteroi";
            novoEndPf.numero = 180;
            novoEndPf.complemento = "Senai Informatica";
            novoEndPf.endComercial = true;

            novaPf.endereco = novoEndPf;

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
Maior de idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
");

            Console.WriteLine($"Aperte 'ENTER' para continuar");
            Console.ReadLine();
                        
            break;

        case "2":

            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.nome = "Nome Pj";
            novaPj.razaoSocial = "Razão Social Pj";
            novaPj.cnpj = "62.401.115/0001-40";
            novaPj.rendimento = 6000.5f;

            novoEndPj.logradouro = "Rua Niteroi";
            novoEndPj.numero = 180;
            novoEndPj.complemento = "Senai informatica";
            novoEndPj.endComercial = true;

            novaPj.endereco = novoEndPj;

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj} - Valido: {novaPj.ValidarCnpj(novaPj.cnpj)}
");

            Console.WriteLine($"Aperte 'ENTER' para continuar");
            Console.ReadLine();


            break;

        case "0":
            Console.WriteLine($"Obrigado por utilizar nosso sistema");

            Utils.BarraCarregamento("Finalizando", 5, "+", 500);


            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Opção inválida, por favor digite uma opção válida");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }

} while (opcao != "0");




























// Console.WriteLine("Nome: " + novaPf.nome + " - CPF: " + novaPf.cpf);
// Console.WriteLine($"Nome: {novaPf.nome} - CPF: {novaPf.cpf}");


// float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);

// Console.WriteLine(impostoPagar);
// Console.WriteLine($"R$ {impostoPagar:0.00}");
// Console.WriteLine(impostoPagar.ToString("C"));


// == igualdade
// > maior que
// < menor que
// >= maior ou igual
// <= menor ou igual
// != diferente

// && 'e'
// V && V = V
// F && V = F
// V && F = F
// F && F = F

// || 'ou'
// V || V = V
// F || V = V
// V || F = V
// F || F = F