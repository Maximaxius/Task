import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ExpComponent } from './exp/exp.component';
import { InfoComponent } from './info/info.component';
import { MainInfComponent } from './main-inf/main-inf.component';

@NgModule({
  declarations: [
    AppComponent,
    ExpComponent,
    InfoComponent,
    MainInfComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
