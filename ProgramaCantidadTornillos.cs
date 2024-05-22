/******************************************************************************

Autor:     Nicolle Zapata Monsalve
Fecha:     2024-05-22
Descripcion: descuentos
*******************************************************************************/
using System;

class Program 
{
  static void Main(){
    
      int cantidadTornillos;
      int valorTornillos;
      
    Console.WriteLine("Digite cantidad de tornillos a comprar: ");
    cantidadTornillos = Int32.Parse(Console.ReadLine());
    valorTornillos = 300;
    
    if( cantidadTornillos >= 10 ){
    if( cantidadTornillos >= 5 ){
    if( cantidadTornillos >= 1){
        Console.WriteLine("cantidad de tornillos a pagar es: " + (valorTornillos * 0.50));
        Console.WriteLine("cantidad de tornillos a pagar es: " + (valorTornillos * 0.70));
        Console.WriteLine("cantidad de tornillos a pagar es: " + (valorTornillos * 0));
      }
     }
    }
  }
}
