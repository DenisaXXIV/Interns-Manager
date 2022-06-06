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

import { AddPageComponent } from './add-page/add-page.component';
import { AddInternsComponent } from './add-interns/add-interns.component';
import { AddInternshipComponent } from './add-internship/add-internship.component';
import { AddPersonComponent } from './add-person/add-person.component';
import { RecordsModule } from '../Records/records.module';



@NgModule({
  declarations: [
    AddInternsComponent,
    AddInternshipComponent,
    AddPersonComponent,
    AddPageComponent
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
    MatDatepickerModule,
    RecordsModule
  ],exports: [
    AddInternsComponent,
    AddInternshipComponent,
    AddPageComponent,
    AddPersonComponent,
  ]
})
export class AddRecordsModule { }
