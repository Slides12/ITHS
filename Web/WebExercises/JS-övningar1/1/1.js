document.addEventListener("DOMContentLoaded", () => {

    let nameInput = document.getElementById("input");
    let btn = document.getElementById("btn");
    let header = document.getElementById("header");

    btn.addEventListener("click", () => {
        let name = nameInput.value.trim();

        if(name != ""){
            header.textContent = `Välkommen ${name}!`;
        }

        nameInput.value = "";
    });


});