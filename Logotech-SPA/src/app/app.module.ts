import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { BsDropdownModule, TabsModule } from 'ngx-bootstrap';
import { RouterModule } from '@angular/router';
import { JwtModule } from '@auth0/angular-jwt';

import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { AuthService } from './_services/auth.service';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { ErrorInterceptorProvider } from './_services/error.interceptor';
import { AlertifyService } from './_services/alertify.service';
import { AgendaComponent } from './agenda/agenda.component';
import { appRoutes } from './routes';
import { AuthGuard } from './_guards/auth.guard';
import { PraticienService } from './_services/praticien.service';
import { ListePraticiensComponent } from './praticiens/liste-praticiens/liste-praticiens.component';
import { PraticienCardComponent } from './praticiens/praticien-card/praticien-card.component';
import { PraticienDetailComponent } from './praticiens/praticien-detail/praticien-detail.component';
import { PraticienDetailResolver } from './_resolvers/praticien-detail.resolver';
import { PraticienListeResolver } from './_resolvers/liste-praticien.resolver';
import { ListePatientsComponent } from './patients/liste-patients/liste-patients.component';
import { PatientService } from './_services/patient.service';
import { PatientListeResolver } from './_resolvers/liste-patient.resolver';
import { PatientCardComponent } from './patients/patient-card/patient-card.component';
import { PatientDetailComponent } from './patients/patient-detail/patient-detail.component';
import { PatientDetailResolver } from './_resolvers/patient-detail.resolver';


export function tokenGetter() {
   return localStorage.getItem('token');
}

@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      HomeComponent,
      RegisterComponent,
      ListePatientsComponent,
      PatientCardComponent,
      PatientDetailComponent,
      AgendaComponent,
      ListePraticiensComponent,
      PraticienCardComponent,
      PraticienDetailComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      FormsModule,
      BsDropdownModule.forRoot(),
      TabsModule.forRoot(),
      RouterModule.forRoot(appRoutes),
      JwtModule.forRoot({
         config: {
            tokenGetter: tokenGetter,
            whitelistedDomains: ['localhost:5000'],
            blacklistedRoutes: ['localhost:5000/api/auth']
         }
      })
   ],
   providers: [
      AuthService,
      ErrorInterceptorProvider,
      AlertifyService,
      AuthGuard,
      PraticienService,
      PraticienDetailResolver,
      PraticienListeResolver,
      PatientService,
      PatientListeResolver,
      PatientDetailResolver
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
