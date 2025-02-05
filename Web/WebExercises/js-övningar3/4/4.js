document.addEventListener("DOMContentLoaded", () => {


    let btn = document.getElementById("btn");
    let text = document.getElementById("text");


    btn.addEventListener("click", () => {

        let fontSize = 4;

        let currentSize = parseInt(text.style.fontSize) || 32;

        text.style.fontSize = (currentSize + fontSize) + "px";

    });
});