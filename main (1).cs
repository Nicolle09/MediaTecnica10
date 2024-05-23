/******************************************************************************
Autor: Nicolle zapata monsalve
Fecha: 2024-05-23
Descipcion:
        un docente requiere de un sistema de notas
        donde recibe 4 calificaciones generando un promedio
        y luego determinando si gana o pierde.
        Si su promedio es menor a 3 pierde 
        Si es mayor gana
        Si tiene un promedio mayor a 4.5 emitir mensaje:
        "Felicidades, te has ganado una beca"

*******************************************************************************/
using System;
class ProgramaDescuentos{
  static void Main() {
      
      double nota1;
      double nota2;
      double nota3;
      double nota4;
      
      Console.Write("introduzca valor nota 1:");
      nota1 = Convert.ToDouble(Console.ReadLine());
      
      Console.Write("introduzca valor nota 2:");
      nota2 = Convert.ToDouble(Console.ReadLine());
      
      Console.Write("introduzca valor nota 3:");
      nota3 = Convert.ToDouble(Console.ReadLine());
      
      Console.Write("introduzca valor nota 4:");
      nota4 = Convert.ToDouble(Console.ReadLine());
      
      double promedio = (nota1 + nota2 + nota3 + nota4)/ 4;
      
      if(promedio<=3){
      Console.WriteLine("perdio");    
      }
      
      if(promedio>=3){
      Console.WriteLine("ganaste");
      }
      
      if(promedio>=4.5){
      Console.WriteLine("Felicidades, ganaste una beca");
      }
  }
}