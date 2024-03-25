//a) Создайте массив чисел [1, 2, 3, 4, 5]. Напишите код, который выведет на консоль сумму всех элементов массива.
let arr = [1,2,3,4,5]
let sum=0;
for(let i = 0;i<arr.length;i++)
    sum+=arr[i];
console.log(sum)


//b) Создайте массив строк ["яблоко", "банан", "груша", "апельсин"]. Напишите код, который выведет на консоль длину каждой строки в массиве.
let arr = ["яблоко", "банан", "груша", "апельсин"]
for(let i = 0;i<arr.length;i++)
    console.log(arr[i].length);


//c) Создайте массив чисел [1, 2, 3, 4, 5]. Напишите код, который выведет на консоль только четные элементы массива.
let arr = [1,2,3,4,5]
for(let i = 0;i<arr.length;i++)
    if(arr[i]%2==0)
        console.log(arr[i])


//d) Напишите цикл, который выводит в консоль только элементы массива arr, которые являются числами.
let arr = ["word",1,13,"js",22,"step"]
for(let i = 0;i<arr.length;i++)
    if(Number(arr[i]))
        console.log(arr[i])


//e) Создайте массив из 7 строковых значений. Используя метод join, объедините все элементы массива в одну строку и выведите ее в консоль.
let arr = ["word","js","step","lorem","c++","Rocket Raccoon","I am Groot"]
console.log(arr.join(" "));


//f) Создайте массив из 8 чисел. Используя метод reduce, найдите сумму всех элементов массива и выведите ее в консоль.
let arr =[];
for(let i = 0;i<8;i++)
    arr[i]=Math.floor(Math.random()*22);
console.log(arr)
let result =arr.reduce((sum,cur) => sum+cur,0)
console.log(result)

// g) Создайте массив из 9 чисел. Используя метод slice, скопируйте первые 5 элементов массива в новый массив и выведите его в консоль.
let arr =[];
for(let i = 0;i<8;i++)
    arr[i]=Math.floor(Math.random()*22);
console.log(arr)
let result =arr.slice(0,5)
console.log(result)