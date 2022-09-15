using CadastroPessoaBET9.Classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Odirlei";
novaPf.cpf = "1234567890";
novaPf.rendimento = 6600.5f;

// Console.WriteLine(novaPf.nome);

// Console.WriteLine("Nome: " + novaPf.nome + " - CPF: " + novaPf.cpf);
// Console.WriteLine($"Nome: {novaPf.nome} - CPF: {novaPf.cpf}");

float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);

Console.WriteLine(impostoPagar);
Console.WriteLine($"R$ {impostoPagar:0.00}");
Console.WriteLine(impostoPagar.ToString("C"));


PessoaJuridica novaPj = new PessoaJuridica();
Console.WriteLine(novaPj.CalcularImposto(6600.5f));




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