import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminViewbooksComponent } from './admin-route/admin-viewbooks/admin-viewbooks.component';
import { LoginComponent } from './login/login.component';

const routes: Routes = [
  {path:'admin-viewbook',component:AdminViewbooksComponent},
  {path:'login',component:LoginComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
