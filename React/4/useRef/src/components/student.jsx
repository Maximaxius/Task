import React from "react";
import "./components.css";
import diamond from "../images/christal.png";
import coin from "../images/coin.png";
import comment from "../images/comment.png";
import badge from "../images/badge.png";
import face from "../images/face.png";
import email from "../images/email.jpg";
import phoneI from "../images/phone.png";
import enter from "../images/enter.png";



const Student = ({name, surname, avatar, group, diamonds, coins, 
                  comments, badges, avgGrade, visit, age, mail, 
                  login, phone, date}) => {
    
    return (
        <div className="itemContainer">
            <div className="avaName">
                <img src={avatar} className="ava"/>
                <h2 className="leftMargin">{name} {surname}</h2>
            </div>
            <p className="text padLeft">Group: {group}</p>
            <div className="scores">
                <div className="score">
                    <img src={diamond} className="icon"/>
                    <p className="text leftMargin">{diamonds} </p>
                </div>
                <div className="score">
                    <img src={coin} className="icon"/>
                    <p className="text leftMargin">{coins} </p>
                </div>
                <div className="score">
                    <img src={comment} className="icon"/>
                    <p className="text leftMargin">{comments} </p>
                </div>
                <div className="score">
                    <img src={badge} className="icon"/>
                    <p className="text leftMargin">{badges} </p>
                </div>
            </div>
            <div className="gradeVisit">
                <div className="stat" style={{backgroundColor: "#b1ddc7"}}>{avgGrade}</div>
                <p className="text padSpace">Average Grade</p>
            </div>
            <div className="gradeVisit">
                <div className="stat" style={{backgroundColor: "#90abbd"}}>{visit}</div>
                <p className="text padSpace">Visit, %</p>
            </div>
            <div className="persInfo spaceTop">
                <img src={face} className="icon"/>
                <p className="text padSpace2">Age: {age} years</p>
            </div>
            <div className="persInfo">
                <img src={email} className="icon"/>
                <p className="text padSpace2">{mail}</p>
            </div>
            <div className="persInfo">
                <img src={phoneI} className="icon"/>
                <p className="text padSpace2">{phone}</p>
            </div>
            <div className="persInfo">
                <img src={enter} className="icon"/>
                <p className="text padSpace2">{login}</p>
            </div>
            <p className="text padLeft bottomSpace">Last seen in MyStat: {date.getDate()}/{date.getMonth()}/{date.getFullYear()}</p>
        </div>
    )
};

export default Student;
