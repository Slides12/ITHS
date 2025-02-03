document.addEventListener("DOMContentLoaded", () => {
    
    let btn = document.getElementById("btn");
    let h1 = document.getElementById("h1");

    btn.addEventListener("click", () => {

        
        document.body.style.backgroundColor = getRandomColor();
        h1.textContent = `Färgen ändrades till ${document.body.style.backgroundColor.toString()}!`

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