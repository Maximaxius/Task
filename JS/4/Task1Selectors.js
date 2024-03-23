// 2. Реализуйте скрипт (только JS), который позволяет на текущей странице залить фон определённым оттенком
// для всех элементов с выбранным селектором тэга.
// К примеру, переменная selector определяет тип селектора, а color -оттенок заливки.
// function second(){
//     let selector = document.getElementsByTagName("span")
//     let color ="#"
//     for(let i=0;i<6;i++){
//         color+= Math.floor(Math.random() * 9);
//     }
//     for(el of selector){
//         el.style.backgroundColor = color ;
//     }
// }


// 3. Реализуйте скрипт (только JS), который позволяет на текущей странице подсветить (border с жёлтым оттенком)    span
// определённым оттенком все элементы с выбранным селектором (любой).
// let selector = document.getElementsByTagName("span")
// let color = "orange";
// for(el of selector){
//     el.style.border = "solid ";
//     el.style.borderColor = color ;
// }


// //3.1 div
// let selector = document.getElementsByTagName("div")
// let color = "orange";
// for(el of selector){
//     el.style.border = "solid 1px";
//     el.style.borderColor = color ;
// }


//3.2 Заголовки 3-го уровня, которые вложены в div (div h3)
// let selector = document.querySelectorAll("div h3")
// let color = "orange";
// for(el of selector){
//     el.style.border = "solid 2px";
//     el.style.borderColor = color ;
// }


//4. Реализуйте скрипт (только JS), который позволяет на текущей странице удалить все элементы с выбранным селектором (любой).
// let selector = document.getElementsByTagName("span")
// for(el of selector){
//     el.style.display = "none";
// }


//4. Реализуйте скрипт (только JS), который позволяет на текущей странице удалить все элементы с выбранным селектором (любой).
let selectorImg = document.getElementsByTagName("img")
for(el of selectorImg){
    el.style.display = "none";
}


let selector = document.getElementsByClassName("b-top-actions")
for(el of selector){
    el.style.display = "none";
}
