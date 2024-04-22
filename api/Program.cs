string continuar ="";
string categoria = "";
string FaixaEtaria= "";//declarando strings
do
{
    Console.WriteLine("Digite seu nome:");//pegando dados do usuario
    string nome = Console.ReadLine();
    Console.WriteLine("Digite sua idade:");
    int idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite sua altura:");
    double altura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite seu peso:");
    double peso = Convert.ToDouble(Console.ReadLine());

    double IMC = peso / (altura * altura);//calculando o IMC do usuario

    if (IMC < 18.5)//definindo a categoria de peso da pessoa
    {
        categoria = "abaixo do peso";
    }
    else if (IMC >= 18.5 && IMC < 25)
    {
        categoria = "normal";
    }
    else if (IMC >= 25 && IMC < 30)
    {
        categoria = "sobrepeso";
    }
    else if (IMC >= 30)
    {
        categoria = "obesidade";
    }

    if( idade< 12)// definindo a faixa etaria da pessoa
    {
        FaixaEtaria = "Criança";
    }
    else if (idade >= 12 && idade < 18)
    {
        FaixaEtaria = "adolecente";
    }
    else if (idade >= 18 && idade < 60)
    {
        FaixaEtaria = "adulto";
    }else if (idade >= 60)
    {
        FaixaEtaria = "idoso";
    }
    Console.WriteLine($"{nome} tem {idade} anos, e é {FaixaEtaria}.");//criando o relatorio do usuario
    Console.WriteLine("Tem o IMC igual a " + IMC + ", e sua categoria é " + categoria);

    Console.WriteLine("Você gostaria de calcular o IMC de outra pessoa? 'S/N'");//perguntando se quer calcular um IMC diferente
    continuar = Console.ReadLine();
}
while(continuar == "S" || continuar =="s");
