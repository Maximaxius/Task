import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title: string =" ";
  Quotes: string[] = ["«Patience is a key element of success»",'If you think your teacher is tough, wait till you get a boss',
  ' Success is a lousy teacher. It seduces smart people into thinking they can’t lose','Life is not fair — get used to it!','Be nice to nerds. Chances are you’ll end up working for one']
  name : string = "William Henry Gates III"
  birth : Date = new Date(1955, 10, 28)
  money :number = 28 ;
  persent : number = 0.0136;

  
  count: number = 1;
  addClick($event:any):void{
    this.count++;
    if(this.count>=4)
      this.count=4
  }

  removeClick($event:any):void{
    this.count--;
    if(this.count<=1)
      this.count=1
  }
}
