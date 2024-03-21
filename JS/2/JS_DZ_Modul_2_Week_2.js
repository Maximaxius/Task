// Создать массив «Список покупок». Каждый элемент массива является объектом, который содержит название продукта,
//  необходимое количество и куплен или нет. Написать несколько функций для работы с таким массивом.
let list =[] ;
function pushList(){
    let index =0;
    let choose =false;
    for(i in list){
        if(list[i].nameProduct==nameProduct.value){
            index=i;
            choose=true;
        }        
    }
    
    if(choose){
        list[index].amount+=Number(amount.value)
    }
    else
    list.push({
        nameProduct: nameProduct.value,
        amount: Number(amount.value),
        bought: bought.checked ? "yes" : "no"  //bought.value //bought.checked ? "yes" : "no"
    })
    
}


// 1. Вывод всего списка на экран таким образом, чтобы сначала шли некупленные продукты, а потом – купленные.
function showList(){
    show.innerHTML=" "
    for(let i=0;i<list.length;i++){
        if(list[i].bought=="yes")
        show.innerHTML +=`${i} name ${list[i].nameProduct} количество ${list[i].amount} куплен ${list[i].bought} <br>`
    }
    for(let i=0;i<list.length;i++){
        if(list[i].bought=="no")
        show.innerHTML +=`${i} name ${list[i].nameProduct} количество ${list[i].amount} куплен ${list[i].bought} <br>`
    }

}

// 3. Покупка продукта. Функция принимает название продукта и отмечает его как купленный
function buyProduct(){
    for(i in list){
        if(list[i].nameProduct==nameProductForBuy.value){
            list[i].bought="yes";
        }        
    }
    showList()
}



// Создать массив, описывающий чек в магазине. Каждый элемент массива состоит из названия товара, количества и цены за
// единицу товара. Написать следующие функции.
let list2 =[] ;
function pushList2(){
    list2.push({
        nameProduct: nameProduct2.value,
        amount: Number(amount2.value),
        price: Number(price.value)
    })
    
}


// 1. Распечатка чека на экран
function showList2(){
    show2.innerHTML=" "
    for(let i=0;i<list2.length;i++){
        show2.innerHTML +=`${i} name ${list2[i].nameProduct} количество ${list2[i].amount} цены ${list2[i].price} <br>`
    }
}

// 2.Подсчет общей суммы покупки.
function showList2FullPrice(){
    show2FullPrice.innerHTML=""
    let answer =0;
    for(let i=0;i<list2.length;i++){
        answer += Number(list2[i].price*list2[i].amount)
    }
    show2FullPrice.innerHTML=answer
}


// 3.Получение самой дорогой покупки в чеке.
function showList2MaxPrixe(){
    show2MaxPrixe.innerHTML=""
    let answer =0;
    for(let i=0;i<list2.length;i++){
        if(answer<=list2[i].price*list2[i].amount){            
            answer = Number(list2[i].price*list2[i].amount)
        }        
    }
    show2MaxPrixe.innerHTML=answer
}


// 4.Подсчет средней стоимости одного товара в чеке.
function showList2AvgPrixe(){
    show2AvgPrixe.innerHTML=""
    let avgAmount =0;
    let avgPrice = 0;
    for(let i=0;i<list2.length;i++){
        avgPrice +=Number(list2[i].price*list2[i].amount)
        avgAmount +=Number(list2[i].amount)
    }
    show2AvgPrixe.innerHTML=`${avgPrice/avgAmount}`
}