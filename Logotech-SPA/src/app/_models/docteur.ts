import { Adresse } from './adresse';

export interface Docteur {
    id: number;
    inami: number;
    nom: string;
    prenom: string;
    email: string;
    telFixe: number;
    gsm: number;
    specialisation: string;
    fonction: string;
    adresse: Adresse;
}
