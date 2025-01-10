import React from "react";
import "./components.css";
import user from "../images/user.png";
import dateI from "../images/date.png";
import timeI from "../images/time.png";


const NewsItem = ({title, date, name}) => {
    return (
        <div className="itemContainer">
            <h3 className="padLeft1">{title}</h3>
            <div className="newsInfo bottomSpace">
                <div className="score" >
                    <img src={user} className="icon1"/>
                    <p className="text leftMargin">{name} </p>
                </div>
                <div className="score">
                    <img src={dateI} className="icon"/>
                    <p className="text leftMargin">{date.getDate()}.{date.getMonth()}.{date.getFullYear()} </p>
                </div>
                <div className="score">
                    <img src={timeI} className="icon"/>
                    <p className="text leftMargin">{date.getHours()}:{date.getMinutes()} </p>
                </div>
            </div>
            
        </div>
    )
}

export default NewsItem;