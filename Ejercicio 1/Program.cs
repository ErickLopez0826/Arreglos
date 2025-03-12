using System;

class Sumatoria{
    int[] Numeros = new int[10]; //Declaracion del arreglo
    public void GuardarValores(int[] Valores){
        Numeros = Valores; //Metodo para guardar los valores que ingresara el usuario en otro arreglo
    }

    //Metodo para Calcular la suma y el promedio de los numeros ingresados
    public double CalcularPromedio(){ 
        double Suma = 0;
        foreach(int Num in Numeros){ //Foreach (variable temporal que iniciara el ciclo y "Numeros" que representa el numero de veces que se reperita en vase al numero de datos)
            Suma += Num;
        }
        Console.WriteLine($"La suma de los numeros es: {Suma}");
        return Suma/Numeros.Length;
    }
}
class Principal {
    public static void Main(){
        int [] Numeros = new int[10]; //Declaracion del arreglo en la clase principal
        Sumatoria Ejercicio = new Sumatoria(); //Instancia de la clase Sumatoria
        for(int i = 0; i < 10; i++){
            try{ //Trycatch para evitar que el usuario ingrese valores no deseados. En esta primera situacion sigue las instrucciones de manera que haya ingresado valores correctos
            Console.WriteLine($"Ingrese el numero {i + 1}");
            Numeros[i] = int.Parse(Console.ReadLine());
            }
            catch{ //En esta segunda situacion el usuario ingreso valores invalidos
                Console.WriteLine("Valor invalido, Ingresa un valor valido");
                while(!int.TryParse(Console.ReadLine(), out Numeros[1])){ //Se hace un ciclo while donde en la condicional se toma en cuenta de si el numero que ingreso es intero o no(Desigual)
                    Console.WriteLine("Ingresa un numero natural: ");
                }
            }
        }
        Ejercicio.GuardarValores(Numeros);
        Console.WriteLine($"El promedio de los numeros ingresados es: {Ejercicio.CalcularPromedio()}");
    } 
}