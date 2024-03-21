//Подсчитать сумму всех чисел в заданном пользователем диапазоне.
function firstTask(){
    let num1 = Number(numFirst1.value);
    let num2 = Number(numFirst2.value);
    let result=0;
    if (num1 <num2){
        for(;num1<num2;num1++){
            result+=num1;
        }
    }
    else for(;num1>num2;num2++){
        result+=num2;
    }
    first.innerHTML = result;
}


//Запросить у пользователя число и вывести все делители этого числа.
function threeTask(){
    let num = Number(numThree.value);
    let answer ="";
    for(let i=1;i<=num;i++){
        if(num%i==0 && i!=num)
            answer+=`${i}, `
        else if (i==num) answer+=i;
    }
    three.innerHTML = answer;
}


// Определить количество цифр в введенном числе
function fourTask(){
    let num = Number(numFour.value);
    let count = 0;
    while(num > 0){
        count++;
        num=Math.floor(num/10);
    }
    four.innerHTML=count;
}


// Запросить у пользователя 10 чисел и подсчитать, сколько он ввел положительных, отрицательных и нулей.
// При этом также посчитать, сколько четных и нечетных. Вывести статистику на экран.
// Учтите, что достаточно одной переменной (не 10) для ввода чисел пользователем.
function fiveTask(){
    let num1 = Number(numFive1.value);
    let num2 = Number(numFive2.value);
    let num3 = Number(numFive3.value);
    let num4 = Number(numFive4.value);
    let num5 = Number(numFive5.value);
    let num6 = Number(numFive6.value);
    let num7 = Number(numFive7.value);
    let num8 = Number(numFive8.value);
    let num9 = Number(numFive9.value);
    let num10 = Number(numFive10.value);
    let even=0;
    let odd =0;
    let plus =0;
    let minus =0;
    let zero =0;
    if (num1%2==0)
        even++;
    else odd++;
    if(num1>0)
        plus++;
    else if (num1<0)
        minus++;
    else zero++;
    
    if (num2%2==0)
        even++;
    else odd++;
    if(num2>0)
        plus++;
    else if (num2<0)
        minus++;
    else zero++;
    
    if (num3%2==0)
        even++;
    else odd++;
    if(num3>0)
        plus++;
    else if (num3<0)
        minus++;
    else zero++;

    if (num4%2==0)
        even++;
    else odd++;
    if(num4>0)
        plus++;
    else if (num4<0)
        minus++;
    else zero++;

    if (num5%2==0)
        even++;
    else odd++;
    if(num5>0)
        plus++;
    else if (num5<0)
        minus++;
    else zero++;

    if (num6%2==0)
        even++;
    else odd++;
    if(num6>0)
        plus++;
    else if (num6<0)
        minus++;
    else zero++;

    if (num7%2==0)
        even++;
    else odd++;
    if(num7>0)
        plus++;
    else if (num7<0)
        minus++;
    else zero++;

    if (num8%2==0)
        even++;
    else odd++;
    if(num8>0)
        plus++;
    else if (num8<0)
        minus++;
    else zero++;

    if (num9%2==0)
        even++;
    else odd++;
    if(num9>0)
        plus++;
    else if (num9<0)
        minus++;
    else zero++;

    if (num10%2==0)
        even++;
    else odd++;
    if(num10>0)
        plus++;
    else if (num10<0)
        minus++;
    else zero++;
    five.innerHTML = `положительных ${plus}; отрицательных ${minus}; четных ${even}; нечетных ${odd}; нулей${zero}`;
}


// Вывести таблицу умножения для всех чисел от 2 до 9. Каждое число необходимо умножить на числа от 1 до 10.
function nineTask(){
    let answer ="<br>";
    for (let i=2;i<=9;i++){
        for(let j=0;j<=10;j++){
            answer += `${j}*${i}=${j*i}       `;
        }
        answer+=`<br><br>`;
    }
    nine.innerHTML = answer;
}
