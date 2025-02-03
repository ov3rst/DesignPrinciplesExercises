using SOLIDPrinciples;
using System.Text.RegularExpressions;

Console.WriteLine("Bienvenido");

int response = 0;
string message = null!;
Console.WriteLine("Seleccione una opción:\n\n1.Email\n\n2.SMS");

if (int.TryParse(Console.ReadLine(), out response))
{
    NotificationService notificationService = new NotificationService();
    Logs logs = new Logs();
    switch (response)
    {
        case 1:
            message = EnterData("Ingrese el mensaje");
            notificationService.SendEmail("olivertejeda65@gmail.com", message);
            logs.LogNotification(message);
            break;
        case 2:
            message = EnterData("Ingrese el mensaje");
            notificationService.SendSMS("8095654454", message);
            logs.LogNotification(message);
            break;
        default:
            Console.WriteLine("Opción invalida, finalizando el programa...");
            return;
    }
}

string EnterData(string msj)
{
    string message;
    while (true)
    {
        Console.Write($"{msj}: ");
        message = Console.ReadLine()!;
        if (Regex.IsMatch(message, "[a-zA-ZÁÉÍÓÚáéíóú]")) break;

        Console.Clear();
        Console.WriteLine("Valor incorrecto, intentelo nuevamente");
    }

    return message;
}