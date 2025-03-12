using System;

class Ordenamiento_De_Numeros{
    public void Orden_De_Numeros(){
        Console.WriteLine("Cuantos numeros desea ingresar?");
        int Cantidad_De_Numeros = int.Parse(Console.ReadLine());
        int[] Numeros = new int[Cantidad_De_Numeros];

        Console.WriteLine("Ingresa los numeros");
        for (int i = 0 ; i < Cantidad_De_Numeros ; i++ ){
            Console.WriteLine($"Numero {i + 1}: ");
            Numeros[i] = int.Parse(Console.ReadLine()); 
        }

        int Longitud_De_Arreglo = Numeros.Length;
        bool Intercambio_Realizado;
        for (int i = 0 ; i < Longitud_De_Arreglo - 1 ; i++){ //Se utiliza una condicional donde se le resta -1 a la segunda variable para que no busque un arreglo inexistente (Si tienes 5 posiciones de arreglos que es del 0 al 4. No buscara la posicion 5)
            Intercambio_Realizado = false;
            for (int j = 0 ; j < Longitud_De_Arreglo -i -1 ; j++){ //Se hace lo mismo pero restandole el valor de i para que este disminuya a la par.
                if(Numeros[j] > Numeros[j + 1]){ //Aqui utilizamos "Numeros" como condicional ya que necesitamos el arreglo y no la longitud de este
                    int Temporal = Numeros[j]; //El valor del primer arreglo se pasa a la variable temporal
                    Numeros[j] = Numeros[j + 1];//El valor del segundo arreglo cambia al arreglo numero 1
                    Numeros[j + 1] = Temporal;//El valor del segundo arreglo para a la variable temporal
                    Intercambio_Realizado = true;
                }
            } // Utilizando 2 for estariamos comparando la posicion x con la siguiente posicion
            if (!Intercambio_Realizado){
                break;
            }
        }
        Console.WriteLine("Orden de los numeros de menor a mayor.");
        for (int i = 0 ; i < Longitud_De_Arreglo ; i++ ){
            Console.WriteLine(Numeros[i]);
        }
    }
}
class Ejercicio_3{
    static void Main(){
        Ordenamiento_De_Numeros Lista_De_Numeros = new Ordenamiento_De_Numeros();
        Lista_De_Numeros.Orden_De_Numeros();
    }
}

/*
Implementa el metodo de ordenamiento burbuja para ordenar un arreglo de numeros
ingresados por el usuario de menor a mayor
*/
