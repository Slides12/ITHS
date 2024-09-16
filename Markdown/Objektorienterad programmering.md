# Objektorienterad programmering

Fyra grundläggande principer

* Inkapsling (encapsulation)
    * Gruppera information

* Abstraktion (Abstract)
    * Gömma information
    *Hög nivå(Hög abstraction,t.ex Python, javascript, c#)
    * Låg nivå (Låg abstraction, assembler)

* Arv  (Inheritance)
    * Dela information

* polymorphism 
    * Omdefiniera information
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

## Arv = Grund blueprint (Super klass (Parent)).

Dvs, Klass djur. Kan ärvas av både fåglar och katter.



## Access modifier
* Private - En egenskap som är privat.

* Public - En egenskap som är läs/skrivbar.

* Protected

* Internal



## Overloading
Method overloading
* Jama();
    * Jama(int volym);
        * Jama(double volym);



Operator overloading
* 