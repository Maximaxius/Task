import React, { useState } from "react";
import { styles } from "./styles";


const InputField = ({ onDel }) => {
  const [delItem, setNewItem] = useState("");

  const handleClick = () => {
    onDel(delItem);
    setNewItem("");
  };

  return (
    <div style={styles.inputContainer}>
      <button onClick={handleClick}>del</button>
      <input 
        type="text"
        value={delItem} 
        onChange={(e) => setNewItem(e.target.value)}
        placeholder="..enter value" />
    </div>
  );
};

export default InputField;