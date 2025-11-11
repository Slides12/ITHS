
using DemoBehaviourPattern;

Subject nyIphone = new Subject("Iphone 18", "Ej i lager");

Observer observer1 = new Observer("lisa@gmail.com", nyIphone);
Observer observer2 = new Observer("kalle@gmail.com", nyIphone);

nyIphone.SetAvailability("I lager");

nyIphone.NotifyObservers();