using CreationPatternDemo.PatternClasses;


var teacher = PersonFactory.GetInstance(1);
var student = PersonFactory.GetInstance(2);

Singleton first = Singleton.GetInstance();

Singleton second = Singleton.GetInstance();

Console.WriteLine();