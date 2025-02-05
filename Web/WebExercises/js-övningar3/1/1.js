document.addEventListener("DOMContentLoaded", () => {

    let input = document.getElementById("input");
    let btn = document.getElementById("btn");
    let text = document.getElementById("text");

    let count = Math.floor(Math.random() * 10) + 1;

    btn.addEventListener("click",  () => {

        if(isNaN(input.value)){
            text.textContent = `Du kan endast gissa med siffror, inte bokstäver. Testa igen`;

        } else if(Number(input.value) > count){
            text.textContent = `Din gissning ${input.value} är för hög, testa en lägre siffra.`;
        } else if(Number(input.value) < count){
            text.textContent = `Din gissning ${input.value} är för låg, testa en högre siffra.`;
        }
        else{
            text.textContent = `Du gissade rätt! Snyggt! kör igen!`;
            count = Math.floor(Math.random() * 10) + 1;
        }

    });

});