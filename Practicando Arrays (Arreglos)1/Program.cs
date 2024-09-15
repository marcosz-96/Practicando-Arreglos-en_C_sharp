using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practicando_Arrays__Arreglos_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //INTRODUCCIÓN A ARRAYS!!!

            //Tipos de Arrays: Unidimensional, es un array de una sola domensión

            /*Declaramos el arreglo sin inicializarlo
            int[] array = new int[4];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;

            Console.WriteLine($"El elemento 4 del array es: {array[3]}");

            /*Declaramos el arreglo y lo inicializamos, con NEW STRING
            string[] diasDeSemana = new string[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábados", "Domingos" };

            Console.WriteLine($"EL día número 5 de la semana es: {diasDeSemana[4]}");

            /*Declaramos el arreglo y lo inicializamos, SIN el NEW STRING, no es del todo necesario en estos casos
            string[] diaDeSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábados", "Domingos" };

            Console.WriteLine($"EL día número 3 de la semana es: {diaDeSemana[2]}");

            /*También podemos declarar el array y luego crearlo, en este caso SÍ vamos a necesitar NEW
            int[] array3;
            array3 = new int[] { 1, 3, 4, 5, 56, 90 };


            //Tipos de Arrays: Multidimensional o Bidimensional, es un array de dos dimensiones

            /*Se declara, crea e inicializa de la siguiente forma:*/
            /*Declaramos el array indicando en la parte de NEW STRING que va a ser una matriz de 3 filas y 2 columnas y contendrá 6 elementos*/
            /*Se crea el arreglo y se le agrega un ", (coma)" dependiendo de cuantas dimensiones va a ser la matriz

            string[,] array2D = new string[3, 2] { { "uno", "dos" }, { "tres", "cuatro" }, { "cinco", "seis" } };

            Console.WriteLine(array2D.Length);


            //Tipos de Arrays: Tridimensional, es un array de tres dimesiones

            /*Se declara, crea e inicializa de la siguiente forma:*/
            /*En el siguiente caso, declaramos y creamos una matriz de 2 filas y 3 columnas en forma tridimensional

            int[,,] array3D = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };
            /*Pedimos que nos muestre un dato según la coordenada que le indiquemos, en este caso es:
            Console.WriteLine(array3D[1, 1, 2]);

            /*Recorremos los datos que hay en el arreglo de la siguiente manera
            foreach (int i in array3D)
            {
                Console.Write("{0} ", i);
            }


            //Tipo de array: Array Escalonada (JaggedArray): Es una matriz que contiene matrices dentro, más conocido con el nombre de matriz anidada 

            /*Se declara, crea e inicializa de la siguiente forma:*/
            /*Declaramos el arreglo e indicamos que va a contener 3 elementos, es decir, 3 matrices más

            int[][] arrayEscalonada = new int[3][];
            arrayEscalonada[0] = new int[5];
            arrayEscalonada[1] = new int[4];
            arrayEscalonada[2] = new int[2];

            /*También se puede hacer de la siguiente forma, inicializada

            int[][] arrayEscalon = new int[3][];
            arrayEscalon[0] = new int[] { 1, 3, 4, 2, 6 };
            arrayEscalon[1] = new int[] { 0, 9, 8, 34 };
            arrayEscalon[2] = new int[] { 2, 8 };

            /*Otra forma de hacerlo es de la siguiente manera, inicializada

            int[][] arrayEscal =
            {
                new int[] { 1, 3, 4, 2, 6 },
                new int[] { 0, 9, 8, 34 },
                new int[] { 2, 8 }
            };
                
            /*La forma de recorrer el arreglo es de la siguiente manera:*/
            /*Con el primer FOR, recorremos cada uno de los arreglos
            for (int i = 0; i < arrayEscal.Length; i++)
            {
                Console.Write("\nElemento ({0}): ", i);
                /*Con el segundo FOR, recorremos los elementos que hay dentro de los arreglos
                for (int j = 0; j < arrayEscal[i].Length; j++)
                {
                    Console.Write("{0}{1}", arrayEscal[i][j], j == (arrayEscal[i].Length - 1) ? "" : " ");
                }

                Console.WriteLine();
            }


            //Tipos de Array: Mezcla entre arreglos

            /*En el siguiente ejemplo mezclamos arreglos unidimensionales con arreglos escalonados y bidimensionales

            int[][,] arrayEscalUnid = new int[3][,]
            {
                new int [,] { { 1, 3 }, { 2, 3 } },
                new int [,] { { 6, 7 }, {4, 8 },{5, 9 } },
                new int [,] { { 701, 800 },{ 28, 59 }, { 93, 10 } },
            };



            //Ejercicio 1: Carga de Números
            /* Descripción; Crear un arreglo para 5 numeros enteros
               Cargar el arreglo con valores ingresados por el usuario
               Mostrar todos los números del arreglo
            */
            int[] numEntero;
            numEntero = new int[5];
            numEntero[0] = 1;  
            numEntero[1] = 2;   
            numEntero[2] = 3;
            numEntero[3] = 4;
            numEntero[4] = 5;

            Console.WriteLine($"Los valores dentro del arreglo son:"); /*{numEntero[0]}, {numEntero[1]}, {numEntero[2]}, {numEntero[3]}, {numEntero[4]}");*/
            
            for (int n = 0; n < numEntero.Length; n++)
            {
                Console.WriteLine( numEntero[n]);
            }
            

            //Ejercicio 2: Carga de Edades Dinámicas
            /* Descripcion; Pide al usuario que indique cuantas edades cargará
               Crea un arreglo para almacenarlas que se ajuste a las dimensiones
               Muestra las edades cargadas
            */
            
            int xtotal = 0;
            int ingresaEdad;
            int[] xedades;
           
            Console.Write("\nIngrese el número de edades que desea cargar: ");
            ingresaEdad = int.Parse(Console.ReadLine());

            xedades = new int[ingresaEdad];

            for (int i = 0; i < xedades.Length; i++)
            {
                xedades[i] = int.Parse((Console.ReadLine()));
            }

            for (int i = 0; i < xedades.Length; i++)
            {
                Console.WriteLine($"Las edades ingresadas en indice {i} es: {xedades[i]}");
            }
            

            //Ejercicio 3: Calcular sumatoria
            /*Descripción; A la solución creada en el ejercicio 2, mostrar al final la sumatorio total de las edades ingresadas
            */
            for (int i = 0; i < xedades.Length; i++)
            {
                xtotal += xedades[i];
            }

            Console.WriteLine($"\nEl resultado de la suma de las edades es: {xtotal}\n");
            

            //Ejercicio 4: Arreglo en paralelo 
            /*Descripcion; Crear un arreglo para almacenar 5 estudiantes y otro para sus edades
              cargar los arreglos con nombres y edades
              Muestra en pantalla el nombre del estudiante y su edad, una por lina*/
            
            string[] estudiante;
            estudiante = new string[5];

            estudiante[0] = "Pedro";
            estudiante[1] = "Alejandro";
            estudiante[2] = "Marco";
            estudiante[3] = "Matías";
            estudiante[4] = "Nicolas";

            int[] edadEstud;
            edadEstud = new int[5];

            edadEstud[0] = 27;
            edadEstud[1] = 17;
            edadEstud[2] = 22;
            edadEstud[3] = 24;
            edadEstud[4] = 14;

            for (int e = 0; e < estudiante.Length; e++)
            {
                Console.WriteLine($"El nombre del alumno es {estudiante[e]} y su edad es de {edadEstud[e]}");
            }
            

            //NUEVOS EJERCICIOS CON ARREGLOS: PRACTICA!

            //Ejercicio 1.1: Cambio de Nombres
            /*Descripción; Crea un arreglo para 3 nombres. 
              Permite al usuario ingresar tres nombres directamente en las posiciones del arreglo (nombres[0], 
              nombres[1], nombres[2]). 
              Luego, cambia el nombre de la segunda posición (nombres[1]) por otro nombre ingresado por el usuario 
              muestra el arreglo resultante
             */
            
            string[] nombre;
            nombre = new string[3];
        
            string nuevoNombre = "";

            Console.WriteLine("\nIngrese el primer nombre: ");
            nombre[0] = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo nombre: ");
            nombre[1] = Console.ReadLine();

            Console.WriteLine("Ingrese el tercer nombre: ");
            nombre[2] = Console.ReadLine();

            Console.WriteLine($"Los nombres ingresados son: {nombre[0]}, {nombre[1]} y {nombre[2]}");
            Console.WriteLine("\nIngrese el nuevo nombre para el puesto 2: ");
            nuevoNombre = Console.ReadLine();

            nombre[1] = nuevoNombre;

            Console.WriteLine($"El nombre ingresado es: {nombre[1]}");
            Console.WriteLine($"\nLos nombres ingresados son: {nombre[0]}, {nombre[1]} y {nombre[2]}");
            


            //Ejercicio 1.2: Precios con modificación directa

            /*Descripción: Crea un arreglo de 4 precios. 
            Permite al usuario ingresar los precios directamente en las posiciones del arreglo (precios[0], precios[1], 
            etc.). 
            Luego, aumenta el segundo precio en un 15% y el último precio en un 20%. 
            Muestra los nuevos valores del arreglo.
            */
            double[] xprecio;
            xprecio = new double[4];

            Console.Write("Ingrese el precio N°1: ");
            xprecio[0] = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio N°2: ");
            xprecio[1] = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio N°3: ");
            xprecio[2] = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio N°4: ");
            xprecio[3] = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nEl precio N°2 es {xprecio[1]} y su valor incrementado un 15% es: {xprecio[1] * 15 / 100 + xprecio[1]}");
            Console.WriteLine($"El precio N°4 es {xprecio[3]} y su valor incrementado un 20% es: {xprecio[3] * 20 / 100 + xprecio[3]}");
            


            //Ejercicio 1.3: Reemplazo de edades

            /*Descripcón: Crea un arreglo de 5 edades. 
            Permite al usuario ingresar las edades directamente en las posiciones del arreglo (edades[0],… etc.). 
            Después de ingresar las edades, cambia la primera edad a 18 y la tercera edad a 21. 
            Muestra el arreglo resultante.
            */
            int[] edad;
            edad = new int[5];

            Console.Write("Ingrese la 1er edad: ");
            edad[0] = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la 2da edad: ");
            edad[1] = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la 3ra edad: ");
            edad[2] = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la 4ta edad: ");
            edad[3] = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la 5ta edad: ");
            edad[4] = int.Parse(Console.ReadLine());

            if (edad[0] != 18)
            {
                Console.WriteLine($"Se cambió la 1er edad que es: {edad[0]} a {edad[0] = 18}");
            }
            else
            {
                Console.WriteLine("No hubo cambios");
            }
            if (edad[2] != 21)
            {
                Console.WriteLine($"Se cambió la 3ra edad que es: {edad[2]} a {edad[2] = 21}");
            }
            else
            {
                Console.WriteLine("No hubo cambios");
            }

            Console.WriteLine($"Las edades son: {edad[0]}, {edad[1]}, {edad[2]}, {edad[3]}, {edad[4]}");
            

            //Ejercicio 1.4: Carga y Despliegue de Calificaciones

            /*Descripción: Crea un arreglo para almacenar 5 calificaciones de exámenes.
            Recorrer el arreglo (con for) y cargar las calificaciones.
            Muestrar el arreglo resultante por consola (recorrer con for)
            */
            int[] calificaciones = { 45, 56, 32, 90, 100 };
            
            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.WriteLine($"La calificación es: {calificaciones[i]}");
            }
            

            //Ejercicio 1.5: Carga y Despliegue de N calificaciones

            /*Descripción: Crea un arreglo para almacenar N calificaciones de exámenes.
            “Se solicita la N cantidad de calificaciones a cargar y luego se crea el arreglo con esa N dimensión.”
            Recorrer el arreglo y cargar las calificaciones.
            Muestrar el arreglo resultante por consola.
            */
            int ingresaNota;
            int[] xnotas;

            Console.Write("Ingrese la cantidad de notas que desea guardar: ");
            ingresaNota = int.Parse(Console.ReadLine());

            xnotas = new int[ingresaNota];

            for (int n = 0; n < xnotas.Length; n++)
            {
                xnotas[n] = int.Parse((Console.ReadLine()));
            }

            for (int x = 0; x < xnotas.Length; x++)
            {
                Console.WriteLine($"La nota ingresada es: {xnotas[x]}");
            }
            

            //Ejercicio 1.6: Lista de Precios con Descuento

            /*Descripción: Crea un arreglo para el precio de N productos. 
            Recorrer el arreglo y cargar los precios.
            Una vez finalizado, aplicar un descuento del 10% a cada precio.
            Muestra los precios finales.
            */

            int nPrecios;
            double[] precios;
            //Solicitamos que indique cuantos precios desea cargar
            Console.Write("Ingrese la cantidad de precios que desea guardar: ");
            nPrecios = int.Parse(Console.ReadLine());

            precios = new double[nPrecios];
            //Ingresa los precios
            for (int p = 0; p < precios.Length; p++)
            {
                Console.Write($"Ingrese el precio {p + 1}: ");
                precios[p] = double.Parse(Console.ReadLine());
            }
            //Se realiza el descuento según lo deseado
            for (int p = 0; p < precios.Length; p++)
            {
                Console.WriteLine($"El precio original es: {precios[p]}");
                double descuento = precios[p] * 0.10;
                double precioConDescuento = precios[p] - descuento;
                Console.WriteLine($"El precio con descuento es: {precioConDescuento}");
            }
            

            //Ejercicio 1.7: Multiplicación de Elementos Pares

            /*Descripción: Crea un arreglo de N números. 
            Recorrer el arreglo y cargar los numeros.
            Multiplica por 3 todos los números que estén en posiciones pares del arreglo (0, 2, 4, etc)
            Muestra el arreglo resultante. 
            */

            int cantNumX;
            
            Console.Write("Ingrese la cantidad de números que desea guardar: ");
            cantNumX = int.Parse(Console.ReadLine());

            int[] numerosX = new int[cantNumX];

            for (int c = 0; c < cantNumX; c++)
            {
                Console.Write($"Ingrese el número {c + 1}: ");
                numerosX[c] = int.Parse(Console.ReadLine());
            }
            
            for (int c = 0; c < cantNumX; c++)
            {
                if (c % 2 == 0) //Verificamos si la posición del arreglo es par
                {
                    numerosX[c] *= 3; //En caso de ser así, multiplica el número que se encuentra en esa posición
                }
            }

            Console.WriteLine("\nEl arreglo resultante es:\n");

            for (int c = 0; c < cantNumX; c++)
            {
                Console.WriteLine($"Posición {c}: {numerosX[c]}");
            }
            


            //Ejercicio 1.8: Reemplazo de valores Negativos 

            /*Descripción; Crea un arreglo para almacenar N números enteros. 
            Reemplaza cualquier número negativo en el arreglo con un cero.
            Muestra el arreglo resultante.
            */

            int canNum;

            Console.Write("Ingrese la cantidad de números que desea guardar: ");
            canNum = int.Parse(Console.ReadLine());

            int[] numNeg = new int[canNum];

            for (int l = 0; l < numNeg.Length; l++)
            {
                Console.Write($"Ingrese el número {l + 1}: ");
                numNeg[l] = int.Parse(Console.ReadLine());
            }

            for (int l = 0; l < numNeg.Length; l++)
            {
                if (numNeg[l] < 0) //Verificamos si el valor ingresado es negativo
                {
                    Console.Write($"El valor original es: {numNeg[l]}\n");
                    Console.WriteLine($"El número negativo fue reemplazado por: {numNeg[l] = 0}"); //En caso de ser así, lo reemplaza por cero
                }
            }
            //Mostramos el arreglo resultante
            Console.WriteLine("\nEl arreglo resultante es:");
            for (int l = 0; l < numNeg.Length; l++)
            {
                Console.WriteLine($"Posición {l}: {numNeg[l]}");
            }
            


            //Ejercicio 1.9: Notas y Estudiantes

            /*Descripción; Crea dos arreglos paralelos: uno para los nombres de los estudiantes (nombres) y otro para sus 
            notas (notas). 
            Permite al usuario ingresar los nombres de tres estudiantes y sus respectivas notas. 
            Luego, cambia la nota del segundo estudiante (notas[1]) a 10 (como si fuera una corrección). 
            Muestra los nombres y sus notas correspondientes.
            */ 

            int[] notas = new int[3];

            string[] nombres = new string[3];

            Console.Write("Ingrese el nombre del primer estudiante: ");
            nombres[0] = Console.ReadLine();
            Console.Write("Ingrese la nota del primer estudiante: ");
            notas[0] = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre del segundo estudiante: ");
            nombres[1] = Console.ReadLine();
            Console.Write("Ingrese la nota del segundo estudiante: ");
            notas[1] = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre del tercer estudiante: ");
            nombres[2] = Console.ReadLine();
            Console.Write("Ingrese la nota del tercer estudiante: ");
            notas[2] = int.Parse(Console.ReadLine());

            if (notas[1] != 10) //Verificamos si la nota es distinto del valor deseado
            {
                notas[1] = 10; //De ser así lo cambia al valor deseado
                Console.WriteLine($"\nLa nota del estudiante {nombres[1]} se corrigió a {notas[1]}");
            }
            for (int s = 0; s < nombres.Length; s++)
            {
                Console.WriteLine($"\nLas siguientes notas son: {nombres[s]} nota: {notas[s]}");
            }
            


            //Ejercicio 1.10: Precios y Descuentos

            /*Descripción; Crea dos arreglos paralelos: uno para los precios de productos (precios) y otro para los porcentajes de 
            descuento (descuentos). 
            Permite al usuario ingresar 4 precios y sus respectivos descuentos. 
            Luego, aplica el descuento al tercer precio (precios[2]) usando el valor en el arreglo de descuentos 
            (descuentos[2]) y muestra los precios con descuento.
            */

            double[] precio = new double[4];

            double[] descuentos = new double[4];

            Console.Write("Ingrese el precio n°1: ");
            precio[0] = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el descuento para el precio n°1: ");
            descuentos[0] = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio n°2: ");
            precio[1] = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el descuento para el precio n°2: ");
            descuentos[1] = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio n°3: ");
            precio[2] = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el descuento para el precio n°3: ");
            descuentos[2] = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio n°4: ");
            precio[3] = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el descuento para el precio n°4: ");
            descuentos[3] = int.Parse(Console.ReadLine());

            //Se realiza el descuento en el precio indicado
            double descuentoPrecio2 = precio[2] * descuentos[2] / 100;
            double precio2ConDescuento = precio[2] - descuentoPrecio2;

            for (int v = 0; v < precio.Length; v++)
            {
                Console.WriteLine($"Los precios son: {precio[v]}");
                
            }
            Console.WriteLine($"El valor con descuento en el precio n°3 es: {precio2ConDescuento}");
        }
    }
}
 