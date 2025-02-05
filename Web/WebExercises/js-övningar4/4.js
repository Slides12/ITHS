class Animal {
    constructor(name, species){
        this.name = name;
        this.species = species;
    }
    describe(){
        return `This is a ${this.species} and it's name is ${this.name}!`
    }
}

const animal = new Animal("Greta", "Cow");
console.log(animal.describe());