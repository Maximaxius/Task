import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';

@NgModule({
  //декларируем перечень компонентов
  declarations: [AppComponent],
  //импорт модулей. Пока здесь базовый лишь
  imports: [BrowserModule],
  providers: [],
  //корневой компонент
  bootstrap: [AppComponent],
})
export class AppModule {}
