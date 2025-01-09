import "../../components/App/App.css";

import React, { useState, useEffect} from "react";
import WriterList from "./WriterList";
import InputFieldAdd from "../Input/InputFieldAdd";
import InputFieldDel from "../Input/InputFieldDel";

import {
  randNumber,
  names,
  surnames,
} from "../../utils/random_generator";

// A. Создать компонент `List` для отображения списка элементов из массива. 
// Каждый элемент должен быть отображен в виде отдельного компонента `ListItem`, который будет получать данные из массива через `props`. 
// Добавить возможность удаления элементов из списка с помощью поля ввода,
//  которое позволяет указать порядковый номер эл-та и после нажатия на кнопку произведёт удаление эл-та,
//   что приведёт к обновлению компонента `List`



const writers = Array.from({ length: 5 }, () => ({
  name: names[randNumber(0, names.length)],
  lastName: surnames[randNumber(0, surnames.length)],
}));

const Writers = () => {
  const [list, setList] = useState(writers);

  // useEffect(() => {
  //   for (let i = 0; i < 5; i++) {
  //     const name = names[randNumber(0, names.length)];
  //     const surname = surnames[randNumber(0, surnames.length)];
  //     AddToArray(`${name} ${surname}`);
  //   }
  //   console.log("Component has mounted!");
  // }, []);

  const AddToArray = (newItem) => {
    let [name, lastName] = newItem.split(" ");

    setList((list) => [
      ...list,
      {
        name: name,
        lastName: lastName,
      },
    ]);
  };

  const RemoveFromArr = (item) => {
    const id = item;
    
    setList((list) =>
      list.filter(
        (_,index) => index != id
      )
    );
  };

  return (
    <div className="App"> 
      <WriterList data={list} />
      <InputFieldAdd onAdd={AddToArray}/>
      <InputFieldDel onDel={RemoveFromArr} />
    </div>
  );
};

export default Writers;
