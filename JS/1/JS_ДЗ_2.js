// Запросить у пользователя его возраст и определить, кем он является: ребенком (0–2), подростком (12–18),
// взрослым (18_60) или пенсионером (60– ...).
function firstTask(){
    let num = Number(numFirst.value);
    if (num >= 0 && num <= 12)
        first.innerHTML="Ребенок";
    else if(num >= 12 && num <= 18)    
        first.innerHTML="подросток";
    else if (num > 18 && num <= 60)    
        first.innerHTML="взрослым";
    else first.innerHTML="пенсионер";
}


//Запросить у пользователя число от 0 до 9 и вывести ему спецсимвол, который расположен на этой клавише (1–!,2–@, 3–# и т. д)
function secondTask(){
    let num = Number(numSecond.value);
    switch(numSecond.value){
        case "0":
            second.innerHTML=")";
        break;
        case "1":
            second.innerHTML="!";
        break;
        case "2":
            second.innerHTML="@";
        break;
        case "3":
            second.innerHTML="#";
        break;
        case "4":
            second.innerHTML="$";
        break;
        case "5":
            second.innerHTML="%";
        break;
        case "6":
            second.innerHTML="^";
        break;
        case "7":
            second.innerHTML="&";
        break;
        case "8":
            second.innerHTML="*";
        break;
        case "9":
            second.innerHTML="(";
        break;
        default: second.innerHTML="Введите коректное число"            
    }
}


//Запросить у пользователя трехзначное и число и проверить, есть ли в нем одинаковые цифры.
function threeTask(){
    let userNum = Number(numThree.value);
    if(Number(userNum) >= 100 && Number(userNum) <= 999){
        let hundred = Math.floor(Number(userNum)/100);
        let tenth =  Math.floor(Number(userNum)/10 - hundred*10);
        let one = userNum-hundred*100-tenth*10;
        console.log(one);
        if(hundred==tenth || tenth==one || hundred==one){
            three.innerHTML="Есть одинаковые";}
        else three.innerHTML="Одинаковых нету";
    }
}


//Запросить у пользователя год и проверить, високосный он или нет.
//Високосный год либо кратен 400, либо кратен 4 и при этом не кратен 100.
function fourTask(){
    let userYear = Number(numFour.value);
    if ((userYear%100!=0 && userYear%4==0) || userYear%400==0){
        four.innerHTML="Високосный";
    }
    else  four.innerHTML="Не високосный";
}


//6 Написать конвертор валют. Пользователь вводит количество USD, выбирает, в какую валюту хочет перевести:
// EUR, UAN или AZN, и получает в ответ соответствующую сумму.
function sixTask(){
    let userMoney = Number(numSix.value);
    let key = Number(keySix.value);
    switch(keySix.value){
        case"1":
            six.innerHTML=userMoney*1.5;
        break;
        case"2":
            six.innerHTML=userMoney*0.9;
        break;
        case"3":
            six.innerHTML=userMoney*1.1;
        break;
        default: six.innerHTML="Введите корректный ключ";
    }
}


// Запросить у пользователя сумму покупки и вывести сумму к оплате со скидкой:
// от 200 до 300 – скидка будет 3%, от 300 до 500 – 5%, от 500 и выше – 7%.
function sevenTask(){
    let userMoney = Number(numSeven.value);
    if(userMoney > 200 && userMoney <= 300)
        seven.innerHTML = userMoney-(userMoney/100*3);
    else if (userMoney > 300 && userMoney <= 500)
        seven.innerHTML = userMoney-(userMoney/100*5);
    else if (userMoney > 500)
        seven.innerHTML = userMoney-(userMoney/100*7);
    else seven.innerHTML = userMoney;
}
