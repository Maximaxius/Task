import "../../components/App/App.css";

import React, { useState} from "react";
import UserList from "./UserList";
import InputFieldAdd from "../Input/InputFieldAdd";
import InputFieldAdd3 from "../Input/InputFieldAdd3";

import {
  randNumber,
  names,
  surnames,
} from "../../utils/random_generator";

// B. Создайте компонент для отображения списка пользователей. 
// Каждый пользователь представлен объектом со следующими свойствами: имя (name), фамилия (surname), возраст (age) и email. 
// Компонент должен принимать массив объектов пользователей в качестве свойства (props) и отображать их в виде списка,
//  где каждый элемент списка содержит информацию о пользователе в формате "Имя Фамилия, возраст, email". 
// Каждый элемент списка должен быть представлен отдельным компонентом, который принимает объект пользователя в качестве
//  свойства (props) и отображает его свойства в соответствующем формате. 
// Реализуйте возможность добавлять новых пользователей в список с использованием:
// •	Трёх отдельных input
// •	Одного input, где св-ва задаются через запятую


const users = Array.from({ length: 5 }, () => ({
  name: names[randNumber(0, names.length)],
  lastName: surnames[randNumber(0, surnames.length)],
  age: `${randNumber(13,99)}`,
  email: ` `
}));

users.map((item) => (
  item.email = `${item.name}@email.com`                     //кривое маил имя чтобы первые были +-правдоподобные
))

const Users = () => {
  const [user, setUser] = useState(users);

  const AddToArray = (newItem) => {
    let [name="-", lastName="-",age="-",email="-"] = newItem.split(",");

    setUser((user) => [
      ...user,
      {
        name: name,
        lastName: lastName,
        age: `${age}`,
        email: email
      },
    ]);
  };

  const AddToArray3 = (newItem) => {
    setUser((user) => [
      ...user,
      newItem
    ]);
  };

  return (
    <div className="App"> 
      <UserList data={user} />
      <InputFieldAdd onAdd={AddToArray}/>
      <InputFieldAdd3 onAdd={AddToArray3}/>
    </div>
  );
};

export default Users;
