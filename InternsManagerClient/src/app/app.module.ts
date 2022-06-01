import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { InternServiceService } from './Services/intern-service.service';
import { RecordsModule } from './Records/records.module';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    RecordsModule,
    HttpClientModule,
    CommonModule,
    FormsModule
  ],
  providers: [InternServiceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
