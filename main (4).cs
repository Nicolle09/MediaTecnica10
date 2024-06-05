/******************************************************************************

Autor: Nicolle Zapata Monsalve
Fecha: 2024-06-05
Descripción:
    Las manadas de la Roca del Rey están compitiendo 
    por el control de las Tierras del Reino. 
    Pide al usuario la fuerza de al menos 5 
    clanes diferentes y usa estructuras "si" 
    para determinar clasificación de fuerza.
    
*******************************************************************************/
using System;
class HelloWorld {
   static void Main() {
    // variables
    int fuerza  = 0;
    
    // estructura loop
    for (int i = 0; i <= 4; i++) 
    {
        Console.WriteLine("ingrese la fuerza de su clan del 1 al 5 , luego presionar enter");
        fuerza = Int32.Parse(Console.ReadLine());
    
        // solicitud de fuerza
        
        if (fuerza == 5)
        {
            Console.WriteLine("es del clan de los elefantes");
        }
        
        if (fuerza == 4)
        {
        
            Console.WriteLine("es del clan de los leones");
        } 
        if (fuerza == 1)
        {
        
            Console.WriteLine("es del clan de las hienas");
        }    
        if (fuerza == 3)
        {
            Console.WriteLine("es del clan de los hipopotamos");
        }    
        if (fuerza == 2)
        {
            Console.WriteLine("es del clan de los bufalos");
        }
        
        }

}
}