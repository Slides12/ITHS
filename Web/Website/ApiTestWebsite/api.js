document.addEventListener("DOMContentLoaded", () => {

    var list = document.getElementById("api");
    
function UppdateraList(){

    while (list.firstChild) { 
        list.removeChild(list.firstChild);
    }
    
    fetch("https://localhost:7289/api/Test")
    .then(response => {
        if (!response.ok) throw new Error("Network response was not ok.");
            return response.json();
    })
    .then(data => {

        data.forEach(item => {
            
            let li = document.createElement("li");
            li.textContent = item.name;
            list.appendChild(li);
        });

    })
    .catch(error => console.error(`API Error: `, error));
}

UppdateraList();

var btn = document.getElementById("mongo");

btn.addEventListener("click", () => {

    var inputName = document.getElementById("inputName");
    var inputDesc = document.getElementById("inputDesc");
    var inputPrice = document.getElementById("inputPrice");
    var inputCate = document.getElementById("inputCate");

    const postOptions = {
        method: "POST",
        headers:  {
            "Content-Type": "application/json"
        },
        body: JSON.stringify({
            Name: inputName.value,
            Description: inputDesc.value,
            Price: inputPrice.value,
            ProductCategory: inputCate.value
        })
    };


    fetch("https://localhost:7289/api/Test", postOptions)
    .then(response => {
        if (!response.ok) throw new Error("Network response was not ok.");
        UppdateraList();
        return response.json()
    })
    .then(data => console.log("inlägg skapat", data))
    .catch(error => console.error(`Fel vid anrop: `, error));

});


var rmBtn = document.getElementById("rmBTN");

rmBtn.addEventListener("click", () => {

    var inputRM = document.getElementById("inputRM");
    

    const delOptions = {
        method: "DELETE",
        headers:  {
            "Content-Type": "application/json"
        }
    };


    fetch(`https://localhost:7289/api/Test/deleteName/${inputRM.value}`, delOptions)
    .then(response => {
        if (!response.ok) throw new Error("Network response was not ok.");
        UppdateraList();
        return response.json()
    })
    .then(data => console.log("Verktyg deletat", data))
    .catch(error => console.error(`Fel vid anrop: `, error));

});



});