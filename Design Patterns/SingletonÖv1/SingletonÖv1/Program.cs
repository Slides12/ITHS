// See https://aka.ms/new-console-template for more information
using SingletonÖv1.Classes;

Console.WriteLine("Hello, World!");


var logger = Logger.GetInstance();
logger.Log("yo");
logger.Log("hej");

var logger2 = Logger.GetInstance();
logger2.Log("något annat");
