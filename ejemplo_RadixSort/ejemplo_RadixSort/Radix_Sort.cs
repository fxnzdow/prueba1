using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_RadixSort
{
    internal class Radix_Sort
    {
        public class RadixSort // Define la clase RadixSort
        {
            // Método privado que obtiene el valor máximo del arreglo
            private int GetMax(int[] array)
            {
                int max = array[0]; // Inicializa 'max' con el primer elemento del arreglo

                for (int i = 1; i < array.Length; i++) // Recorre el arreglo desde el segundo elemento
                    if (array[i] > max) // Si el elemento actual es mayor que 'max'
                        max = array[i]; // Actualiza 'max' con el nuevo valor máximo

                return max; // Devuelve el valor máximo encontrado
            }

            // Método privado que realiza Counting Sort basado en un dígito específico (exp)
            private void CountingSort(int[] array, int exp)
            {
                int n = array.Length; // Obtiene la longitud del arreglo
                int[] output = new int[n]; // Arreglo temporal para almacenar el resultado ordenado
                int[] count = new int[10]; // Arreglo para contar ocurrencias de dígitos (0 a 9)

                // Cuenta cuántas veces aparece cada dígito en la posición actual (exp)
                for (int i = 0; i < n; i++)
                    count[(array[i] / exp) % 10]++; // Extrae el dígito correspondiente y lo cuenta

                // Acumula las posiciones para saber dónde colocar cada número
                for (int i = 1; i < 10; i++)
                    count[i] += count[i - 1]; // Suma acumulativa de ocurrencias

                // Construye el arreglo de salida recorriendo el original de derecha a izquierda
                for (int i = n - 1; i >= 0; i--)
                {
                    int idx = (array[i] / exp) % 10; // Extrae el dígito actual
                    output[count[idx] - 1] = array[i]; // Coloca el número en su posición ordenada
                    count[idx]--; // Decrementa el contador para ese dígito
                }

                // Copia el arreglo ordenado de vuelta al arreglo original
                for (int i = 0; i < n; i++)
                    array[i] = output[i]; // Sustituye el valor original por el ordenado
            }

            // Método público que ejecuta el algoritmo Radix Sort
            public void Sort(int[] array)
            {
                int max = GetMax(array); // Obtiene el valor máximo para saber cuántos dígitos tiene

                // Aplica Counting Sort para cada dígito (unidades, decenas, centenas, etc.)
                for (int exp = 1; max / exp > 0; exp *= 10)
                    CountingSort(array, exp); // Ordena por el dígito correspondiente
            }
        }
    }
}
