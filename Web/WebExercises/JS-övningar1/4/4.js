document.addEventListener("DOMContentLoaded", () => {


    let i1 = document.getElementById("input1");
    let i2 = document.getElementById("input2");
    let operator = document.getElementById("math");
    let btn = document.getElementById("btn");
    let text = document.getElementById("p");

    btn.addEventListener("click", () => { 

        let num1 = Number(i1.value);
        let num2 = Number(i2.value);

        let result;


        if (isNaN(num1) || isNaN(num2)) {
            text.textContent = "Du måste skriva in siffror";
            return;
        }

        switch (operator.value){
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "/":
                if (num2 === 0) {
                    text.textContent = "Går ej att dela på noll";
                    return;
                }
                result = num1 / num2;
                break;
            case "*":
                result = num1 * num2;
                break;
        }
        text.textContent = `= ${result}`;

        i1.value = "";
        i2.value = "";
        i1.removeAttribute("placeholder");
        i2.removeAttribute("placeholder");


    });


});
