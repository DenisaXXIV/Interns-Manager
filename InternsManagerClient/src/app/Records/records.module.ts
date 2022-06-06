import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatIconModule } from '@angular/material/icon';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { FormsModule } from '@angular/forms';
import { MatSelectModule } from '@angular/material/select';
import { MatFormFieldModule } from '@angular/material/form-field';
import { RouterModule } from '@angular/router';
import { MatInputModule} from '@angular/material/input';
import { MatDatepickerModule} from '@angular/material/datepicker';

import { HomeComponent } from './home/home.component';
import { InternCardComponent } from './intern-card/intern-card.component';
import { ToolsComponent } from './tools/tools.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';



@NgModule({
  declarations: [
    HomeComponent,
    InternCardComponent,
    ToolsComponent,
    NavBarComponent
  ],
  imports: [
    CommonModule,
    MatIconModule,
    MatCardModule,
    MatButtonModule,
    MatFormFieldModule,
    FormsModule,
    MatSelectModule,
    RouterModule,
    MatInputModule,
    MatDatepickerModule
  ],
  exports: [
    HomeComponent,
    InternCardComponent,
    NavBarComponent
  ]
})
export class RecordsModule { }
