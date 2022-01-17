import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { AdminComponent } from './login/admin/admin.component';
import { StudentComponent } from './login/student/student.component';
import { RegisterComponent } from './login/student/register/register.component';
import { AdminRouteComponent } from './admin-route/admin-route.component';
import { StudentRouteComponent } from './student-route/student-route.component';
import { HomeComponent } from './home/home.component';
import { RouterModule } from '@angular/router';
import { AdminHomeComponent } from './admin-route/admin-home/admin-home.component';
import { AdminViewbooksComponent } from './admin-route/admin-viewbooks/admin-viewbooks.component';
import { AdminAddbookComponent } from './admin-route/admin-addbook/admin-addbook.component';
import { AdminOrdersComponent } from './admin-route/admin-orders/admin-orders.component';
import { AdminService } from './admin.service';
import { HttpClientModule } from '@angular/common/http';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { StudentHomeComponent } from './student-route/student-home/student-home.component';
import { BooksComponent } from './student-route/books/books.component';
import { OrdersComponent } from './student-route/orders/orders.component';
import { NgxPaginationModule } from 'ngx-pagination';
import { ServiceWorkerModule } from '@angular/service-worker';
import { environment } from '../environments/environment';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    AdminComponent,
    StudentComponent,
    RegisterComponent,
    AdminRouteComponent,
    StudentRouteComponent,
    HomeComponent,
    AdminHomeComponent,
    AdminViewbooksComponent,
    AdminAddbookComponent,
    AdminOrdersComponent,
    StudentHomeComponent,
    BooksComponent,
    OrdersComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    NgxPaginationModule,
    AppRoutingModule,
    FormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
    RouterModule.forRoot([
      { path: '', component: HomeComponent },
      {path:'admin-login',component:AdminComponent},
      {path:'student-login',component:StudentComponent},
      {path:'student-reg',component:RegisterComponent},
      {path:'admin-route',component:AdminRouteComponent},
      {path:'admin-home',component:AdminHomeComponent},
      // {path:'admin-viewbook',component:AdminViewbooksComponent},
      {path:'admin-addbook',component:AdminAddbookComponent},
      {path:'admin-orders',component:AdminOrdersComponent},
      {path:'student-route',component:StudentRouteComponent},
      {path:'student-home',component:StudentHomeComponent},
      {path:'books',component:BooksComponent},
      {path:'orders',component:OrdersComponent}

    ]),
    ServiceWorkerModule.register('ngsw-worker.js', {
      enabled: environment.production,
      // Register the ServiceWorker as soon as the app is stable
      // or after 30 seconds (whichever comes first).
      registrationStrategy: 'registerWhenStable:30000'
    }),
  ],
  providers: [AdminService],
  bootstrap: [AppComponent]
})
export class AppModule { }
