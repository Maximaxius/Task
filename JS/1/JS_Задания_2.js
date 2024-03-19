//Запросить у пользователя число и определить, оно положительное, отрицательное или ноль.
function firstTask(){
    let num = Number(numFirst.value);
    if (num>0)
    first.innerHTML="положительное";
    else if (num<0) 
    first.innerHTML="отрицательное";
    else first.innerHTML="ноль";
}


// Запросить у пользователя его возраст и проверить корректность введенных данных (0–120 лет).
function secondTask(){
    let num = Number(numSecond.value);
    if (num>=0 && num<=120)
    second.innerHTML="Коректные данные ";
    else second.innerHTML="Не коректные данные ";
}


//Запросить у пользователя число и вывести его модуль(|7| = 7, |-7| = 7).
function threeTask(){
    let num = Number(numThree.value);
    if (num>0)
    three.innerHTML=num*(-1);
    else three.innerHTML=num*(-1);
}


// Запросить у пользователя время (часы, минуты, секунды и проверить корректность введенных данных.
function fourTask(){
    let hour = Number(numFour1.value);
    let min = Number(numFour2.value);
    let sec = Number(numFour3.value)
    if (hour<=24 && min <=60 && sec <= 60)
        four.innerHTML="Время корректное";
    else four.innerHTML="Время не корректное";
}


// Запросить координаты точки (x, y) и определить номер четверти, в которую попала эта точка. Необходимо учесть 
// случаи попадания точки на оси X или Y или в начало координат
function fiveTask(){
    let x = Number(numFive1.value);
    let y = Number(numFive2.value);
    if(x >= 0 && y >= 0)
        five.innerHTML="1 четверть ";
    else if (x <= 0 && y >= 0)
        five.innerHTML="2 четверть ";
    else if (x <= 0 && y <= 0)
        five.innerHTML="3 четверть ";
    else five.innerHTML="4 четверть ";
}


// Запросить у пользователя номер месяца и вывести на экранего название.
function sixTask(){
    switch(numSix.value){
        case "1":
            six.innerHTML="Январь";
        break;
        case "2":
            six.innerHTML="Февраль";
        break;
        case "3":
            six.innerHTML="Март";
        break;
        case "4":
            six.innerHTML="Апрель";
        break;
        case "5":
            six.innerHTML="Май";
        break;
        case "6":
            six.innerHTML="Июнь";
        break;
        case "7":
            six.innerHTML="Июль";
        break;
        case "8":
            six.innerHTML="Август";
        break;
        case "9":
            six.innerHTML="Сентябрь";
        break;
        case "10":
            six.innerHTML="Октябрь";
        break;
        case "11":
            six.innerHTML="Ноябрь";
        break;
        case "12":
            six.innerHTML="Декабрь";
        break;
        default: six.innerHTML="Введите коректный номер ";
    }
}


// Реализовать калькулятор. Пользователь вводит 2 числа и знак (+ - * /).
// В зависимости от введенного знака решить пример и вывести результат.
function sevenTask(){
    let a = Number(numSeven1.value);
    let b = Number(numSeven2.value);
    switch(numSevenKey.value){
        case "+":
            seven.innerHTML=`${a} + ${b} = ${a+b}`;
        break;
        case "-":
            seven.innerHTML=`${a} - ${b} = ${a-b}`;
        break;
        case "*":
            seven.innerHTML=`${a} * ${b} = ${a*b}`;
        break;
        case "/":
            seven.innerHTML=`${a} / ${b} = ${a/b}`;
        break;
        default: seven.innerHTML="Введите коректный знак ";
    }
}


//Запросить 2 числа и вывести большее из них.
function eightTask(){
    let a = Number(numEight1.value);
    let b = Number(numEight2.value);
    eight.innerHTML = a > b ? a : b
}


// Запросить 1 число и проверить, оно кратно 5 или нет.
function nineTask(){
    let a = Number(numNine.value);
    nine.innerHTML = a % 5==0 ? "Кратное 5" : "Не кратное 5"
}


// Запросить у пользователя название планеты. Если пользователь ввел «Земля» или «земля»,
//  то вывести «Привет,землянин!», в остальных случаях вывести «Привет, инопланетянин!».
function tenTask(){
    let name = numTen.value;
    ten.innerHTML = (name=="Земля"|| name == "земля") ? "Привет,землянин!" : "«Привет, инопланетянин!"
}