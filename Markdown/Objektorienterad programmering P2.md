# Object oriented programming P2.

## Class
* är en definition av en datatyp.
* är en modell/ blueprint
* instancering = t.ex . Cat myCat = new Cat();
* instance = skapa object
* En statisk class går ej att instancera.


## Object
* är en enskild representation av en given typ (class)


## Members
* representerar data och funktionalitet
* knutna till en class
* metoder är anropbar kod knutna till et object.
* fields = variabel


## this
* referar till den instans av klass som har anropat en av klassens metoder

## Method overloading
* är polymorphism
* flera metoder i en klass med samma namn som tar olika antal paramtrar.
* flera olika former av samma metod

## ?
* är en null hanterare. cat?.name om katt är null, skrivs inget ut. Men programmet fungerar.
* Om den inte är null så skriver den ut cat.name som om inget skett

## Access modifiers
* public - används för kompilatorn skall se vem som skall kunna ha access till members.

* private - private gör att endast class'en i sig kan använda variabeln/fields

## Static
* används om man skall kalla en class utan att instanciera den. dvs jag callar Cat.Greet istället för Cat myCat = new Cat() myCat.Greet.
    * i locala funktioner kan ej komma åt variabler som inte är i själva statiska funktionen.


## Local functions
* ÄR metoder som ligger i Main(String[] args)

## Method
* Är utanför main(string[] args)



## Namespace

* används för att skilja på t.ex ett nerladdat pakets funktion Hej() och min lokala funktion Hej(). det som krävs för att då calla en namespaced är : 
    * nameSpaceNamn.class.Hej();

* Är nästlingsbar dvs:
    * nameSpaceNamn.anotherNameSpace.class.Hej();


* kan även calla anotherNameSpace.class.Hej(); även om det är nestlat


## Using

* använder namespaces. T.ex System.


## Constructor

* Keyword "new" anropar konstruktorn på en klass som skapar objektet och returnerar ene referens till det nyskapade objektet.
    ```
    Cat myCat = new Cat();
    ```

* Du kan göra flera olika konstruktors för en class. Ta Cat() t.ext
```
class Cat 
{
    public string name;
    public Cat(string name)
    {
        this.name = name;
    }
}
```




## Properties
Properties är get/setters (Du kan lägga till logik)

* string text.Length - Length är en property (Egenskap)



* Getters and setters:
```
    private string _name = "Otto";

    public string Name
    {
        get
        {
            return _name;
        }

        set
        {
            _name = value;
        }
    }
```


* lagrar och hämtar data från klasser.

* Fungerar på samma sätt som en field. WriteLine i Console.Writeline är en field.
    * Fields är även variabler i en klass!

* prop är förkortning för att skriva den smidigaste auto propertyn.

    	```
        public int MyProperty { get; set; }
        ```

        ```
        public int Age { get { return 10; } set { } }
        ```
        


## Fields
* Är en variabel i en class/object
* om en field börjar med _name så tillhör den en property. Denna är då oftast private _name.
    * public Name är då propertyn som set and get körs på.

