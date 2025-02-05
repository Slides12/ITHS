

class Bil {

    constructor(brand, model, year){
        this.brand = brand;
        this.model = model;
        this.year = year;
    }
    getInfo(){
        return `${this.brand}, ${this.model} (${this.year})`
    }
}

const bil = new Bil("Volvo", "S60", 2020);

console.log(bil.getInfo());