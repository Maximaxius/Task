// A) Сохраните в localStorage значение "Hello, world!" под ключом "message", а также 2 числа под любыми ключами
localStorage.clear()
localStorage.setItem("massage","Hello, world!");
localStorage.setItem("num1",Math.floor(Math.random()*22));
localStorage.setItem("num2",Math.floor(Math.random()*22));
console.log(localStorage)


// B) Получите значение из localStorage по ключу "message" и выведите его на экран любым удобным способом.
// Также отобразите сумму чисел, ранее занесённых в локальное хранилище. Числа достать именно из локального хранилища.
let massage = document.createElement('h1')
massage.innerText = localStorage.getItem('massage');
console.log(massage)
document.body.appendChild(massage);

let sum =document.createElement('h1')
sum.innerText = `${localStorage.getItem('num1')}+${localStorage.getItem('num2')} = ${Number(localStorage.getItem('num1'))+Number(localStorage.getItem('num2'))}`
console.log(sum)
document.body.appendChild(sum);


// C) Удалите значения ранее добавленные из localStorage. 
localStorage.clear()


// D) Установите cookie с именем "username" и значением "John". 
document.cookie = "username = John"


// E) Получите значение cookie с именем "username" и выведите его на экран с помощью команды console.log(). 
function cookiesToObject(){
	let x = document.cookie;
    let s = x.split('; ');
    let cookieObject = {};
    let c;
    for(var i=0; i < s.length; i++){
     c = s[i].split('=');
     cookieObject[c[0]] = c[1];
    }

    return cookieObject;
}
cookiesObj = cookiesToObject();

console.log(cookiesObj.username)

// F) Удалите cookie с именем "username".
document.cookie = "username = John; max-age=0";
console.log(document.cookie)