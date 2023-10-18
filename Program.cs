// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var abstractFactory01 = new curso_design_patterns.Creational.AbstractFactory.Example01.App();
var abstractFactory02 = new curso_design_patterns.Creational.AbstractFactory.Example02.App();
var abstractFactory03 = new curso_design_patterns.Creational.AbstractFactory.Example03.App();

var factory01 = new curso_design_patterns.Creational.Factory.Example01.App();
var factory02 = new curso_design_patterns.Creational.Factory.Example02.App();

var singleton01 = new curso_design_patterns.Creational.Singleton.Example01.App();

singleton01.Run();