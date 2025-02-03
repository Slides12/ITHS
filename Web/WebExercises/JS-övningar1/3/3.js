document.addEventListener("DOMContentLoaded", () => {

    let h1 = document.getElementById("h1");
    let btn = document.getElementById("btn");

    let count = 0;

    btn.addEventListener("click", () => {
        count++;
        h1.textContent = `Du har tryckt ${count} gånger!`
    });

});