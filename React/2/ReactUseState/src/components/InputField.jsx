import React, { useState, useEffect } from "react";

// 3.	Создайте компонент InputField, который содержит поле ввода и отображает значение введенного текста ниже.
// Используйте useState для хранения значения текста.
// При изменении содержимого поля ввода значение должно обновляться и отображаться ниже.
// Усложнение: текст должен отображаться ещё и в title вкладки/страницы


export default function InputField() {
    const [text, setText] = useState('');

    const Change = (e) => {
        setText(e.target.value);
    };

    useEffect(() => {
        document.title = `${text}`;
    }, [text]);

    return (
        <div style={{ marginTop: "30px" }}>
            <label style={{ marginRight: "15px" }}>Enter text</label>
            <input type="text" value={text} onChange={Change} />
            <div>{text}</div>
        </div>
    );
}