using DRYPrinciple;

Console.WriteLine("Bienvenido");

int response = 0, salaryBase = 0, hourlyRate = 0, hoursWorked = 0;
Console.WriteLine("Seleccione el tipo de empleado(1: Tiempo completo, 2: Medio tiempo): ");

if (int.TryParse(Console.ReadLine(), out response))
{
    Payroll payroll = new Payroll();
    if (response == 1)
    {
        while (true)
        {
            Console.WriteLine("Ingrese el salario base: ");
            if (int.TryParse(Console.ReadLine(), out salaryBase) && salaryBase > 0) break;

            Console.Clear();
            Console.WriteLine("Valor invalido, intentelo nuevamente: ");
        }

        payroll.CalculateSalaryForFullTime(salaryBase);
    }
    else if (response == 2)
    {
        while (true)
        {
            Console.WriteLine("Ingrese el salario por hora: ");
            if (int.TryParse(Console.ReadLine(), out hourlyRate) && hourlyRate > 0)
            {
                Console.WriteLine("Ingrese las horas trabajadas: ");

                if (!int.TryParse(Console.ReadLine(), out hoursWorked) && hoursWorked > 0) break;

            }

            Console.Clear();
            Console.WriteLine("Valor invalido, intentelo nuevamente: ");
        }

        payroll.CalculateSalaryForFullTime(salary);
    }
}

