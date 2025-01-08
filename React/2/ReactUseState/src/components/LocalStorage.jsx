import React, { useState, useEffect } from "react";

// 5.	Создайте компонент LocalStorage, который сохраняет и загружает данные из локального хранилища браузера.
// Используйте useEffect для сохранения данных при изменении определенной зависимости (например, ввода пользователя)
// и загрузки обратно данных при монтировании компонента.

export default function LocalStorage() {
    const [text, setText] = useState('');

    useEffect(() => {
        setText(localStorage.getItem('task5'))
    }, []);
 
    const Change = (e) => {
        setText(e.target.value);
        localStorage.setItem('task5', text)
    };

    return (
        <div style={{ marginTop: "30px" }}>
            <label style={{ marginRight: "15px" }}>Enter text/text from LocalStorage</label>
            <input type="text" value={text} onChange={Change} />
            <div>{text}</div>
        </div>
    );
}