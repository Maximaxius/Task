// A) Написать скрипт, который добавляет на страницу несколько элементов HTML (например, кнопки или текстовые поля) и отслеживает событие клика на каждом из них.
// При клике на элемент должно появляться сообщение с его текстовым содержимым.
// let button1 = document.createElement('button');
// button1.innerText = "button1"
// document.body.appendChild(button1);
// let button2 = document.createElement('button');
// button2.innerText = "button2"
// document.body.appendChild(button2);
// let div = document.createElement('div');
// div.innerText = "A) Написать скрипт, который добавляет на страницу несколько элементов HTML (например, кнопки или текстовые поля) и отслеживает событие клика на каждом из них. При клике на элемент должно появляться сообщение с его текстовым содержимым."
// document.body.appendChild(div);

// document.addEventListener("click",function(e){
//     console.log(e.target.innerText)
// })


// B) Создать страницу с несколькими кнопками, каждая из которых должна генерировать событие.
// Написать скрипт, который будет отслеживать эти события и выводить сообщение в консоль при их возникновении.
// Текст сообщения должен содержать текст, находящийся внутри кнопки, по которой был осуществлён клик.
let button1 = document.createElement('button');
button1.innerText = "button1"
document.body.appendChild(button1);
let button2 = document.createElement('button');
button2.innerText = "button2"
document.body.appendChild(button2);

document.addEventListener("click",function(e){
    console.log(e.target.innerText)
})


// C) Создайте новый элемент div и добавьте его в конец тега body.
let div = document.createElement('div');
document.body.appendChild(div);


// D) Получите ссылку на созданный элемент div и измените его содержимое на "Hello, world!".
let getDiv = document.getElementsByTagName('div');
getDiv[0].innerText = "Hello, world!";

// E) Измените цвет фона созданного элемента div на красный.
getDiv[0].style.backgroundColor = "red";

// F) Напишите функцию, которая при нажатии на кнопку удаляет один из элементов из DOM
let buttonForDel = document.createElement('button');
buttonForDel.innerText = "buttonForDel"
document.body.appendChild(buttonForDel);

function delFromDOM(){
    let forDel = document.querySelectorAll('div')
    console.log(forDel)                                                                                 //удаление рамномного дива
    forDel[Math.floor(Math.random()*forDel.length)].remove()
}

document.addEventListener('click',function(e){
    if(e.target == buttonForDel){
        delFromDOM(); 
    }
})

// G) Создайте HTML-страницу с кнопкой "Добавить элемент". При нажатии на кнопку должен добавляться новый элемент в список на странице.
let buttonForAdd = document.createElement('button');
buttonForAdd.innerText = "buttonForAdd"
document.body.appendChild(buttonForAdd);

document.addEventListener('click',function(e){
    if(e.target == buttonForAdd){
        let newDiv = document.createElement('div');
        newDiv.innerText = "I am new"
        document.body.appendChild(newDiv); 
    }
})