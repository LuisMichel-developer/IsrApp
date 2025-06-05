//Introduce tus variables y constantes

using System;

double salarioAnual = 0, // Salario anual
    isr, // Impuesto Sobre la Renta (ISR)
   salarioNetoMensual,
   salarioNetoAnual,
   salarioNetoSemanal,
   salarioNetoDiario,
   salarioMensual,
   salarioSemanal,
   salarioDiario;

// Pide tu salario mensual para continuar con el calculo de tu salario anual, mensual, semanal y diario

Console.Write("Ingrese el salario mensual:"  );
salarioMensual = Convert.ToInt32(Console.ReadLine());

// Aqui muestras los salarios brutos antes de impuestos

Console.Write($"Su salario antes de impuestos es:" );

    
if (salarioMensual < 0)
{
    Console.WriteLine("El salario mensual no puede ser negativo."); // Validación para evitar salarios negativos
}
else
{
    salarioSemanal = salarioMensual / 4;
    salarioDiario = salarioMensual / 30;
    salarioAnual = salarioMensual * 12;
    Console.WriteLine($"Salario anual: {salarioAnual}");
    Console.WriteLine($"Salario mensual: {salarioMensual}");
    Console.WriteLine($"Salario semanal: {salarioSemanal}");
    Console.WriteLine($"Salario diario: {salarioDiario}");
}

// Aqui calculas el ISR (Impuesto Sobre la Renta) y el salario neto mensual y anual
// Para esto declaras ISR, y le asignas valor con la condicional if-else

if (salarioAnual < 75984)
{
    isr = .064 ; // 6.40% de ISR para salarios anuales menores a 75984
}
else if (salarioAnual < 133536)
{
    isr = .188  ; // 10.88% de ISR para salarios anuales entre 75984 y 133536
}
else if (salarioAnual < 155229)
{
    isr = .16  ; // 16% de ISR para salarios anuales entre 133536 y 155229
}
else if (salarioAnual < 185852)
{
    isr = .1792  ; // 17.92% de ISR para salarios anuales entre 155229 y 185852
}
else if (salarioAnual < 374837)
{
    isr = .2136 ; // 21.36% de ISR para salarios anuales entre 185852 y 374837
}
else if (salarioAnual < 590795)
{
    isr = .2352  ; // 23.52% de ISR para salarios anuales entre 374837 y 590795
}
else if (salarioAnual < 1127926)
{
    isr = .30  ; // 30% de ISR para salarios anuales entre 590795 y 1127926
}
else if (salarioAnual < 1503902)
{
    isr = .32  ; // 32% de ISR para salarios anuales entre 1127926 y 1503902
}
else if (salarioAnual < 4511707)
{
    isr = .34 ; // 34% de ISR para salarios anuales entre 1503902 y 4511707
}
else
{
    isr = .35  ; // 35% de ISR para salarios anuales mayores a 4511707
}

Console.WriteLine($"El ISR que se aplica a tu salario es: {isr * 100}%"); // Muestra el porcentaje de ISR calculado

Console.WriteLine(" Los salarios netos son: ");
salarioNetoAnual =  salarioAnual - (salarioAnual * isr);
salarioNetoMensual = salarioNetoAnual / 12;
salarioNetoSemanal = salarioNetoMensual / 4;
salarioNetoDiario = salarioNetoMensual / 30;
Console.WriteLine($"Salario anual: {salarioNetoAnual}");
Console.WriteLine($"Salario mensual: {salarioNetoMensual}");
Console.WriteLine($"Salario semanal: {salarioNetoSemanal}");
Console.WriteLine($"Salario diario: {salarioNetoDiario}");
