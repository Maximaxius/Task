import React, { useState } from "react"; 
// 2.	Создайте компонент Toggle, который отображает кнопку "Включить/Выключить".
// Используйте useState для хранения состояния переключателя.
// При нажатии на кнопку состояние должно меняться между true и false,
// а текст на кнопке должен соответствующим образом меняться.

export default function Toggle() {
  const [toggle, setToggle] = useState(true);

  const Change = () => {
    let forChange=toggle;                                   //смог только с созданием новой переменной тк toggle константа
    setToggle(forChange === true ? forChange=false : forChange=true)
  };

  return (
    <div style={{ marginTop: "30px" }}>

      <button onClick={Change}>
        {toggle === true ? "Выключить" : "Включить"}
      </button>

    </div>
  );
}