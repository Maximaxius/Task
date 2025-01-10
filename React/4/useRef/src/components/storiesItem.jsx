import React, {useState, useEffect} from "react";
import "./components.css";
import { names } from "../generate";

const StoriesItem = ({someUrl, descript, hash}) => {
    const [nickname, setNickname] = useState("");
    const [date, setDate] = useState(new Date());

    useEffect(() => {
        setNickname((nickname) => {
            return names[Math.floor(Math.random() * 82)] + Math.floor(Math.random() * (100-10)) + 10;
        })
    }, []);

    let tags = hash.split(" ");
    return (
        <div className="storiesItem">
            <h2>{nickname}</h2>
            <p>Date: {date.getDate()}.{date.getMonth()}.{date.getFullYear()}</p>
            <p>Time: {date.getHours()}:{date.getMinutes()}</p>
            <img className="storiesImg" src={someUrl}/>
            <p>{descript}</p>
            <p>{tags.map((item) => (
                `#${item} `
            ))}</p>
        </div>

    )
}


export default StoriesItem;