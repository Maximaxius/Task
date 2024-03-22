// Создать html-страницу с возможностью ввода числового значения через кнопки (больше, меньше).
// Пользователь не должен иметь возможность печатать текст или цифры. Число изменяется только при нажатии на кнопки.
function firstTask(event) {
    event.preventDefault();
}

//  Задание 2  Создать html-страницу с кнопкой, по нажатию на которую добавляются цветные блоки на страницу. По клику на сам блок,
//  он должен удаляться со страницы.
function randomRGBA() {
    let r = Math.floor(Math.random() * 256);
    let g = Math.floor(Math.random() * 256);
    let b = Math.floor(Math.random() * 256);
    let a = Math.random();
    return `rgba(${r}, ${g}, ${b}, ${a})`;
    }

function secondTask(){    
    let obj = document.createElement('span');    
    obj.className = 'obj';
    obj.style.top = 50 + 'px';
    obj.style.left = 50 + 'px';
    obj.style.backgroundColor = randomRGBA();
    second.appendChild(obj);
}

document.addEventListener('mousedown',function(e){
    if (e.target.parentElement === second) {
        e.target.remove();
    }
})
