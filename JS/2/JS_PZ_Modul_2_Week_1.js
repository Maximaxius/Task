// Создать объект, описывающий прямоугольник (хранит координаты левой верхней и правой нижней точек),
//  и написать следующие функции для работы с таким объектом
let rectangle ;
function createRectangle(){
    rectangle ={
        leftUpX : Number(leftUpX.value),
        leftUpY : Number(leftUpY.value),
        rightDownX : Number(rightDownX.value),        
        rightDownY : Number(rightDownY.value)
    }
}


// 1. Функция принимает объект-прямоугольник и выводит информацию о нем (где какая точка расположена).
function showRectangle(){
    if(rectangle.leftUpY > rectangle.rightDownY && rectangle.leftUpX < rectangle.rightDownX){
        showInfo.innerHTML = `A (${rectangle.leftUpX},${rectangle.leftUpY}) B(${rectangle.rightDownX},${rectangle.leftUpY})
         C(${rectangle.rightDownX},${rectangle.rightDownY}) D(${rectangle.leftUpX},${rectangle.rightDownY})`;
    }
}

//2. Функция принимает объект-прямоугольник и возвращает его ширину.
function showWidth(){
    width.innerHTML = `${rectangle.rightDownX-rectangle.leftUpX}`
}

//3. Функция принимает объект-прямоугольник и возвращает его высоту.
function showHeight(){
    height.innerHTML = `${rectangle.leftUpY-rectangle.rightDownY}`
}


// 4. Функция принимает объект-прямоугольник и возвращает его площадь.
function showArea(){
    area.innerHTML = `${(rectangle.leftUpY-rectangle.rightDownY)*(rectangle.rightDownX-rectangle.leftUpX)}`
}


// 5. Функция принимает объект-прямоугольник и возвращает его периметр.
function showPerimeter(){
    perimeter.innerHTML = `${2*((rectangle.leftUpY-rectangle.rightDownY)+(rectangle.rightDownX-rectangle.leftUpX))}`
}