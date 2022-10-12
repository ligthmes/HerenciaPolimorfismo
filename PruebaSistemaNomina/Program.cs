﻿using PruebaSistemaNomina;

EmpleadoAsalariado empleadoAsalariado =
    new EmpleadoAsalariado("Juan", "Sánchez", "111-11-1111", 800.00M);
EmpleadoPorHoras empleadoPorHoras =
    new EmpleadoPorHoras("Karen", "Ponce", "222-22-2222", 16.75M, 40.0M);
EmpleadoPorComision empleadoPorComision =
    new EmpleadoPorComision("Susana", "Pérez", "333-33-3333", 10000.00M,
    0.6M);
EmpleadoBaseMasComision empleadoBaseMasComision =
    new EmpleadoBaseMasComision("Roberto", "López", "444-44-4444", 5000.00M,
    .04M, 300.00M);

Console.WriteLine("Empleados procesados de forma individual:\n");
Console.WriteLine("{0}\n{1}: {2:C}\n",
    empleadoAsalariado, "ingresos", empleadoAsalariado.Ingresos());
Console.WriteLine("{0}\n{1}: {2:C}\n",
    empleadoPorHoras, "ingresos", empleadoPorHoras.Ingresos());
Console.WriteLine("{0}\n{1}: {2:C}\n",
    empleadoPorComision, "ingresos", empleadoPorComision.Ingresos());
Console.WriteLine("{0}\n{1}: {2:C}\n",
    empleadoBaseMasComision, "ingresos", empleadoBaseMasComision.Ingresos());

Empleado[] empleados = new Empleado[4];
empleados[0] = empleadoAsalariado;
empleados[1] = empleadoPorHoras;
empleados[2] = empleadoPorComision;
empleados[3] = empleadoBaseMasComision;

Console.WriteLine("Empleados procesados en forma polmórfica:\n");
foreach(Empleado empleadoActual in empleados)
{
    Console.WriteLine(empleadoActual);
    if(empleadoActual is EmpleadoBaseMasComision)
    {
        EmpleadoBaseMasComision empleado = (EmpleadoBaseMasComision)empleadoActual;
        empleado.SalarioBase *= 1.10M;
        Console.WriteLine(
            "nuevo salario base con incremento del 10%: {0:C}",
            empleado.SalarioBase);
    }

    Console.WriteLine(
        "ingresos {0:C}\n", empleadoActual.Ingresos());
}

for(int i = 0; i < empleados.Length; i++)
    Console.WriteLine("Empleado {0} es un {1}", i, empleados[i].GetType());

