// See https://aka.ms/new-console-template for more information
double res = 0;
void operaAB(double r, double s, char operador) 
{ 

    switch (operador)
    {
        case '+':
            res = r + s;
            break;
        case '-':
            res = r - s;
            break;
        case '*':
            res = r * s;
            break;
        case '/':
            res = r / s;
            break;

    }

    Console.WriteLine("El resultado es!!!!! " + res);
}

char operacion;
double A;
double B;
char[] operadores = { '+', '-', '*', '/' };

Console.WriteLine("Que operacion deseas?");
operacion = Console.ReadLine().ToCharArray()[0];

if (operadores.Contains(operacion)) {
    Console.WriteLine("Que numeros vas a operar?");
    A = Convert.ToDouble(Console.ReadLine());
    B = Convert.ToDouble(Console.ReadLine());

    operaAB(A, B, operacion);
} else {
    Console.WriteLine("Eso no es ningun operador");
}





