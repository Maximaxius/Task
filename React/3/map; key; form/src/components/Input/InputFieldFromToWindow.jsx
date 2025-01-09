import React, { useState } from "react";
import { styles } from "./styles";

const InputField = ({ fromTo }) => {
    
  const [from, setFrom] = useState(1);
  const [to, setTo] = useState(10);
  const [times, setTImes] = useState(1);
  const [sort,setSort] = useState(false);

  const handleClick = () => {
    fromTo(from,to,times,sort)
    setFrom("");
    setTo("");
    setTImes("");
  };

  return (
    
    <div style={styles.generatoeWin}>
      <p>Генератор случайных чисел, рандомайзер</p>
      <p>В диапазоне</p>
      
      <div style={{ display: "flex", alignItems: "center"}}>
        <p style={{paddingRight: "10px"}}>От</p>
        <input
          type="text"
          value={from} 
          onChange={(e) => setFrom(e.target.value)}    
          placeholder="..enter from" />
        <p style={{paddingLeft: "10px",paddingRight: "10px"}}>До</p>
        <input 
          type="text"
          value={to} 
          onChange={(e) => setTo(e.target.value)}
          placeholder="..enter to" />
      </div>

      <p>Получить</p>
      <div style={{ display: "flex", alignItems: "center"}}>
        <input
          type="text"
          value={times} 
          onChange={(e) => setTImes(e.target.value)}    
          placeholder="количество" />
        <p style={{paddingLeft: "10px",paddingRight: "10px"}}>Число</p>
      </div>

      <div style={{ display: "flex", alignItems: "center"}}>
      <p>Сортировать результаты по порядку</p>
      <input
          className="forSort"
          type="checkbox"
          value={sort} 
          onChange={(e) => setSort(sort==true ? false : true)} />
      </div>
      
      <button onClick={handleClick}>add</button>

    </div>
  );
};

export default InputField;