// Написать функцию, которая принимает 2 числа и возвращает меньшее из них.
function firstTask(){
    let num1 = Number(numFirst1.value);
    let num2 = Number(numFirst2.value);
    if (num1 > num2)
        first.innerHTML = num1;
    else if (num2 > num1)
        first.innerHTML = num2;
    else first.innerHTML = "Числа равны";
}


// Написать функцию, которая возводит переданное число в указанную степень.
function secondTask(){
    let num1 = Number(numSecond1.value);
    let degree = Number(numSecond2.value);
    let result =1;
    for(i=1;i<=degree;i++){
        result*=num1;
    }
    second.innerHTML = result;
}


// Написать функцию, которая принимает 2 числа и знак (+ - * /), считает пример и возвращает результат.
function threeTask(){
    let a = Number(numThree1.value);
    let b = Number(numThree2.value);
    switch(numThreeKey.value){
        case "+":
            three.innerHTML=`${a} + ${b} = ${a+b}`;
        break;
        case "-":
            three.innerHTML=`${a} - ${b} = ${a-b}`;
        break;
        case "*":
            three.innerHTML=`${a} * ${b} = ${a*b}`;
        break;
        case "/":
            three.innerHTML=`${a} / ${b} = ${a/b}`;
        break;
        default: three.innerHTML="Введите коректный знак ";
    }
}


// Написать функцию, которая проверяет, является ли переданное ей число простым.
function fourTask(){
    let num = Number(numFour.value);
    let counter = 0;
    if(num==1)
        four.innerHTML="Число не является простым";
    else if(num ==2){
        four.innerHTML="Число является простым";
    }
    else{
    for(let i = 2; i <= num; i++){
        if(num % i == 0)
            counter++;
    }
    if(counter==1)
        four.innerHTML="Число является простым";
    else four.innerHTML="Число не является простым";
    }
}


// Написать функцию, которая принимает число и выводит таблицу умножения для этого числа.
// Вызовите функцию для всех чисел от 2 до 9
function fiveTask(){
    let num = Number(numFive.value);
    let answer ="";
    for (let i=0 ; i<=9;i++){
        answer += `${num} * ${i} = ${num*i}<br>`;
    }
    five.innerHTML = answer;
}


//Написать функцию, которая принимает от 1 до 5 чисел и возвращает их сумму.
function sevenTask(){
    let num1 = Number(numSeven1.value);
    let num2 = Number(numSeven2.value);
    let num3 = Number(numSeven3.value);
    let num4 = Number(numSeven4.value);
    let num5 = Number(numSeven5.value);
    seven.innerHTML = num1+num2+num3+num4+num5;
}