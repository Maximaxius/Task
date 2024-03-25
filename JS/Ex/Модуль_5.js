// a) Создайте объект с информацией о человеке: имя, возраст, место жительства. Напишите код, который выведет на консоль всю информацию о человеке.
let human = {
    name: "Mikita",
    age:23,
    location:"K.Marksa 32"
};
console.log(human)


// b) Создайте объект с информацией о продукте: название, цена, количество. Напишите код, который выведет на консоль название продукта и его стоимость.
let product = {
    name: "JS course",
    price:Math.floor(Math.random()*22),
    quantity:Math.floor(Math.random()*22)
};
console.log(`${product.name} ${product.price}`)


// c) Создайте объект с информацией о книге: название, автор, год издания. Напишите код, который выведет на консоль информацию
// о книге в формате "Название книги - Автор (Год издания)".
let book = {
    name: "JS course",
    author:"Anton",
    year:Math.floor(2000+Math.random()*(2077-2000))
};
console.log(`${book.name} - ${book.author} (${book.year})`)

// d) На основе одного из заданий выше сгенерируйте массив подобных объектов, а затем найди среднее арифметическое одного из числовых значений среди всех объектов в массиве.
let products=new Array();
for(let i=0;i<5;i++){
    products[i] = {
        name: "JS course",
        price:Math.floor(Math.random()*22),
        quantity:Math.floor(Math.random()*22)
    };
}
let res=0;
for(let i=0;i<products.length;i++){
    res+=products[i].price   
}
console.log(res/products.length)


// e) Напишите цикл, который выводит в консоль все ключи объекта obj.
let product = {
    name: "JS course",
    price:Math.floor(Math.random()*22),
    quantity:Math.floor(Math.random()*22)
};
for(let keys in product){
    console.log(keys);
}



// F) Создайте объект "book" с свойствами "title", "author", "year" и "genre". Значения свойств могут быть любыми.7.
// - Создайте массив "library", который будет содержать несколько объектов "book".
// - Создайте функцию "searchByGenre", которая будет принимать на вход жанр книги и искать все книги в массиве "library" с этим жанром.
// Функция должна выводить в консоль только названия книг с этим жанром.
// - Создайте функцию "searchByAuthor", которая будет принимать на вход автора книги и искать все книги в массиве "library" этого автора.
// Функция должна выводить в консоль только названия книг этого автора.
const genres=["info","action","music","history"]
const authors=["Anton","ivan","Maksim","Kostia"]
const alphabetSmall = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
const alphaberBig = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
function createName(){    
    let name=""
    for(let i=0;i<Math.random()*(13-5)+5;i++){
        if(i==0)
            name+= alphaberBig[Math.floor(Math.random() * alphaberBig.length)]
        name+= alphabetSmall[Math.floor(Math.random() * alphabetSmall.length)]
    }
    return name;
}

let book = {
    name: "JS course",
    author:authors[Math.floor(Math.random()*4)],
    year:Math.floor(2000+Math.random()*(2077-2000)),
    genre: genres[Math.floor(Math.random()*4)]
};

let library = [];
for(let i=0;i<Math.floor(Math.random()*(10-5)+5);i++){
    library.push({
        name: createName(),
        author:authors[Math.floor(Math.random()*4)],
        year:Math.floor(2000+Math.random()*(2077-2000)),
        genre: genres[Math.floor(Math.random()*4)]});
}

function searchByGenre(genre){
    for(let i=0;i<library.length;i++){
        if(library[i].genre==genre)
            console.log(library[i].name)
    }
}

function searchByAuthor(author){
    for(let i=0;i<library.length;i++){
        if(library[i].author==author)
            console.log(library[i].name)
    }
}

console.log(library);
searchByAuthor("Anton");
searchByGenre("info");