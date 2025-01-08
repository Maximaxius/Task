import "./App.css";

import Counter from "../Counter";
import Toggle from "../Toggle";
import InputField from "../InputField";
import Сountdown from "../Сountdown";
import LocalStorage from "../LocalStorage";
import MousePosition from "../MousePosition";
import React, { useState } from "react";

function App() {
  const [counter, setCounter] = useState(0);

  const leftClick = () => {
    setCounter(counter+1);
  }
  const rightClick = (e) => {
    e.preventDefault();
    setCounter(counter - 1);
  };


  return (
    <div className="App">
      {/* 7.	Добавьте кнопку с использованием условного рендеринга в главном компоненте App,
       которая позволит скрывать/показывать каждое из вышеупомянутых заданий отдельно от друг друга. */}
      <button 
        style={{ marginTop: "30px" }}
        onClick={leftClick}
        onContextMenu={rightClick}
      > Вывести на экран следующую таску</button>
      {counter > 0 ? <Counter /> : null}{" "}
      {counter > 1 ? <Toggle /> : null}{" "}
      {counter > 2 ? <InputField /> : null}{" "}
      {counter > 3 ? <Сountdown /> : null}{" "}
      {counter > 4 ? <LocalStorage /> : null}{" "}
      {counter > 5 ? < MousePosition/> : null}{" "}

    </div>
  );
}

export default App;