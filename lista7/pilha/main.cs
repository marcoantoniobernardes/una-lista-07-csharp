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
    // pilha
    Stack<int> pilha = new Stack<int>();
    
    // adicionando elementos
    pilha.Push(10);
    pilha.Push(20);
    
    // mostra elemneto topo da pilha
    Console.WriteLine("Elemento do topo: " + pilha.Peek());

    // removendo o valor, o valor removidado e o do topo
    pilha.Pop();

    Console.WriteLine("Elemento do topo após remoção: " + pilha.Peek());
    }
}