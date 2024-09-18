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

* static - används om man skall kalla en class utan att instanciera den. dvs jag callar Cat.Greet istället för Cat myCat = new Cat() myCat.Greet.

