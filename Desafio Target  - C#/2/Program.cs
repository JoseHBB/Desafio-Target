using System;
internal class Program
{
    private static void Main(string[] args)
    {
        string? stringToCheck; // declara a variavel string e permite que ela armazene um valor nulo
        int count = 0; // declara o contador
        Console.WriteLine("Insira uma string: ");
        stringToCheck = Console.ReadLine(); // armazena a string na variavel 

        if (stringToCheck == null){ // verifica se a string é nula e encerra caso seja
            Console.WriteLine("String inválida, por favor tente novamente!");
            return;
        } 

        foreach (char word in stringToCheck){ //checa cada char na string e verifica se é A, caso seja adiciona um ao contador
            if (word == 'a' | word == 'A'){
                count++;
            }
        }

        if(count == 0){ // se o contador for zero informa ao usuário que a palavra não possui a letra A e caso possua informa a ele quantas vezes ela aparece
            Console.WriteLine("Essa string não possui a letra A minúscula ou maiúscula.");
        } else {
            Console.WriteLine("Essa string possuia a letra A e ela apareçe: " + count + " vez(es).");
        }
    }
}