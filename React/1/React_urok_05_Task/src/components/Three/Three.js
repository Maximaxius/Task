import React from "react";
import Ingredients from "./Ingredients";
import Cooking from "./Cooking"

// Создайте и запустите приложение React, выводящее информацию о кулинарном рецепте в браузер.
// Например: название рецепта, составляющие рецепта (ингредиенты и их количество),
// последовательность приготовления, фотография готового блюда.

function Three() {

    return(
        <div>
            <h2>Корн-доги</h2> 
            <Ingredients/>
            <Cooking/>
            <img src="./cook.jpg" style={{hight: "250px", width: "250px"}} alt="example"></img>  
        </div>
    );
}

export default Three;