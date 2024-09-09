using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int num; // armazena o número a ser recebido
        bool isOnFibonacci; // armazena se o número pertencera ou não a sequência Fibonacci
        Console.WriteLine("Insira um número inteiro para ser analisado: ");
        num = Convert.ToInt32(Console.ReadLine()); // coloca o número digitado pelo usuário
        isOnFibonacci = Fibonacci(num); // verdadeiro se o número pertence a sequência

        if(isOnFibonacci){ // informa o usuário se o número pertence ou não
            Console.WriteLine("O número: " + num + " pertence a sequência Fibonacci.");
        } else {
            Console.WriteLine("O número: " + num + " não pertence a sequência Fibonacci.");
        }
        
        // numToCheck número ques será feita a checagem
        // calcula Fibonacci até o número maior ou igual ao número no argumento e retorna verdadeiro caso ele faça parte de fibonnaci e falso caso contrário
        // também escreve a sequência no console
        bool Fibonacci(int numToCheck){ 
            int sum;
            int a = 0;
            int b = 1;

            Console.Write("Suquência Fibonacci: ");
            while(true){
                sum = a + b;
                a = b;
                b = sum;
                Console.Write(sum);
                if (numToCheck <= sum){
                    break;
                }
                Console.Write(", ");
            }
            Console.WriteLine();
            if (sum == numToCheck){
                return true;
            }
            return false;
        }
    }
}