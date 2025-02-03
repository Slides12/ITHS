document.addEventListener("DOMContentLoaded", () => {

    let input = document.getElementById("input");
    let btn = document.getElementById("btn");
    let text = document.getElementById("p");





    btn.addEventListener("click", () => {

        switch(Number(input.value)){
            case 1:
                text.textContent = `${input.value} = Måndag.`;
                break;
            case 2:
                text.textContent = `${input.value} = Tisdag.`;
                break;
            case 3:
                text.textContent = `${input.value} = Onsdag.`;
                break;
            case 4:
                text.textContent = `${input.value} = Torsdag.`;
                break;
            case 5:
                text.textContent = `${input.value} = Fredag.`;
                break;
            case 6:
                text.textContent = `${input.value} = Lördag.`;
                break;
            case 7:
                text.textContent = `${input.value} = Söndag.`;
                break;
            default:
                text.textContent = "Det verkar som du har skrivit något knas, endast 1-7 funkar i denna app.";
                break;
                
        }

        input.value = "";
        input.removeAttribute("placeholder");

    });
});