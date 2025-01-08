import React, { useState,useEffect } from "react"; //{useState}

// 1.	Создайте компонент Counter, который отображает счетчик и кнопки "Увеличить" и "Уменьшить".
// Используйте useState для хранения значения счетчика. При нажатии на кнопки счетчик должен увеличиваться или уменьшаться на единицу.
// // Усложнение: при размонтировании (уничтожении/выгрузке) компонента - сохранять состояние в LocalStorage.
// // При монтировании (создании/загрузке) проверять, есть ли там значение и брать его оттуда, если запись имеется в хранилище.

export default function Counter() {
  const [count, setCount] = useState(0);

  const Plus = () => {
    setCount(+count + 1);
  };

  const Minus = () => {
    setCount(+count - 1);
  };

  return (
    <div style={{ marginTop: "30px" }}>
      <button
        style={{ marginRight: "15px" }}
        onClick={Plus}
      >
        Увеличить
      </button>
      {count}
      <button
        style={{ marginLeft: "15px" }}
        onClick={Minus}
      >
        Уменьшить
      </button>
    </div>
  );
}