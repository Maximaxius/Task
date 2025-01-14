import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'buttons';

  show:number =0

  car():void{
    this.show=1;
  }

  airplane():void{
    this.show=2;
  }

  ship():void{
    this.show=3;
  }

}
