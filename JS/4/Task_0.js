const alphabetSmall = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
const alphaberBig = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
const alphabetEng ="abcdefghijklmnopqrstuvwxyz";

function createName(){    
    let name=""
    for(let i=0;i<Math.random()*(13-5)+5;i++){
        if(i==0)
            name+= alphaberBig[Math.floor(Math.random() * alphaberBig.length)]
        name+= alphabetSmall[Math.floor(Math.random() * alphabetSmall.length)]
    }
    return name;
}

function createGroup(){
    let group="Группа: "
    for(let i=0;i<5;i++){
        if(i==0)
            group+= alphaberBig[Math.floor(Math.random() * alphaberBig.length)]
        group+= Math.floor(Math.random()*9);
    }
    return group;
}

function createMail(){
    let mail=""
    for(let i=0;i<Math.random()*(13-5)+5;i++){
        mail+= alphabetEng[Math.floor(Math.random() * alphabetEng.length)]
    }
    mail+="@"
    for(let i=0;i<Math.random()*4;i++){
        mail+= alphabetEng[Math.floor(Math.random() * alphabetEng.length)]
    }
    mail+=".com"
    return mail;
}



for(let i =0;i<10;i++){
    let mainDiv = document.createElement("div");

    mainDiv.style.cssText=`width: 200px;
        height: 300px;
        border: solid 2px grey;
        display: inline-block;
        margin: 10px;`;//

    let photo = document.createElement('img')
    photo.src="img/card.jpg";
    photo.style.cssText=`border-radius : 50%;
        width: 50px;
        height: 50px;
        padding: 10px`;


    let name = document.createElement('span')
    name.innerText = createName();

    let group = document.createElement('div')
    group.innerText = createGroup();
    group.style.cssText=`margin-left: 15px;`;
    
    
    let awards = document.createElement('div')
    awards.style =`display: flex;
    margin-top: 6px;
    align-items: center;`

    let diamond = document.createElement('img');
    diamond.src = ("img/diamond.webp")
    diamond.style = `width: 20px; height: 20px;`
    let diamondNum = document.createElement('span');
    diamondNum.innerText = Math.floor(Math.random()*100);
    awards.appendChild(diamond)
    awards.appendChild(diamondNum)

    let coin = document.createElement('img');
    coin.src = ("img/coin.webp")
    coin.style = `width: 20px; height: 20px;`
    let coinNum = document.createElement('span');
    coinNum.innerText = Math.floor(Math.random()*100);
    awards.appendChild(coin)
    awards.appendChild(coinNum)

    let comment = document.createElement('img');
    comment.src = ("img/comment.png")
    comment.style = `width: 20px; height: 20px;`
    let commentNum = document.createElement('span');
    commentNum.innerText = Math.floor(Math.random()*10);
    awards.appendChild(comment)
    awards.appendChild(commentNum)

    let medal = document.createElement('img');
    medal.src = ("img/medal.png")
    medal.style = `width: 20px; height: 20px;`
    let medaltNum = document.createElement('span');
    medaltNum.innerText = Math.floor(Math.random()*10);
    awards.appendChild(medal)
    awards.appendChild(medaltNum)


    let avgBallDiv = document.createElement('div');
    avgBallDiv.style.cssText=`background-color: #4CAF50;
    width: 45px;
    height: 30px;
    margin: 10px 10px 5px 10px;
    border-radius: 35%;
    display: inline-block;`;
    let avgBallNum = document.createElement('div')
    avgBallNum.style =`padding: 5px 5px;`
    avgBallNum.innerText = (Math.random()*10).toFixed(1);
    avgBallDiv.appendChild(avgBallNum)
    let avgBallText = document.createElement('span')
    avgBallText.innerText = "Cредний балл"

    let avgVisitDiv = document.createElement('div');
    avgVisitDiv.style.cssText=`background-color: #4CAF50;
    width: 45px;
    height: 30px;
    margin: 10px 10px 5px 10px;
    border-radius: 35%;
    display: inline-block;`;
    let avgVisitNum = document.createElement('div')
    avgVisitNum.style =`padding: 5px 6px;`
    avgVisitNum.innerText = Math.floor((Math.random()*100));
    avgVisitDiv.appendChild(avgVisitNum)
    let avgVisitText = document.createElement('span')
    avgVisitText.innerText = "Посещение,%"

    let age = document.createElement('div')
    age.innerText = `Возраст: ${Math.floor(Math.random()*70)} лет`

    let date = document.createElement('div')
    date.innerText = `Был в MyStat: ${Math.floor(Math.random()*30)}.${Math.floor(Math.random()*12)}.${Math.floor(Math.random()*(2077-1000)+1000)}`

    let mail = document.createElement('div')
    mail.innerText = createMail();

    mainDiv.appendChild(photo);
    mainDiv.appendChild(name);
    mainDiv.appendChild(group);
    mainDiv.appendChild(awards);
    mainDiv.appendChild(avgBallDiv);
    mainDiv.appendChild(avgBallText);
    mainDiv.appendChild(avgVisitDiv);
    mainDiv.appendChild(avgVisitText);
    mainDiv.appendChild(age);
    mainDiv.appendChild(mail);
    mainDiv.appendChild(date);
    document.body.appendChild(mainDiv);
}