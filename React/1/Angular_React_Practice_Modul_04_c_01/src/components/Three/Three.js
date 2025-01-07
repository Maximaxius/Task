import React from "react";
import CityName from './CityName';
import CityHistor from './CityHistor';

// Создайте и запустите приложение React, выводящее краткую информацию о вашем городе в браузер.
// Например: название города, название страны, год основания, несколько фотографий достопримечательностей вашего
// города.

function Three() {    
    return(
        <div>
            <CityName/>
            <CityHistor/>
            <img src="./castle.jpg" alt="example"></img>           
        </div>
    );
}

export default Three;