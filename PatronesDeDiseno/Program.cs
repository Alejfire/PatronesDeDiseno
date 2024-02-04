/*Los patrones de diseño son soluciones a problemas que se
  reutilizan mucho ya que resuelven problemas comunes*/

using System;
using System.Collections.Generic;

//Observer pattern: Se encarga de hacer que cuando el objeto padre es cambiado,
//los objetos que heredan de el tambien son actualizados.

/*
interface IObservador
{
    void Actualizar(string mensaje);
}

class ObservadorConcreto : IObservador
{
    private string nombre;

    public ObservadorConcreto(string nombre)
    {
        this.nombre = nombre;
    }

    public void Actualizar(string mensaje)
    {
        Console.WriteLine($"{nombre} mensaje revibido: {mensaje}");
    }
}

interface ISujeto
{
    void Agregar(IObservador observador);
    void Quitar(IObservador observador);
    void NotficarObservadores(string mensaje);
}

class SujetoConcreto : ISujeto
{
    private List<IObservador> observadores = new List<IObservador>();

    public void Agregar(IObservador observador)
    {
        observadores.Add(observador);
    }

    public void Quitar(IObservador observador)
    {
        observadores.Remove(observador);
    }

    public void NotficarObservadores(string mensaje)
    {
        foreach (var observer in observadores)
        {
            observer.Actualizar(mensaje);
        }
    }
}

*/


/*Strategy pattern: Define una familia de algoritmos, los encapsula y los hace intercambiables.*/

/*
interface IEstrategia
{
    void Ejecutar();
}

class EstrategiaConcreta1 : IEstrategia
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejecutando estrategia 1");
    }
}

class EstrategiaConcreta2 : IEstrategia
{
    public void Ejecutar()
    {
        Console.WriteLine("Ejecutando estrategia 2");
    }
}

class Contexto
{
    private IEstrategia estrategia;

    public Contexto(IEstrategia estrategia)
    {
        this.estrategia = estrategia;
    }

    public void EstablecerEstrategia(IEstrategia estrategia)
    {
        this.estrategia = estrategia;
    }

    public void EjecutarEstrategia()
    {
        estrategia.Ejecutar();
    }
}
*/

/*Decorator pattern: Ayudan a agregar responsabilidades adicionales a objetos dinamicamente.*/

/*
interface IComponente
{
    void Operacion();
}

class ComponenteConcreto : IComponente
{
    public void Operacion()
    {
        Console.WriteLine("Operación del Componente Concreto");
    }
}

abstract class Decorador : IComponente
{
    private IComponente componente;

    public Decorador(IComponente componente)
    {
        this.componente = componente;
    }

    public virtual void Operacion()
    {
        componente.Operacion();
    }
}

class DecoradorConcreto1 : Decorador
{
    public DecoradorConcreto1(IComponente componente) : base(componente) { }

    public override void Operacion()
    {
        base.Operacion();
        Console.WriteLine("Operacion del DecoradorConcreto1");
    }
}

class DecoradorConcreto2 : Decorador
{
    public DecoradorConcreto2(IComponente componente) : base(componente) { }

    public override void Operacion()
    {
        base.Operacion();
        Console.WriteLine("Operacion del DecoradorConcreto2");
    }
}
*/