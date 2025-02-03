document.addEventListener("DOMContentLoaded", () => {

    let input = document.getElementById("input");
    let btn = document.getElementById("btn");
    let text = document.getElementById("h3");


    btn.addEventListener("click", () => {

        if(isNaN(input.value)){
            text.textContent = `Du måste skriva en siffra!` 
        }
        else{

            if((Number(input.value) % 3) === 0 && (Number(input.value) % 5) === 0){
                text.textContent = "FizzBuzz";
            }
            else if((Number(input.value) % 3) === 0){
                text.textContent = "Fizz";
            }
            else if((Number(input.value) % 5) === 0){
                text.textContent = "Buzz";
            }
            else{
                text.textContent = input.value;
            }
        }
    });
});