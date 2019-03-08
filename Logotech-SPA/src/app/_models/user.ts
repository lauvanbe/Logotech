import { Adresse } from './adresse';

export interface User {
  id: number;
  inami: number;
  nom: string;
  prenom: string;
  emai: string;
  deplacement: string;
  adresse: Adresse;
  telFixe?: number;
  Gsm?: number;
}
