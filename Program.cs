Console.WriteLine("Calculadora de consola");
Console.WriteLine("Operaciones disponibles: + - * /");

Console.Write("Ingrese el primer numero: ");
double primerNumero = double.Parse(Console.ReadLine()!);

Console.Write("Ingrese el operador (+, -, *, /): ");
string operador = Console.ReadLine()!.Trim();

Console.Write("Ingrese el segundo numero: ");
double segundoNumero = double.Parse(Console.ReadLine()!);

double? resultado = operador switch
{
    "+" => primerNumero + segundoNumero,
    "-" => primerNumero - segundoNumero,
    "*" => primerNumero * segundoNumero,
    "/" => segundoNumero != 0 ? primerNumero / segundoNumero : null,
    _ => null
};

if (operador == "/" && segundoNumero == 0)
{
    Console.WriteLine("Error: no se puede dividir por cero.");
}
else if (resultado is null)
{
    Console.WriteLine($"Error: operador '{operador}' no es valido. Use +, -, * o /.");
}
else
{
    Console.WriteLine($"Resultado: {primerNumero} {operador} {segundoNumero} = {resultado}");
}
