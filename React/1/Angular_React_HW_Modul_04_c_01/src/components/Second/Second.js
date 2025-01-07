import React from "react";

import PersonInfo from './PersonInfo';
import SongAndCover from './SongAndCover';

// Создайте и запустите приложение React, выводящее информацию о вашей любимой музыкальной группе в браузер.
// Например: название группы, информация об участниках группы, название альбомов, обложки альбомов.

function Second(props) {

    let { groopName} = props;   

    return(
        <div>
            <h1> {groopName}  </h1> 
            <PersonInfo name={"Фредди Меркьюри"}/>
            <PersonInfo name={"Джон Дикон"}/>
            <PersonInfo name={"Брайан Мэй"}/>
            <PersonInfo name={"Роджер Тейлор"}/>

            <br></br><br></br>
            <SongAndCover name={"We Are The Champions "} cover={"./cover.webp"}/>
            <br></br><br></br>
            <SongAndCover name={"Bohemian Rhapsody "} cover={"./cover2.jpg"}/>
            
        </div>
    );
}

export default Second;