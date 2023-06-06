int anoNascimento, anoIngresso, codigoFuncionaro, idadeMinima, anosTrabalhados;
Console.WriteLine("Informe o codigo do funcionario");
codigoFuncionaro = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("informe o ano de nascimento");
anoNascimento = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o ano de ingresso");
anoIngresso = Convert.ToInt32(Console.ReadLine());

idadeMinima = 2022 - anoNascimento;
anosTrabalhados = 2022 - anoIngresso;


if (anoNascimento >= 70 && anosTrabalhados >= 30)
{
    Console.WriteLine("O funcionario pode se aposentar");
}
else if (anoNascimento >= 65 && anosTrabalhados >=30)
{
    Console.WriteLine("O funcionario pode se aposentar");
}
else
{
    Console.WriteLine("O funcionario não atingiu os requesitos necessarios para se aposentar");
}
