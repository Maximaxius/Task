// A) Напишите код, который сериализует объект `{name: "John", age: 30}` в JSON-строку.
let obj={
    name: "John",
    age: 30
}
let jsonObj = JSON.stringify(obj);
console.log(jsonObj)


// B) Напишите код, который десериализует JSON-строку `{"name": "John", "age": 30}` в объект.
let newObj = JSON.parse(jsonObj)
console.log(newObj)


// C) Создайте объект, содержащий информацию о пользователе (имя, фамилия, возраст и т.д.).
let user = {
    name: "Name",
    lastName: "lastName",
    age: Math.floor(Math.random()*22)
}
console.log(user)


// D) Используя метод JSON.stringify, преобразуйте объект в строку JSON.
user = JSON.stringify(user);
console.log(user)











//F) Преобразуйте строку JSON обратно в объект.
user = JSON.parse(user)
console.log(user)