// a) Напишите функцию, которая принимает два числа в качестве аргументов и возвращает их сумму.
function sum(a,b){
    return a+b;
}
console.log(sum(Math.floor(Math.random()*22),Math.floor(Math.random()*22)));


// b) Напишите функцию, которая принимает массив чисел в качестве аргумента и возвращает среднее значение всех элементов массива.
function arrAvg(arr){
    let res=0;
    for(i in arr){
        res+=i;
    }
    res=res/arr.lengh;
    return res;
}
let arr;
for (let i =0;i<5;i++){
    arr[i]=Math.floor(Math.random()*22);
}
console.log(arr);
console.log(arrAvg(arr));


// c) Напишите функцию, которая принимает на вход число от 1 до 7 и возвращает строку с названием дня недели.
// Если число не входит в диапазон от 1 до 7, функция должна возвращать строку "Неверный день недели".
function dayOfWeek(num){
    switch(num){
        case 1: 
            return "Понедельник";
        break;
        case 2: 
            return "Вторник";
        break;
        case 3: 
            return "Среда";
        break;
        case 4: 
            return "Четверг";
        break;
        case 5: 
            return "Пятница";
        break;
        case 6: 
            return "Суббота";
        break;
        case 7: 
            return "Воскресенье";
        break;
        default: 
            return "Неверный день недели";
        break;
    }
}
console.log(dayOfWeek(Math.floor(Math.random()*8)));


// d) Напишите функцию, которая принимает на вход число и возвращает строку "positive", если число положительное, и "negative", если число отрицательное
function posOrNeg(num){
    if(num>0) return "positive";
    else return "negative";
}
console.log(posOrNeg(Math.floor(-5+Math.random()*(5+5))));


// e) Напишите функцию, которая принимает на вход массив объектов, каждый из которых содержит поля name и age. Функция должна возвращать новый массив, содержащий только тех людей, чей возраст больше 18 лет. Для решения задачи использовать циклы и обращение к полям объектов через точечную нотацию.
function createNewArr(arr){
    let newArr = [];
    for(let i=0,j=0;i<arr.length;i++){
        if(arr[i].age>=18){
            newArr[j]=arr[i];
            j++;
        }
    }
   return newArr
}

let objs=new Array(5);
for(let i=0;i<5;i++){
    objs[i] = {
        name: "name",
        age:Math.floor(Math.random()*100)
    };
}
console.log(objs)
console.log(createNewArr(objs))


// f) Напишите функцию, которая принимает на вход два числа и возвращает наибольшее из них. Если числа равны, функция должна возвращать любое из них.
function smallOrBig(num1,num2){
    if(num1>num2) return num1;
    else if(num1<num2) return num2;
    else return num1
}
console.log(smallOrBig(Math.floor(-5+Math.random()*(5+5))));
