import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Praticien } from '../_models/praticien';

@Injectable({
  providedIn: 'root'
})
export class PraticienService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getPraticiens(): Observable<Praticien[]> {
    return this.http.get<Praticien[]>(this.baseUrl + 'praticiens');
  }

  getPraticien(id): Observable<Praticien> {
    return this.http.get<Praticien>(this.baseUrl + 'praticiens/' + id);
  }
}
