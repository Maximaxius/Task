import "./components.css";
import React, { useState } from "react";
import Student from "./student.jsx";
import { Avatar, names, surnames, Group, Email, Login, Phone, randDate } from "../generate";

const students = Array.from({ length: Math.floor(Math.random() * 42) }, () => ({
    name: names[Math.floor(Math.random() * 82)],
    surname: surnames[Math.floor(Math.random() * 26)],
    avatar: Avatar(),
    group: Group(),
    diamonds: Math.floor(Math.random() * 1000),
    coins: Math.floor(Math.random() * 1000),
    comments: Math.floor(Math.random() * 13),
    badges: Math.floor(Math.random() * 42),
    avgGrade: (Math.random() * 10).toFixed(1),
    visit: Math.floor(Math.random() * 100),
    age: Math.floor(Math.random() * (100-13)) + 13,
    mail: Email(),
    phone: Phone(),
    login: Login(),
    date: randDate()
}));

const Students = () => {
    const [age, setAge] = useState("");
    const [stud, setStud] = useState(students);

    function handleClick() {
        setStud(students.filter((item) => item.age < age));
        }

    return (
        <div >
            <input className="inp"
            type="text"
            onChange={(e) => setAge(e.target.value)}
            value={age}
            placeholder="Введите максимальный возраст"
            >
            </input>
            <button className="btn" onClick={handleClick}>Отсортировать</button>
            <div className="Container">
                {stud.map((item, index) => (
                <Student key={`${index}`} {...item}/>
                ))}
            </div>
        </div>
    )
};

export default Students;