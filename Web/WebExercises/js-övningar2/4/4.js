document.addEventListener("DOMContentLoaded", () => {

    let input = document.getElementById("input");
    let btn = document.getElementById("btn");
    let text = document.getElementById("h3");



    btn.addEventListener("click", () => {
        let count = 0;

        let vokaler = ['a', 'e', 'i', 'o', 'u'];

        for(let i = 0; i < input.value.length; i++){
            if(vokaler.includes(input.value[i].toLowerCase())){
                count++;
            }
        }
        text.textContent = `${count} st vokaler!`;
    });

});