function addItem(){
    let newItemName = document.createElement('li');
    newItemName.innerText = nameInp.value;
    Name.appendChild(newItemName);  
    nameInp.value="";

    let newItemDes = document.createElement('li');
    newItemDes.innerText = desInp.value;
    description.appendChild(newItemDes);  
    desInp.value="";

    let newItemCom = document.createElement('li');
    newItemCom.innerText = complected.checked ? "yes" : "no";
    completed.appendChild(newItemCom);  
}



function delItem(){
    let n = 0;
    let elForDelName = false;
    for(var element of Name.childNodes){
      if(element.tagName == "LI") n++;
      if(n==delInp.value) {
        elForDelName = element;
        break;
        }
    }
    if(elForDelName) Name.removeChild(elForDelName); 

    let m=0;
    let elForDelDes = false;
    for(var element of description.childNodes){
        if(element.tagName == "LI") m++;
        if(m==delInp.value) {
            elForDelDes = element;
          break;
          }
      }
    if(elForDelDes) description.removeChild(elForDelDes); 

    let t=0;
    let elForDelCom = false;
    for(var element of completed.childNodes){
        if(element.tagName == "LI") t++;
        if(t==delInp.value) {
            elForDelCom = element;
          break;
          }
      }
    if(elForDelCom) completed.removeChild(elForDelCom); 

}

function editItem(){
    let newName = Name.childNodes[editInp.value]
    newName.innerText = newNameInp.value

    let newDes= description.childNodes[editInp.value]
    newDes.innerText = newDesInp.value
}

function editCompleted(){
    let toCompleted = completed.childNodes[comInp.value]
    toCompleted.innerText = complected.checked ? "yes" : "no";

}

function showNotCom(){
    let com = completed.childNodes;
    let name = Name.childNodes;
    let des = description.childNodes;
    let i=0;
    while(i<com.length){
        i++
        if(com[i].innerText !='no'){
            com[i].style.display="none";
            name[i].style.display="none";
            des[i].style.display="none";
        }
    }
}

function showAll(){
    let com = completed.childNodes;
    let name = Name.childNodes;
    let des = description.childNodes;
    let i=0;
    while(i<com.length){
        i++;
        com[i].style.display="list-item";
        name[i].style.display="list-item";
        des[i].style.display="list-item";
        
    }
}



function insertItem(){
    var firstItem = list.childNodes[0];
    var newItem = document.createElement('li');
    newItem.in = "New item";
    list.insertBefore(newItem, firstItem);
}