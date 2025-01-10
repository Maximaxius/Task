import "./components.css";
import React, { useState } from "react";
import { names, surnames, titles, randDate } from "../generate";
import NewsItem from "./newsItem.jsx";

const news = Array.from({ length: Math.floor(Math.random() * (10 - 3) + 3) }, () => ({
    title: titles[Math.floor(Math.random() * 9)],
    date: randDate(),
    name: `${surnames[Math.floor(Math.random() * 26)]} ${names[Math.floor(Math.random() * 82)]}`
}));

const News = () => {
    const [newsItems, setNewsItems] = useState(news);
    const [titleNew, setTitle] = useState("");
    const [now, setNow] = useState(new Date());
    const [nameNew, setName] = useState("");

    function handleClick() {
        setNow(new Date());
        console.log(now);
        setNewsItems((newsItems) => [
            ...newsItems,
            { title: titleNew, date: now, name: nameNew },
        ]);
        
    }

    return (
        <div >
            <input className="inp"
            type="text"
            onChange={(e) => setTitle(e.target.value)}
            value={titleNew}
            placeholder="Введите тему"
            >
            </input>
            <input className="inp"
            type="text"
            onChange={(e) => setName(e.target.value)}
            value={nameNew}
            placeholder="Введите автора"
            >
            </input>
            <button className="btn" onClick={handleClick}>Добавить</button>
            <div className="Container">
                {newsItems.map((item, index) => (
                <NewsItem key={`${index}`} {...item}/>
                ))}
            </div>
        </div>
    )
};

export default News;