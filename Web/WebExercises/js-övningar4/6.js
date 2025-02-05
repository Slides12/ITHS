function getRandomNumber(min, max){
    return Math.floor(Math.random() * (max - min) + min);
}

console.log(getRandomNumber(2,8));