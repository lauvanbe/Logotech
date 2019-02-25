import { Injectable } from '@angular/core';
import { Docteur } from '../_models/docteur';
import { Resolve, Router, ActivatedRouteSnapshot } from '@angular/router';
import { PraticienService } from '../_services/praticien.service';
import { AlertifyService } from '../_services/alertify.service';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable()
export class PraticienDetailResolver implements Resolve<Docteur> {
    constructor(private praticienService: PraticienService, private router: Router, private alertify: AlertifyService) { }

    resolve(route: ActivatedRouteSnapshot): Observable<Docteur> {
        return this.praticienService.getDocteur(route.params['id']).pipe(
            catchError(error => {
                this.alertify.error('probleme d\'accès aux données');
                this.router.navigate(['/liste-praticiens']);
                return of(null);
            })
        );
    }
}
