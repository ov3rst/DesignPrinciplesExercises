using System.Text.RegularExpressions;
using YAGNIPrinciple;

Console.WriteLine("Bienvenido");

int response = 0;
Console.WriteLine("Seleccione una opción:\n\n1.Agregar producto\n\n2.Eliminar producto");

if (int.TryParse(Console.ReadLine(), out response))
{
    ProductService productService = new ProductService();
    switch (response)
    {
        case 1:
            string name = EnterData<string>("Ingrese el nombre del producto");
            decimal price = EnterData<decimal>("Ingrese el precio del producto");
            productService.AddProduct(name, price);
            break;
        case 2:
            int productId = EnterData<int>("Ingrese el id del producto");
            productService.DeleteProduct(productId);
            break;
        default:
            Console.WriteLine("Opción invalida, finalizando el programa...");
            return;
    }
}

dynamic EnterData<TType>(string msj)
{
    dynamic? value = null;
    while (true)
    {
        Console.Write($"{msj}: ");
        if (typeof(TType) == typeof(string))
        {
            value = Console.ReadLine()!;
            if (Regex.IsMatch((string)value!, "[a-zA-ZÁÉÍÓÚáéíóú]")) break;
        }

        if (typeof(TType) == typeof(decimal))
        {
            if (decimal.TryParse(Console.ReadLine(), out decimal result))
            {
                value = result;
                break;
            }
        }

        if (typeof(TType) == typeof(int))
        {
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                value = result;
                break;
            }
        }

        Console.Clear();
        Console.WriteLine("Valor incorrecto, intentelo nuevamente");
    }

    return value;
}