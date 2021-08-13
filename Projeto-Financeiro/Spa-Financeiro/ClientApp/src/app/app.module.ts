import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { MovimentacaoComponent } from './movimentacao/movimentacao.component';

@NgModule({
  declarations: [
    AppComponent,
    MovimentacaoComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent, MovimentacaoComponent]
})
export class AppModule { }
