// Запросите у пользователя его имя и выведите в ответ:«Привет, его имя!».
function userName(){
    let name=prompt("Введите имя");
    alert('Привет ' + name);
    first.innerHTML = `Привет  ${name}`;
    console.log(`Привет  ${name}`);
}


// Запросите у пользователя год его рождения, посчитайте,сколько ему лет и выведите результат. Текущий год укажите в коде как константу.
function secondTask(){
    const year = 2022;
    let userYear = Number(prompt("Введите ваш год рождения "))
    second.innerHTML = `ВЫ прожили  ${year-userYear}`;
    console.log(`ВЫ прожили  ${year-userYear} лет`);
}


//Запросите у пользователя длину стороны квадрата и выведите периметр такого квадрата.
function threeTask(){
    let userSide = Number(prompt("Введите сторону квадрата "))
    three.innerHTML = `Периметр квадрата =  ${userSide*4}`;
    console.log(`Периметр квадрата =  ${userSide*4}`);
}


//Запросите у пользователя радиус окружности и выведите площадь такой окружности.
function fourTask(){
    let userR = Number(prompt("Введите радиус "))
    four.innerHTML = `Площадь окружности =  ${Math.PI*Math.pow(userR,2)}`;
    console.log(`Площадь окружности =  ${Math.PI*Math.pow(userR,2)}`);
}


// Запросите у пользователя расстояние в км между двумя городами и за сколько часов он хочет добраться.
// Посчитайте скорость, с которой необходимо двигаться, чтобы успеть вовремя
function fiveTask(){
    let userDistance = Number(prompt("Введите расстояние в км"))
    let userHours = Number(prompt("Введите время (ч)"))
    fiveDistance.innerHTML = `${userDistance} км`;
    fiveTime.innerHTML = `${userHours} ч`;
    fiveSpeed.innerHTML = `нужная скорость =  ${userDistance/userHours}`;
    console.log(`нужная скорость =  ${userDistance/userHours}км/ч`);
}


// Реализуйте конвертор валют. Пользователь вводит доллары, программа переводит в евро. Курс валюты храните в константе.
function sixTask(){
    const course = 1.5;
    let userDolr = Number(prompt("Введите доллары"))
    six.innerHTML = `вы получите =  ${userDolr/course}`;
    console.log(`вы получите =  ${userDolr/course}`);
}


// Пользователь указывает объем флешки в Гб. Программа должна посчитать сколько файлов размером в 820 Мб помещается на флешку.
function sevenTask(){
    let userFlash = Number(prompt("Введите объем флешки в Гб"))
    seven.innerHTML = `Поместится =  ${userFlash*1024/820}`;
    console.log(`Поместится =  ${userFlash*1024/820}`);
}


// Пользователь вводит сумму денег в кошельке и цену одной шоколадки.
// Программа выводит сколько шоколадок может купить пользователь и сколько сдачи у него останется.
function eightTask(){
    let userMoney = Number(prompt("Введите свои деньги"))
    let costOneChocholade = Number(prompt("Введите цену одной шоколадки"))
    eightMon.innerHTML = `Было денег  ${userMoney}`;
    eightCho.innerHTML = `Стоит 1 шоколадка ${costOneChocholade}`;
    eightBuy.innerHTML = `Можно купить  ${Math.floor(userMoney/costOneChocholade)}`;
    eightSurrender.innerHTML = `денег осталось  ${userMoney-(Math.floor(userMoney/costOneChocholade)*costOneChocholade)}`;

    console.log(`Можно купить  ${Math.floor(userMoney/costOneChocholade)}`);
    console.log(`денег осталось  ${userMoney-(Math.floor(userMoney/costOneChocholade)*costOneChocholade)}`);
}


// Запросите у пользователя трехзначное число и выведите его задом наперед.
// Для решения задачи вам понадобитс оператор % (остаток от деления).

function eightTask(){
    let userMoney = Number(prompt("Введите свои деньги"))
    let costOneChocholade = Number(prompt("Введите цену одной шоколадки"))
    eightMon.innerHTML = `Было денег  ${userMoney}`;
    eightCho.innerHTML = `Стоит 1 шоколадка ${costOneChocholade}`;
    eightBuy.innerHTML = `Можно купить  ${Math.floor(userMoney/costOneChocholade)}`;
    eightSurrender.innerHTML = `денег осталось  ${userMoney-(Math.floor(userMoney/costOneChocholade)*costOneChocholade)}`;

    console.log(`Можно купить  ${Math.floor(userMoney/costOneChocholade)}`);
    console.log(`денег осталось  ${userMoney-(Math.floor(userMoney/costOneChocholade)*costOneChocholade)}`);
}