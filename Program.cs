// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var abstractFactory01 = new curso_design_patterns.Creational.AbstractFactory.Example01.App();
var abstractFactory02 = new curso_design_patterns.Creational.AbstractFactory.Example02.App();
var abstractFactory03 = new curso_design_patterns.Creational.AbstractFactory.Example03.App();

var factory01 = new curso_design_patterns.Creational.Factory.Example01.App();
var factory02 = new curso_design_patterns.Creational.Factory.Example02.App();

var singleton01 = new curso_design_patterns.Creational.Singleton.Example01.App();

var adapter01 = new curso_design_patterns.Structural.Adapter.Example01.App();
var adapter02 = new curso_design_patterns.Structural.Adapter.Example02.App();
var adapter03 = new curso_design_patterns.Structural.Adapter.Example03.App();

var facade01 = new curso_design_patterns.Structural.Facade.Example01.App();

facade01.Run();