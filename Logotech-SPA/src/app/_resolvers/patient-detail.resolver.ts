import { Injectable } from '@angular/core';
import { Resolve, Router, ActivatedRouteSnapshot } from '@angular/router';
import { AlertifyService } from '../_services/alertify.service';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Patient } from '../_models/Patient';
import { PatientService } from '../_services/patient.service';

@Injectable()
export class PatientDetailResolver implements Resolve<Patient> {
    constructor(private patientService: PatientService, private router: Router, private alertify: AlertifyService) { }

    resolve(route: ActivatedRouteSnapshot): Observable<Patient> {
        return this.patientService.getPatient(route.params['id']).pipe(
            catchError(error => {
                this.alertify.error('probleme d\'accès aux données');
                this.router.navigate(['/liste-patients']);
                return of(null);
            })
        );
    }
}
