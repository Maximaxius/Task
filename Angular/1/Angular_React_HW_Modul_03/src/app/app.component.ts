import { Component } from '@angular/core';

@Component({
  selector: 'app-root', //В данный эл-т будет вставляться представление (как будет обзываться эл-т в index.html)
  templateUrl: './app.component.html', //шаблон (представление) страницы
  styleUrls: ['./app.component.css'], //набор файлов стилей
})
export class AppComponent {
  title: string =" ";
  firstQuote: string = '«Patience is a key element of success»';
  secondQuote : string ='If you think your teacher is tough, wait till you get a boss';
  threeQuote : string ='Life is not fair — get used to it!';
  fourQuote : string =' Success is a lousy teacher. It seduces smart people into thinking they can’t lose';
  fiveQuote : string ='Be nice to nerds. Chances are you’ll end up working for one';
  bio : string = "William Henry Gates III (born October 28, 1955) is an American billionaire business magnate, investor, and philanthropist. He co-founded the software giant Microsoft along with his childhood friend Paul Allen. During his career at Microsoft, Gates held the positions of chairman, chief executive officer (CEO), president, and chief software architect, while also being its largest individual shareholder until May 2014. He was a major entrepreneur of the microcomputer revolution of the 1970s and 1980s."
  

  groupName: string = 'PX3020';
}
