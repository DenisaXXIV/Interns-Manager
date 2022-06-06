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
import { AddRecordsModule } from './add-records/add-records.module';
import { EditPageComponent } from './EditRecords/edit-page/edit-page.component';
import { EditInternComponent } from './edit-records/edit-intern/edit-intern.component';
import { EditInternshipComponent } from './edit-records/edit-internship/edit-internship.component';
import { EditPersonComponent } from './edit-records/edit-person/edit-person.component';

@NgModule({
  declarations: [
    AppComponent,
    EditPageComponent,
    EditInternComponent,
    EditInternshipComponent,
    EditPersonComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    RecordsModule,
    HttpClientModule,
    CommonModule,
    FormsModule,
    AddRecordsModule,
    RecordsModule
  ],
  providers: [InternServiceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
