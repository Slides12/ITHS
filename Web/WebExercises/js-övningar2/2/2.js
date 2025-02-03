document.addEventListener("DOMContentLoaded", () => {

    let input = document.getElementById("input");
    let btn = document.getElementById("btn");
    let list = document.getElementById("ul");


    

    btn.addEventListener("click", () => {
        list.innerHTML = "";

        if (isNaN(input.value)) {
            let newListItem = document.createElement("li");
                newListItem.textContent = "This is not a valid input. Only input a number.";
                list.appendChild(newListItem)
          }else{
            
              for(let i = 0; i< 10; i++){
                  let newListItem = document.createElement("li");
                  newListItem.textContent = `${Number(input.value) * i}`;
                  list.appendChild(newListItem)
              }
          }
          
    });
});