using KISSPrinciple;
using System.Text.RegularExpressions;

Console.WriteLine("Bienvenido");

decimal[]? prices = Prices();
decimal? tipPercentage = Tip(), total = 0;

RestaurantBill rest = new();

total = rest.CalculateTotal(prices, (decimal)tipPercentage);

Console.WriteLine($"Total a pagar (con propina del {Math.Round((decimal)tipPercentage * 100, 0)}%): {total}");

decimal[] Prices()
{
    string stringPrices = string.Empty;
    while (true)
    {
        Console.Write("Ingrese los precios de los platos (separados por coma): ");
        stringPrices = Console.ReadLine()!;

        if (Regex.IsMatch(stringPrices, "^\\d+(?:,\\d+)*$"))
        {
            break;
        }

        Console.WriteLine("Solo se aceptan numeros y separados por coma (500, 532, etc...)");
        Thread.Sleep(2000);
        Console.Clear();
    }

    return stringPrices.Split(',')
    .Where(p => !string.IsNullOrWhiteSpace(p))
    .Select(decimal.Parse)
    .ToArray();
}

decimal Tip()
{
    decimal tip = 0;
    string response = string.Empty;
    Console.Write("\n¿Desea agregar una propina personalizada? (s/n): ");
    response = Console.ReadLine()!.ToLower().Trim();

    if (Regex.IsMatch(response, "^[^sn]*[sn][^sn]*$"))
        if (response.Contains("s"))
        {
            Console.WriteLine("Ingrese su propina (solo valores del 1 al 100): ");
            while (true)
            {
                if (decimal.TryParse(Console.ReadLine()!.Trim(), out tip))
                    if (tip <= 100 || tip > 0) break;

                Console.Clear();
                Console.WriteLine("Solo números entre 1 al 100, intentelo nuevamente: ");
            }
        }
        else tip = 10;

    return Math.Round(tip / 100, 2);
}
