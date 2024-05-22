/******************************************************************************
Autor:       Nicolle Zapata Monsalve
Fecha:        2024-05-22
Descrpcion:      programa de decisiones para
                determinar del sexo de un usuario
*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    // variable
    bool sexoMasculino;
    // capturar infirmacion del usurio
    Console.Write("Digite true si es hombre:");
    sexoMasculino = Convert.ToBoolean(Console.ReadLine());
    // validación
    if (sexoMasculino == true)
    {
        Console.WriteLine("Felicidades, es hombre");
    }
    else{
        Console.WriteLine("Felicidades, es mujer");
    }    
    Console.WriteLine("Finalizada la ajecucion");    
  }
}
