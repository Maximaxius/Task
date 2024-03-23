function downloadTxt(text, filename) {
	blob = new Blob([text], { type: "text/plain" });
	url = window.URL.createObjectURL(blob);
	a = document.createElement("a");
	a.href = url;
	a.download = filename;
	a.click();
}


var parent=document.body.getElementsByClassName("tm-article-snippet tm-article-snippet")
let sons = parent[0].childNodes
let mes ="";
console.log(sons)

for(let i=0; i<sons.length; i++) {
	let son = sons[i];
	mes += `${+i}) ${son.nodeName} (${son.nodeName})\n`;//${son.innerText}
	if(son.hasChildNodes()) {
		let son2=son.childNodes;
		for(let j=0; j<son2.length; j++) {
			let son2Not = son2[j];
			mes += `   ${i}.${j}) ${son2Not.tagName} (${son2Not.nodeName}) \n`;//${son2Not.innerText} 
			if(son2Not.hasChildNodes()) {
				let son3=son2Not.childNodes;
				for(let k=0; k<son3.length; k++) {
					let son3Not = son3[k];
					mes += `      ${i}.${j}.${k}) ${son3Not.tagName} (${son3Not.nodeName})  ${son3Not.innerText}\n`;
				}
			}
		}
	}
}

mes.replace("\n"," ")

const filename = document.head
  .querySelector("title")
  .innerText.replace("/", "")
  .replace("≥", "более ");
downloadTxt(mes, `${filename}.txt`);