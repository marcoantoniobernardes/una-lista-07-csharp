/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.Collections.Generic;

class HelloWorld {
  static void Main() {
    // Criando uma lista de inteiros
    List<string> Lista = new List<string>();

    // Adicionando elementos à lista
    Lista.Add("arroz");
    Lista.Add("feijão");
    Lista.Add("açúcar");

    // Acessando elementos na lista por índice
    Console.WriteLine("Elemento na posição 0: " + Lista[0]);  // Saída: 10

    // Iterando pela lista
    Console.WriteLine("Elementos na lista:");
    foreach (var elemento in Lista)
    {
        Console.WriteLine(elemento);
    }

    // Removendo um elemento da lista
    Lista.Remove("feijao");

    // Verificando se a lista contém um elemento específico
    bool contemElemento = Lista.Contains("arroz");  // Retorna true

    // Obtendo o índice de um elemento na lista
    int indice = Lista.IndexOf("arroz");  // Retorna o índice 0

    // Removendo um elemento por índice
    Lista.RemoveAt(indice);

    // Limpando a lista (removendo todos os elementos)
    Lista.Clear();
    }
}