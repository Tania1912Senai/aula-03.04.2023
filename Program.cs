

//Atividade em sala de aula 03.04.2023
//Calculadora

//Entrada
Console.WriteLine("Programando uma Calculadora");
Console.WriteLine(@$"informe a operacao matematica desejada
'+' para adicao,
'*' para multiplicacao,
'-' para subtracao,
'/' para divisao");

char operacaomatematica = char.Parse(Console.ReadLine());

//Temos que ter uma variavel numero para chegar ao resultado da operaçao

float resultado = 0;

Console.WriteLine($"digite o primeiro numero:");

float numero1 = float.Parse(Console.ReadLine());

Console.WriteLine($"digite o segundo numero:");

float numero2 = float.Parse(Console.ReadLine());

//Processamento

switch (operacaomatematica)

{
    case '+':
        resultado = (numero1 + numero2);
        Console.WriteLine($"o resultado da soma é {resultado}");
        break;
    case '-':
        resultado = (numero1 - numero2);
        Console.WriteLine($"o resultado da subtracao é {resultado}");
        break;
    case '*':
        resultado = (numero1 * numero2);
        Console.WriteLine($"o resultado da multiplicacao é {resultado}");
        break;
    case '/':
        resultado = (numero1 / numero2);
        Console.WriteLine($"o resultado da divisão é {resultado}");
        break;
    default:
        Console.WriteLine($"a operacaomatematica informada nao e suportada pela nossa calculadora");
        break;
}
