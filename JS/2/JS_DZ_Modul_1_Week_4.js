//Написать функцию, которая принимает 2 числа и возвращает -1, если первое меньше, чем второе;
// 1 – если первое больше, чем второе; и 0 – если числа равны
function firstTask(){
    let num1 = Number(numFirst1.value);
    let num2 = Number(numFirst2.value);
    if (num1 > num2)
        first.innerHTML = "1";
    else if (num2 > num1)
        first.innerHTML = "-1";
    else first.innerHTML = "0";
}


// Написать функцию, которая вычисляет факториал переданного ей числа.
function secondTask(){
    let num = Number(numSecond1.value);
    let result =1;
    for(i=1;i<=num;i++){
        result*=i;
    }
    second.innerHTML = result;
}


//Написать функцию, которая принимает три отдельные цифры и превращает их в одно число.
// Например: цифры 1, 4, 9 превратятся в число 149.
function threeTask(){
    let num1 = Number(numThree1.value);
    let num2 = Number(numThree2.value);
    let num3 = Number(numThree3.value);
    three.innerHTML = `${num1}${num2}${num3}`
}


// Написать функцию, которая принимает длину и ширину прямоугольника и вычисляет его площадь.
// Если в функцию передали 1 параметр, то она вычисляет площадь квадрата.
function fourTask(){
    let num1 = Number(numFour1.value);
    let num2 = Number(numFour2.value);
    if (num1==0|| num2==0){
        if(num1>num2)
                four.innerHTML="площадь квадрата = " + num1*num1;
        else four.innerHTML="площадь квадрата = " + num2*num2;
    }
    else four.innerHTML="площадь прямоугольника = " + num1*num2 ;
}


// Написать функцию, которая проверяет, является ли переданное ей число совершенным.
// Совершенное число – это число, равное сумме всех своих собственных делителей.
function fiveTask(){
    let num = Number(numFive.value);
    let result = 0;
    for(i=0;i<num;i++){
        if(num%i==0)
        result+=i;
    }
    if(result==num)
        five.innerHTML= "число совершенное" ;
    else five.innerHTML= "число не совершенное" ;
}