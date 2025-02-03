using DRYPrinciple;

Console.WriteLine("Bienvenido");

int response = 0;
decimal salary = 0, salaryBase = 0, hourlyRate = 0, hoursWorked = 0;
Console.WriteLine("Seleccione el tipo de empleado(1: Tiempo completo, 2: Medio tiempo): ");

if (int.TryParse(Console.ReadLine(), out response))
{
    Payroll payroll = new Payroll();

    switch (response)
    {
        case 1:
            salaryBase = EnterData("Ingrese el salario base");
            salary = payroll.CalculateSalaryForFullTime(salaryBase);
            break;
        case 2:
            hourlyRate = EnterData("Ingrese el salario por hora");
            hoursWorked = EnterData("Ingrese las horas trabajadas");
            salary = payroll.CalculateSalaryForPartTime(hourlyRate, hoursWorked);
            break;
        default:
            Console.WriteLine("Opción invalida, finalizando el programa...");
            return;
    }

    Console.WriteLine($"Salario neto despues de impuestos y bono: {salary}");
}

decimal EnterData(string msj)
{
    decimal data = 0;
    while (true)
    {
        Console.Write($"{msj}: ");
        if (decimal.TryParse(Console.ReadLine(), out data)) break;

        Console.Clear();
        Console.WriteLine("Valor incorrecto, intentelo nuevamente");
    }

    return data;
}