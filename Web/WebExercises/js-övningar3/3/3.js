document.addEventListener("DOMContentLoaded", () => {

    let btn = document.getElementById("btn");
    let text = document.getElementById("text");

    btn.addEventListener("click", () => {
        text.style.display = text.style.display === "none" ? "block" : "none";
    });
});