import React from 'react';

function SongAndCover(props) {
    let {name, cover} = props;
    return (
        <div>
            {name}
            <br></br>
            <img src={cover} style={{hight: "120px", width: "120px"}}></img> 
        </div>
    );
   }

export default SongAndCover;