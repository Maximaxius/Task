//Создать объект, описывающий автомобиль (производитель,модель, год выпуска, средняя скорость),
// и следующие функции для работы с этим объектом.
// 1. Функция для вывода на экран информации об автомобиле.
// 2. Функция для подсчета необходимого времени для преодоления переданного расстояния со средней скоростью.
//     Учтите, что через каждые 4 часа дороги водителю необходимо делать перерыв на 1 час.
let car ;
function createCar(){
    car ={
        manufacturer : manufacturer.value,
        model:model.value,
        year:year.value,
        avgSpeed:avgSpeed.value
    }
}

function showCar(){
    let answer=`<br> производитель ${car.manufacturer} <br>  модель ${car.model} <br> год выпуска ${car.year} <br> средняя скорость ${car.avgSpeed} <br>`;
    show.innerHTML= answer;
}

let distances
function mathCar(){
    distances = Number(distance.value);
    let hour = 0;
    while(distances>car.avgSpeed){
        hour++;
        if(hour%4==0)
            hour++;
        distances-=car.avgSpeed;
    }
    math.innerHTML= `нужно ехать ${hour} ч`;
}


// Задание 2
// Создать объект, хранящий в себе отдельно числитель и знаменатель дроби, и следующие функции для работы с этим объектом.
// 1. Функция сложения 2-х объектов-дробей.
// 2. Функция вычитания 2-х объектов-дробей.
// 3. Функция умножения 2-х объектов-дробей.
// 4. Функция деления 2-х объектов-дробей.
// 5. Функция сокращения объекта-дроби.
let fraction1;
let fraction2;
function createFirstFraction(){
    fraction1 = {
        numerator: Number(numerator1.value),
        denominator: Number(denominator1.value)
    }
}

function createSecondFraction(){
    fraction2 = {
        numerator: Number(numerator2.value),
        denominator: Number(denominator2.value)
    }
}

function plusFraction(){
    if(fraction1.denominator==fraction2.denominator)
        showPlus.innerHTML =`${fraction1.numerator+fraction2.numerator}/${fraction1.denominator}`
    else showPlus.innerHTML =`${fraction1.numerator*fraction2.denominator+fraction1.denominator*fraction2.numerator}/${fraction1.denominator*fraction2.denominator}`
}

function minusFraction(){
    if(fraction1.denominator==fraction2.denominator)
        showMinus.innerHTML =`${fraction1.numerator-fraction2.numerator}/${fraction1.denominator}`
    else showMinus.innerHTML =`${fraction1.numerator*fraction2.denominator-fraction1.denominator*fraction2.numerator}/${fraction1.denominator*fraction2.denominator}`
}

function multiplicationFraction(){
    if(fraction1.denominator==fraction2.denominator)
        showMultiplication.innerHTML =`${fraction1.numerator*fraction2.numerator}/${fraction1.denominator}`
    else showMultiplication.innerHTML =`${fraction1.numerator*fraction2.numerator}/${fraction1.denominator*fraction2.denominator}`
}

function divisionFraction(){
    showDivision.innerHTML =`${fraction1.numerator*fraction2.denominator}/${fraction1.denominator*fraction2.numerator}`
}

function cutsFraction(){
    for (let i = fraction1.numerator; i >= 1; i--) {
        if (fraction1.numerator % i == 0 && fraction1.denominator % i == 0) {
            fraction1.numerator = fraction1.numerator / i;
            fraction1.denominator = fraction1.denominator / i;
        }
    }
    showCut.innerHTML = `${fraction1.numerator}/${fraction1.denominator}`
}