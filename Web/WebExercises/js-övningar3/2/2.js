document.addEventListener("DOMContentLoaded", () => {


    let input = document.getElementById("input");
    let list = document.getElementById("ul");
    let addBTN = document.getElementById("addBtn");
    let rmBTN = document.getElementById("rmBtn");
    let rmInput = document.getElementById("rmInput");

    addBTN.addEventListener("click", () => {

        let newListItem = document.createElement("li");

        newListItem.textContent = input.value;

        list.appendChild(newListItem);

        input.value = "";
    });


    rmBTN.addEventListener("click", () => {

       list.removeChild(list.children[Number(rmInput.value-1)]);
       rmInput.value= "";
    });

});