import { Component } from '@angular/core';

@Component({
  selector: 'app-main-inf',
  templateUrl: './main-inf.component.html',
  styleUrls: ['./main-inf.component.css']
})
export class MainInfComponent {
  title = 'Summary';
  FIO :string ="V M A";
  phonNum :string ="+375441234567";
  city :string ="Lida";
}
