/* Escribe una aplicación que reciba del usuario el radio de un círculo como un entero, y que imprima
el diámetro de la circunferencia y el área del círculo mediante el uso del valor de punto flotante
3.14159 para PI. También puede utilizar la constante predefinida Math.PI para el valor. Esta
constante es más precisa que el valor 3.14159. La clase Math se define en el namespace System. Las
clases en este paquete se importan de manera automática, por lo que no necesita importar la clase
Math mediante la instrucción using para usarla. Use las siguientes fórmulas (r es el radio):
diámetro = 2 r
circunferencia = 2 * PI * r
área = PI * r
2 */

public class HelloWorld
{
    public static void diametroYarea(int r)
    {
        int diametro = 2 * r;
        double circunferencia = 2 * Math.PI * r;
        double area = Math.PI * Math.Pow(r, 2);
        Console.WriteLine("Diametro: " + diametro);
        Console.WriteLine("circunferencia: " + circunferencia);
        Console.WriteLine("area: " + area);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("INGRESE UN ENTERO PARA CALCULAR DIAMETRO Y AREA");
        int valor = Convert.ToInt32(Console.ReadLine());
        diametroYarea(valor);
    }
}