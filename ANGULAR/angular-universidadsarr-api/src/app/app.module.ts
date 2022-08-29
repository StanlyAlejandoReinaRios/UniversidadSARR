//#1
import {HttpClientModule} from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { UniversidadsarrComponent } from './universidadsarr/universidadsarr.component';
import { ReadUniversidadsarrComponent } from './universidadsarr/read-universidadsarr/read-universidadsarr.component';
import { CreateEditUniversidadsarrComponent } from './universidadsarr/create-edit-universidadsarr/create-edit-universidadsarr.component';

//#2
import { UniversidadsarrApiService } from './universidadsarr-api.service';

@NgModule({
  declarations: [
    AppComponent,
    UniversidadsarrComponent,
    ReadUniversidadsarrComponent,
    CreateEditUniversidadsarrComponent
  ],
  imports: [
    BrowserModule,
    //#4
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
