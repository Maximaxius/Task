import React, { useState } from "react";
import { styles } from "./styles";

const InputField = ({ onAdd }) => {
    
  const [addname, setNewname] = useState("");
  const [addLastName, setLastName] = useState("");
  const [addage, setNewAge] = useState("");
  const [addEmail, setNewEmail] = useState("");

  const handleClick = () => {
    onAdd({
        name: addname.length>=1 ? addname : "-",
        lastName: addLastName.length>=1 ? addname : "-",
        age: addage.length>=1 ? addname : "-",
        email: addEmail.length>=1 ? addname : "-"
    })
    setNewname("");
    setLastName("");
    setNewAge("");
    setNewEmail("");
  };

  return (
    <div style={styles.inputContainer}>
      <button onClick={handleClick}>add</button>
      <input 
        type="text"
        value={addname} 
        onChange={(e) => setNewname(e.target.value)}    
        placeholder="..enter name" />

        <input 
        type="text"
        value={addLastName} 
        onChange={(e) => setLastName(e.target.value)}
        placeholder="..enter lastName" />

         <input 
        type="text"
        value={addage} 
        onChange={(e) => setNewAge(e.target.value)}
        placeholder="..enter age" />

         <input 
        type="text"
        value={addEmail} 
        onChange={(e) => setNewEmail(e.target.value)}
        placeholder="..enter email" />

    </div>
  );
};

export default InputField;