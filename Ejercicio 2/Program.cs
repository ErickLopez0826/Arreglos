using System;

class Arreglos_Nombres{
    String[] Nombres = new string[5];
    public void Nombres_En_Arreglos(){
        for (int i = 0; i < 5; i++){
                Console.WriteLine($"Ingresa el nombre numero {i + 1}");
                Nombres[i] = Console.ReadLine();
        }
    }
    public void Arreglo_Y_Posicion(){
        int Posicino_Encontrada = -1;
        Console.WriteLine("Ingresa el nombre que desee buscar");
        string Nombre_Encontrado = Console.ReadLine();
        for (int i = 0; i < 5; i++){
            if (string.Equals(Nombres[i], Nombre_Encontrado, StringComparison.OrdinalIgnoreCase)){
                Posicino_Encontrada = i;
                break;
            }
        }
        Console.WriteLine($"El nombre que buscaba se encontro en la posicion {Posicino_Encontrada}");
    }
}

class Ejercicio_2{
    static void Main(){
        String[] Nombres = new String[5];
        Arreglos_Nombres Nuevo_Nombre = new Arreglos_Nombres();
        Nuevo_Nombre.Nombres_En_Arreglos();
        Nuevo_Nombre.Arreglo_Y_Posicion();
    }
}

//Solicita al usuario llenar un arreglo de 5 nombres y luego pedirle un  nombre a buscar.
//El programa debe indicar si el nombre esta en el arreglo y en que posicion se encuentra