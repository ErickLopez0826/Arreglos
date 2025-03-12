using System;

class ArregloInverso{
    public void Ejecutar(){
        const int cantidad = 5;
        int[] numeros = new int[cantidad];
        Console.WriteLine("Por favor, ingresa 5 números enteros:");
        for (int i = 0; i < cantidad; i++){
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nArreglo original:");
        for (int i = 0; i < cantidad; i++){
            Console.Write(numeros[i] + " ");
        }
        Console.WriteLine("\nArreglo invertido:");
        for (int i = cantidad - 1; i >= 0; i--){
            Console.Write(numeros[i] + " ");
        }
        Console.WriteLine();
    }
}
class Ejercicio_4{
    static void Main(){
        ArregloInverso ejercicio = new ArregloInverso();
        ejercicio.Ejecutar();
    }
}

/*
    Pide al usuario 5 numeros enteros y almacenalos en un arreglo.
    Luego muestra el arreglo original y su version invertida 
*/