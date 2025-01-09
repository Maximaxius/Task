import React, { useState } from "react";
import { styles } from "./styles";


const InputField = ({ onAdd }) => {
  const [newItem, setNewItem] = useState("");

  const handleKeyDown = (event) => {
    if (event.key === "Enter" && newItem !== "") {
      onAdd(newItem);
      setNewItem("");
    }
  };

  return (
    <div  style={styles.inputContainer}>
      <label>Add El:</label>
      <input
        type="text"
        onKeyDown={handleKeyDown}
        onChange={(e) => setNewItem(e.target.value)}
        value={newItem}
        placeholder="..enter value"
      />
    </div>
  );
};

export default InputField;

// В React важно писать событие onChange в поле ввода input, потому что это позволяет реактивно обновлять значение
// состояния компонента при каждом изменении текста в поле ввода. Это позволяет
// создавать динамические формы, которые могут реагировать на ввод пользователя в реальном времени.

// Также, использование события onChange вместо события onClick позволяет получать измененное
// значение поля ввода до того, как пользователь нажмет на кнопку "Отправить" или "Сохранить".
// Это делает работу с формами более эффективной и удобной для пользователей.
