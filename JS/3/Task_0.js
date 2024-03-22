// 1. Разместите на странице 4 блока, как показано на рисунке. Напишите инструкции,
// меняющие цвет нижнего блока в зависимости от того, на каком из верхних блоков находится указатель мыши.
// Если указатель не находится ни над одним из верхних блоков,нижний блок должен приобрести серый цвет.
document.addEventListener('mouseover',function(e){
    if (e.target===span1) 
    result.style.backgroundColor = getComputedStyle(span1).getPropertyValue('background-color');
    else if (e.target===span2) 
        result.style.backgroundColor = getComputedStyle(span2).getPropertyValue('background-color');
    else if(e.target===span3) 
    result.style.backgroundColor = getComputedStyle(span3).getPropertyValue('background-color'); 
    else result.style.backgroundColor = 'grey'
})



// Разместите на странице один блок. Напишите инструкции, которые обеспечат перемещение блока
// при нажатии левой клавиши мыши в точку, в которой находится указатель мыши.
document.addEventListener('mousedown', function(e){
    if(e.button==0){
    let x = e.clientX - 25;
    let y = e.clientY - 25;
    obj.style.top = y + 'px';
    obj.style.left = x + 'px';}

    obj2.innerHTML = `X:${e.clientX} Y:${e.clientY}`
})
