import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddInternComponent } from './Records/add-intern/add-intern.component';
import { HomeComponent } from './Records/home/home.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'add-intern', component: AddInternComponent },
  { path: 'add-intern/:id', component: AddInternComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
