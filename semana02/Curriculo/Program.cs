using System;

class Program
{
    static void Main(string[] args)
    {

        Emprego emprego1 = new Emprego();
        emprego1._empresa = "Apple";
        emprego1._cargo = "Programador Junior";
        emprego1._anoInicio = 2019;
        emprego1._anoFim = 2022;

        Curriculo curriculo = new Curriculo();
        curriculo._nome = "Alana Silva";
        curriculo._empregos.Add(emprego1);

        Emprego emprego2 = new Emprego();
        emprego2._empresa = "Amazon";
        emprego2._cargo = "Programador";
        emprego2._anoInicio = 2023;
        emprego2._anoFim = 2024;

        curriculo._empregos.Add(emprego2);

        Emprego emprego3 = new Emprego();
        emprego3._empresa = "Google";
        emprego3._cargo = "Programador";
        emprego3._anoInicio = 2025;


        curriculo._empregos.Add(emprego3);

        curriculo.Exibir();



    }
}