using CadastroPessoaBET9.Classes;

// PessoaFisica novaPf = new PessoaFisica();
// Endereco novoEndPf = new Endereco();

// novaPf.nome = "Odirlei";
// novaPf.cpf = "1234567890";
// novaPf.rendimento = 6600.5f;
// novaPf.dataNasc = new DateTime(2000, 01, 01);

// novoEndPf.logradouro = "Rua Niteroi";
// novoEndPf.numero = 180;
// novoEndPf.complemento = "Senai Informatica";
// novoEndPf.endComercial = true;

// novaPf.endereco = novoEndPf;

// Console.WriteLine(@$"
// Nome: {novaPf.nome}
// Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
// Maior de idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
// ");

// Console.WriteLine("Nome: " + novaPf.nome + " - CPF: " + novaPf.cpf);
// Console.WriteLine($"Nome: {novaPf.nome} - CPF: {novaPf.cpf}");

// float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);

// Console.WriteLine(impostoPagar);
// Console.WriteLine($"R$ {impostoPagar:0.00}");
// Console.WriteLine(impostoPagar.ToString("C"));


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

Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj} - Valido: {novaPj.ValidarCnpj(novaPj.cnpj)}
");



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