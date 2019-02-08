import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ListePatientsComponent } from './liste-patients/liste-patients.component';
import { AgendaComponent } from './agenda/agenda.component';
import { AuthGuard } from './_guards/auth.guard';
import { ListePraticiensComponent } from './praticiens/liste-praticiens/liste-praticiens.component';
import { PraticienDetailComponent } from './praticiens/praticien-detail/praticien-detail.component';
import { PraticienDetailResolver } from './_resolvers/praticien-detail.resolver';
import { PraticienListeResolver } from './_resolvers/liste-praticien.resolver';

export const appRoutes: Routes = [
    { path: '', component: HomeComponent},
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            { path: 'liste-praticiens', component: ListePraticiensComponent, resolve: { praticiens: PraticienListeResolver}},
            { path: 'liste-praticiens/:id', component: PraticienDetailComponent, resolve: { praticien: PraticienDetailResolver}},
            { path: 'liste-patients', component: ListePatientsComponent},
            { path: 'agenda', component: AgendaComponent},
        ]
    },
    { path: '**', redirectTo: '', pathMatch: 'full'},
];
