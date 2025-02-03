document.addEventListener("DOMContentLoaded", () => {


    let btn = document.getElementById("btn");
    let header = document.getElementById("h1");

    btn.addEventListener("click", () => {
        let fontSize = 4;

        let currentSize = parseInt(header.style.fontSize) || 32;

        header.style.fontSize = (currentSize + fontSize) + "px";
        header.style.color = getRandomColor();
    });

    function getRandomColor() {
        var letters = '0123456789ABCDEF';
        var color = '#';
        for (var i = 0; i < 6; i++) {
          color += letters[Math.floor(Math.random() * 16)];
        }
        return color;
      }
});