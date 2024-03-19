// Запросите у пользователя число, возведите это число во
// 2-ю степень и выведите на экран.
function firstTask(){
    let num = Number(numFirst.value);
    first.innerHTML=num*num;
}


// Запросите у пользователя 2 числа и выведите среднее арифметическое этих чисел.
function secondTask(){
    let num1 = Number(numSecond1.value);
    let num2 = Number(numSecond2.value);
    second.innerHTML=(num1+num2)/2 +" ср арифмет";
}


//Запросите у пользователя длину стороны квадрата и выведите площадь такого квадрата.
function threeTask(){
    let side = Number(numThree.value);
    three.innerHTML=side*side +"см2";
}


// Реализуйте конвертор из километров в мили (пользователь вводит километры, программа выводит мили).
// 1 км = 0,621371миль. Это значение укажите в коде как константу
function fourTask(){
    const convert =0.621371;
    let userNum = Number(numFour.value);
    four.innerHTML=userNum*convert +"миль";
}


//Реализуйте калькулятор. Пользователь вводит два числа,а программа выводит результаты действий + - * / между этими числами.
function fiveTask(){
    let num1 = Number(numFive1.value);
    let num2 = Number(numFive2.value);
    sum.innerHTML = num1+num2;
    minus.innerHTML = num1-num2;
    multiplication.innerHTML = num1*num2;
    division.innerHTML = num1/num2;    
}


// Пользователь вводит значения a и b для формулы a * x + b = 0, а программа считает и выводит значение x.
function sixTask(){
    let a = Number(numSix1.value);
    let b = Number(numSix2.value);
    six.innerHTML="x="+ -b/a;
}


// Запросите у пользователя текущее время (часы и минуты) и выведите, сколько часов и минут осталось до следующего дня.
function sevenTask(){
    let hour = Number(numSeven1.value);
    let min = Number(numSeven2.value);
    if (hour<24 && min <60)
        seven.innerHTML= `${24-hour}h ${60-min}min`;
}