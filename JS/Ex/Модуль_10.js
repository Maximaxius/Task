// a) Напишите функцию, которая будет вызываться каждые 5 секунд с помощью setInterval. Функция должна менять цвет фона страницы на случайный цвет.
function randomRGBA() {
    let r = Math.floor(Math.random() * 256);
    let g = Math.floor(Math.random() * 256);
    let b = Math.floor(Math.random() * 256);
    let a = Math.random();
    return `rgba(${r}, ${g}, ${b}, ${a})`;
}

function A(){
    document.body.style.backgroundColor = randomRGBA();
}
setInterval(A, 5000);


// b) Напишите функцию, которая будет вызываться через 1 секунду с помощью setTimeout. Функция должна выводить в консоль сообщение "Прошла 1 секунда".
function B(){
    console.log("Прошла 1 секунда");
}
setTimeout(B(),1000)


// c) Напишите функцию, которая будет вызываться каждую секунду с помощью setInterval. Функция должна увеличивать значение переменной на 1 и выводить ее в консоль.
// Переменная должна быть объявлена вне функции.
var num=0;
function C(){
    console.log(num);
    num++;
}
setInterval(C,1000);

// d) Напишите функцию, которая будет вызываться каждые 500 миллисекунд с помощью setInterval.
// Функция должна изменять значение свойства opacity элемента на странице от 0 до 1 и обратно. Элемент должен быть задан заранее.
function D(){
    let div = document.getElementById('div')
    div.style.opacity = Math.random()
}
setInterval(D,500);