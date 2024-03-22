//После благополучной загрузки страницы выполняет вывод на экран текущего времени и сообщения об успешной загрузке
function addNote(){
    let simbol = Math.floor(1+Math.random()*4);
    let a =(Math.floor(1+Math.random()*55));
    let b =(Math.floor(1+Math.random()*55));
    let add = document.createElement('div');
    add.className = 'add';
    switch(simbol){
        case 1:
            add.innerHTML=`${a} + ${b} = ${a+b}`
        break;
        case 2:
            add.innerHTML=`${a} - ${b} = ${a-b}`
        break;
        case 3:
            add.innerHTML=`${a} * ${b} = ${a*b}`
        break;
        case 4:
            add.innerHTML=`${a} / ${b} = ${a/b}`
        break;
    }
    result.appendChild(add);
}

function addLanguages(){
    for(let i=0;i<navigator.languages.length;i++){
        if(i==0)
            document.getElementById("languages").innerHTML += '<b>'+navigator.languages[0] +'</b>'
        else document.getElementById("languages").innerHTML +=navigator.languages[i] + ' ';
    } ;
}

window.addEventListener("load",function() {
    const now = new Date();
    const hours = now.getHours();
    const minutes = now.getMinutes().toString()
    const seconds = now.getSeconds().toString()
    document.getElementById("time").innerHTML = `${hours} : ${minutes} : ${seconds}`;
    addLanguages()
    for(let i =0;i<Math.floor(20+Math.random()*25);i++){
        addNote();
    }
})

document.addEventListener("scroll",function() {
    let change = true;
    while(change) {
      let windowRelativeBottom = document.documentElement.getBoundingClientRect().bottom;
      if (windowRelativeBottom > document.documentElement.clientHeight+100)
        change=false;
    addNote();
    }
})



document.addEventListener("keydown", function(e){
    if(e.key == "r" || e.key == "R")
        document.location.reload();
})


document.addEventListener("contextmenu", function(e){
    e.preventDefault()
})