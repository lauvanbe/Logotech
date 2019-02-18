import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Patient } from '../_models/Patient';

@Injectable({
  providedIn: 'root'
})

export class PatientService {
  baseUrl = environment.apiUrl;

    constructor(private http: HttpClient) { }

    getPatients(): Observable<Patient[]> {
      return this.http.get<Patient[]>(this.baseUrl + 'Patients');
    }

    getPatient(id): Observable<Patient> {
      return this.http.get<Patient>(this.baseUrl + 'Patients/' + id);
    }

    updatePatient(id: number, patient: Patient) {
      return this.http.put(this.baseUrl + 'Patients/edit/' + id, patient);
    }
}
