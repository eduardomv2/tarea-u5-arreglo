// Declaración del arreglo de enteros
int[] numeros = new int[5];

// Inicialización de los elementos del arreglo
numeros[0] = 10;
numeros[1] = 20;
numeros[2] = 30;
numeros[3] = 40;
numeros[4] = 50;

// Acceso a los elementos del arreglo mediante índices
Console.WriteLine("El primer número es: " + numeros[0]);
Console.WriteLine("El segundo número es: " + numeros[1]);
Console.WriteLine("El tercer número es: " + numeros[2]);
Console.WriteLine("El cuarto número es: " + numeros[3]);
Console.WriteLine("El quinto número es: " + numeros[4]);

// Uso de la propiedad Length para obtener la longitud del arreglo
Console.WriteLine("La longitud del arreglo es: " + numeros.Length);

// Recorrido del arreglo utilizando un ciclo for
Console.WriteLine("Los números del arreglo son:");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

