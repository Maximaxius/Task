import React, { useState, useEffect } from "react";

// 4.	Создайте компонент Сountdown, который запускает при инициализации обратный отсчёт, начиная от 10 до 0.
//  При достижении 10 -- отображает сообщение “End Game”.

//плохо реализованное выполнение задания тк после выводв “End Game”. всеравно уменьшает время 
export default function Сountdown() {
    const [time, setTime] = useState(10);
    let minTime = 0;

    useEffect(() => {
        console.log("Инициализация интервала");
        const interval = setInterval(() => {
            minTime=minTime+1;
            setTime(time-minTime);
        }, 1000);

        return () => {
            clearInterval(interval);
            console.log("Очистка интервала");
        };
    }, []);

    useEffect(() => {
        setTime(time);
        console.log(time)
    }, [time]);

    return (
        <div style={{ marginTop: "30px" }}>
            {time <= 0 ? "End Game" : `${time}`}
        </div>
    );
}