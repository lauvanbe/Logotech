import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ListeLogopedesComponent } from './liste-logopedes/liste-logopedes.component';
import { ListePatientsComponent } from './liste-patients/liste-patients.component';
import { AgendaComponent } from './agenda/agenda.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
    { path: '', component: HomeComponent},
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            { path: 'liste-logopedes', component: ListeLogopedesComponent},
            { path: 'liste-patients', component: ListePatientsComponent},
            { path: 'agenda', component: AgendaComponent},
        ]
    },
    { path: '**', redirectTo: '', pathMatch: 'full'},
];
