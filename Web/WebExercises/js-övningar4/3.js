class Person{
    constructor(name){
        this.name = name;
    }

    greet(){
        return `Greetings ${this.name}!`;
    }
}


const person = new Person("Daniel");

console.log(person.greet());