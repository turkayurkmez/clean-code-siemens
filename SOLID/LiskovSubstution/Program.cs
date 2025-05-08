// See https://aka.ms/new-console-template for more information
using LiskovSubstution;

Console.WriteLine("Hello, World!");

/*
 * Liskov'un davranışsal alt tip kavramı, nesneler için bir yer değiştirilebilirlik kavramı tanımlar; yani S, T'nin bir alt tipi ise, bir programdaki T tipindeki nesneler, o programın istenen özelliklerinden herhangi birini değiştirmeden S tipindeki nesnelerle yer değiştirilebilir.
 */

Rectangle rectangle = new Rectangle();
rectangle.Width = 10;
rectangle.Height = 5;

Console.WriteLine(rectangle.GetArea());

Square square = new Square ();
square.Edge = 10;

Console.WriteLine(square.GetArea());

IArea rect = new Geometry().GetRectangle(5);

//rect.Width = 5;
//rect.Height = 4;

Console.WriteLine(rect.GetArea());