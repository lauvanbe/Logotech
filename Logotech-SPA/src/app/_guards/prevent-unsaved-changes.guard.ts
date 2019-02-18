import { Injectable } from '@angular/core';
import { CanDeactivate } from '@angular/router';
import { PatientEditComponent } from '../patients/patient-edit/patient-edit.component';

@Injectable()
export class PreventUnsavedChanges implements CanDeactivate<PatientEditComponent> {
    canDeactivate(component: PatientEditComponent) {
        if (component.editForm.dirty) {
            return confirm('Etes vous sûr de vouloir continuer? Toutes modifications non sauvegardées seront perdues');
        }
        return true;
    }
}
