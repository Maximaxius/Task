// Создать массив из 10 случайных чисел и написать несколько функций для работы с ним.
let arr =new Array();
function creatArr(){
    if(arr.length<10){
        for (let i=0;i<10;i++){
            arr.push(Math.floor(Math.random()*22))
        }
    }
}


// 1. Функция принимает массив и выводит его на экран.
function showArr(){
    show.innerHTML=" "
    for(i in arr){
        show.innerHTML +=`${arr[i]} `
    }
}

// 2. Функция принимает массив и выводит только четные элементы.
function showArrEven(){
    showEven.innerHTML="Четные  "
    for (let i=0;i<arr.length;i++){
        if(i%2==0)
        showEven.innerHTML += arr[i]+" ";
    }
}


// Функция принимает массив и возвращает сумму всех элементов массива.
function showArrSumm(){
    showSumm.innerHTML="Cумма "
    let answer=0;
    for (let i=0;i<arr.length;i++){
        answer += arr[i];
    }
    showSumm.innerHTML += answer;
}


// Функция принимает массив и возвращает его максимальный элемент.
function showArrMax(){
    showMax.innerHTML="максимальный элемент "
    let answer=0;
    for (let i=0;i<arr.length;i++){
        if(answer<arr[i])
            answer=Number(arr[i]);
    }
    showMax.innerHTML += answer;
}


// Функция добавления нового элемента в массив по указанному индексу.
function showArrPushNew(){
    arr.splice(newEl.value, 0, Math.floor(Math.random()*22))
    showArr()
}


// 6. Функция удаления элемента из массива по указанному индексу.
function showArrDellEL(){
    arr.splice(delEl.value, 1)
    showArr()
}

// Создать еще один массив из 5 случайных чисел и написать следующие функции.
let arr2 =new Array();
function creatArr2(){
    if(arr2.length<5){
        for (let i=0;i<5;i++){
            arr2.push(Math.floor(Math.random()*22))
        }
    }
}

function showArr2(){
    show2.innerHTML=" "
    for(i in arr2){
        show2.innerHTML +=`${arr2[i]} `
    }
}

// 1. Функция принимает 2 массива и возвращает новый массив, в котором собраны все элементы из двух массивов без повторений.
function createNewArr(){
    let newArr=arr.concat(arr2);

    for(let i=0;i<newArr.length;i++){
        let count=0;
        for(let j=0;j<newArr.length;j++){
            if(newArr[i]==newArr[j])
                count++;
        }
        if(count>1){
            newArr.splice(i, 1)
        }
    }

    showNewArr.innerHTML=" "
    for(i in newArr){
        showNewArr.innerHTML +=`${newArr[i]} `
    }

}

// Функция принимает 2 массива и возвращает новый массив,в котором собраны общие элементы
//  (то есть элементы,которые встречаются и в первом и во втором массивах) без повторений.
function createNewArr2(){
    let newArr= new Array;

    for(let i=0;i<arr.length;i++){
        for(let j=0;j<arr2.length;j++){
            if(arr[i]==arr2[j])
            newArr.push(arr[i]);
        }
    }

    for(let i=0;i<newArr.length;i++){
        let count=0;
        for(let j=0;j<newArr.length;j++){
            if(newArr[i]==newArr[j])
                count++;
        }
        if(count>1){
            newArr.splice(i, 1)
        }
    }

    showNewArr2.innerHTML=" "
    for(i in newArr){
        showNewArr2.innerHTML +=`${newArr[i]} `
    }

}


// 3. Функция принимает 2 массива и возвращает новый массив, в котором собраны все элементы из первого массива,
// которых нет во втором массиве.
function createNewArr3(){
    let newArr= new Array;

    for(let i=0;i<arr.length;i++){
        let count =0;
        for(let j=0;j<arr2.length;j++){
            if(arr[i]!=arr2[j])
            count++            
        }
        if(count==arr2.length)
        newArr.push(arr[i]);
    }

    showNewArr3.innerHTML=" "
    for(i in newArr){
        showNewArr3.innerHTML +=`${newArr[i]} `
    }

}