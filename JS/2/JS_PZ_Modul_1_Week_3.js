// Вывести # столько раз, сколько указал пользователь.
function firstTask(){
    let num = Number(numFirst.value);
    let answer ="";
    let i=0;
    while(i<num){
        i++;
        answer+= "#";
    }
    first.innerHTML = answer;
}


// Пользователь ввел число, а на экран вывелись все числа от введенного до 0
function secondTask(){
    let num = Number(numSecond.value);
    let answer ="";
    while(num>0){
        num--;
        answer+= `${num} `;
    }
    second.innerHTML = answer;
}


// Запросить число и степень. Возвести число в указанную степень и вывести результат.
function threeTask(){
    let num = Number(numThree1.value);
    let degree = Number(numThree2.value);
    let i=0;
    let result=1;
    while(degree>=i){
        i++;
        result*=num;
    }
    three.innerHTML = result;
}


// Предлагать пользователю решить пример 2 + 2 * 2 до тех пор, пока он не решит его правильно.
function sixTask(){
    let num ;
    do {
        num = Number(prompt("Введите ответ для примера 2+2*2:"))
    }
    while (num!=6);
    six.innerHTML = "Вы решили правильно";
}


//Делить число 1000 на 2 до тех пор, пока не получится число меньше 50. Вывести это число и сколько делений произвели.
function sevenTask(){
    let count=0;
    let num=1000;
    do {
        count++;
        num = num/2;
    }
    while (num>=50);
    seven.innerHTML =`${num}  делилось ${count} раз `;
}


// Вывести все числа от 1 до 100, которые кратные указанному пользователем числу.
function eightTask(){
    let num = Number(numEight.value);
    let answer ="";
    for(let i=1;i<100;i++){
        if(i%num==0)
            answer+= `${i}, `
    }
    eight.innerHTML = answer
}


//Вывести каждый 4-й элемент из указанного пользователем диапазона.
// Пользователь указывает минимальное и максимальное значения диапазона.
function nineTask(){
    let start = Number(numNine1.value);
    let end = Number(numNine2.value);
    let answer="";
    for(let i=0;start<end;start++,i++){
        if(i%4==0)
            answer+=`${start} `;
    }
    nine.innerHTML=answer;
}