import React from "react";
// Создайте приложение «Любимый кинофильм». Оно будет содержать информацию о вашем любимом фильме:
//  название фильма, ФИО режиссера, год выпуска, киностудия, постер и т.д. Обязательно используйте функциональные компоненты и props

function Five(props) {

    let { movieName, director, year, studio, poster } = props;   

    return(
        <div>
            movieName={movieName}, director={director}, year {year}, studio {studio} 
            <br></br>
            <img src={poster} style={{hight: "250px", width: "250px"}} alt="example"></img>  
        </div>
    );
}

export default Five;

Five.defaultProps = {movieName: "movie", director: "director", year: "year",studio: "studio", poster: "" };