
using lab3;
using lab4;
using System.Reflection.Emit;
using TestRef;

var test = new Product();
var test2 = new Device();


Console.WriteLine(Reflector.GetAssemblyName(test));
Console.WriteLine(Reflector.GetAssemblyName("lab4.Product, lab4"));  //lab4.Product имя типа 
Console.WriteLine(Reflector.HasPublicConstructor(("lab4.Product, lab4")));
Reflector.GetMethods("lab4.Product, lab4");
Reflector.GetPublicFields("lab4.Product, lab4");
Reflector.GetInterfaces("lab4.Product, lab4");
Console.WriteLine(Reflector.Invoke(test2, "ToString", []));

Console.ReadLine();

var obj = new Object();
var ourType = obj.GetType();
Console.WriteLine(ourType.BaseType);


