# Objektorienterad programmering

Fyra grundläggande principer

* Inkapsling (encapsulation)
    * Gruppera information

* Abstraktion (Abstract)
    * Gömma information
    *Hög nivå(Hög abstraction,t.ex Python, javascript, c#)
    * Låg nivå (Låg abstraction, assembler)

* Arv  (Inheritance)
    * Dela information mellan object

* Polymorphism 
    * Omdefiniera information (Constructor)
     (Samma sak kan betyda 2 olika saker för 2 olika objekt)



## Objekt katt: (En Klass av katt) 
### Egenskapar
* Namn: Morris
* Vikt: 3.8 kg
* Färg: svart
* Har päls
* Har 4 ben

### Interna tillstånd
* Hungrig: Nej
* Trött: Nej

### Metoder(Saker objekter kan göra.)
* Springa();
* Jama(int volym);

Inkapsling, i ett objekt

Abstraktion, metoderna springa och jama.


## Objekt Fågel. (En klass av fågel)

### Egenskaper
* Namn: Fenix
* Vikt: 38g
* Färg: Grön
* Har fjädrar
* Har 2 ben

### Interna tillstånd:
* Hungrig: ja
* Trött: nej

### Metoder:
* Springa();
* Kvittra();
* Flyga();



## Klasser = Blueprint.
Om en inheritar från en superklass, så kallas den klassen Subclass. (Child.)

## Arv = Grund blueprint (Super klass (Parent)/ Bas klass).

Dvs, Klass djur. Kan ärvas av både fåglar och katter.



## Access modifier
* Private - En egenskap som är privat.

* Public - En egenskap som är läs/skrivbar.

* Protected - som en private men de som ärver kan använda variabeln

* Internal - public för all kod inom biblioteket



## Overloading
Method overloading
* Jama();
    * Jama(int volym);
        * Jama(double volym);



Operator overloading
* 2 +3 =5 (Adderar)
* "ABC + "DEF = "ABCDEF" (contantenerar)

* Object + Object = ? (Kan man definiera själv i klassen om man vill, går vanligtvis inte)
    * t.ex cat + cat1 = Vikt: 10 kg
    * t.ex cat + cat1 = Namn: "PetterErik"



    
     
