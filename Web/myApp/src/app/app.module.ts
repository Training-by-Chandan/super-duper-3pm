import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HeaderComponent } from './main/header/header.component';
import { SidebarComponent } from './main/sidebar/sidebar.component';
import { FooterComponent } from './main/footer/footer.component';
import { BodyComponent } from './main/body/body.component';
import { ButtonComponent } from './button/button.component';
import { ListComponent } from './category/list/list.component';
import { CreateComponent } from './category/create/create.component';
import { EditComponent } from './category/edit/edit.component';
import { DeleteComponent } from './category/delete/delete.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    SidebarComponent,
    FooterComponent,
    BodyComponent,
    ButtonComponent,
    ListComponent,
    CreateComponent,
    EditComponent,
    DeleteComponent,

  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
