import React, { useState, useEffect } from "react";

// 6.	Создайте компонент MousePosition, который отображает текущие координаты мыши при перемещении по странице.
//  Используйте useEffect для добавления слушателя событий перемещения мыши при монтировании
//  компонента и удаления его при размонтировании.


export default function MousePosition() {
    const [x, setX] = useState(0);
    const [y, setY] = useState(0);

    const move = (e) => {
        setX(e.clientX)
        setY(e.clientY)
    }

    useEffect(() => {
        document.addEventListener("mousemove", move)

        return () => {
            document.removeEventListener("mousemove", move)
        };
    }, []);          


    useEffect(() => {
        console.log(`X ${x} Y${y}`)
    }, [x, y]);//здесь вроде так можно тк отстановка мыши==финальная установка ху


    return (
        <div style={{ marginTop: "30px" }}>
            x = {x}   y = {y}
        </div>
    );
}