import React from "react";
import CityName from './CityName';
import CityHistor from './CountruName';

// Создайте и запустите приложение React, выводящее краткую информацию о вашем городе в браузер.
// Например: название города, название страны, год основания, несколько фотографий достопримечательностей вашего
// города.

// Создайте и запустите приложение React, выводящее краткую информацию о вашем городе в браузер.
// Например: название города, название страны, год основания, несколько фотографий достопримечательностей вашего города.

function Three() {    
    return(
        <div>
            <CityName/>
            <CityHistor/>
            Дата основания:1323 г.
            <br></br> 
            <img src="./castle.jpg" style={{hight: "250px", width: "250px", marginRight:"15px"}} alt="example"></img>       
            <img src="./lion.jpg" style={{hight: "250px", width: "250px"}} alt="example"></img>   
        </div>
    );
}

export default Three;