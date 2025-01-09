import "../../components/App/App.css";

import React, { useState} from "react";
import NumList from "./NumList";
import InputFieldFromTo from "../Input/InputFieldFromToWindow";

import {randNumber,randomColor} from "../../utils/random_generator";

// C. Генератор чисел с фичами:
// 1.	Генерация числа в заданном диапазоне
// 2.	Генерация N чисел в заданном диапазоне
// 3.	Генерация N чисел с сортировкой 
// Визуализация-вдохновение ниже — главное, чтобы генерируемые числа были отдельными компонентами
//  в виде квадратов с закруглёнными краями и с рандомными оттенками.

const number = Array({ length: 1 }, () => ({
  num: 0,
  color:""
}));

const Number = () => {
  const [numbers, setNumbers] = useState(number);

  const AddToArray = (from,to,times,sort) => {
    setNumbers([
      {
        num: null,
        color: null
      },
    ]);

    for(let i=0;i<+times;i++){
      setNumbers((numbers) => [
        ...numbers,
        {
          num: randNumber(+from,+to),
          color: randomColor()
        },
      ]);
    }
    
    if(sort){
      setNumbers((numbers) =>
        numbers.sort(function(a, b) { return a.num - b.num})      //заменить на стрелочную  хотя работает модно не трогать 
      );
    }
  };


  return (
    <div className="App" style={{display:"flex"}}> 
      <InputFieldFromTo fromTo={AddToArray}/>
      <NumList data={numbers} />
    </div>
  );
};

export default Number;
