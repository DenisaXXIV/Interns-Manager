import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatIconModule } from '@angular/material/icon';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { FormsModule } from '@angular/forms';
import { MatSelectModule } from '@angular/material/select';
import { MatFormFieldModule } from '@angular/material/form-field';
import { RouterModule } from '@angular/router';


import { AddInternComponent } from './add-intern/add-intern.component';
import { HomeComponent } from './home/home.component';
import { InternCardComponent } from './intern-card/intern-card.component';
import { ToolsComponent } from './tools/tools.component';



@NgModule({
  declarations: [
    AddInternComponent,
    HomeComponent,
    InternCardComponent,
    ToolsComponent
  ],
  imports: [
    CommonModule,
    MatIconModule,
    MatCardModule,
    MatButtonModule,
    MatFormFieldModule,
    FormsModule,
    MatSelectModule,
    RouterModule
  ],
  exports: [
    HomeComponent,
    InternCardComponent
  ]
})
export class RecordsModule { }
