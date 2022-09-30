using CadastroPessoaBET9.Classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Odirlei";
novaPf.cpf = "1234567890";

Console.WriteLine(novaPf.nome);

Console.WriteLine("Nome: " + novaPf.nome + " - CPF: " + novaPf.cpf);
Console.WriteLine($"Nome: {novaPf.nome} - CPF: {novaPf.cpf}");