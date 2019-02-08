import { Adresse } from './adresse';
import { Fonction } from './fonction';
import { Specialisation } from './specialisation';

export interface Praticien {
    id: number;
    inami: number;
    nom: string;
    prenom: string;
    email: string;
    telFixe: number;
    gsm: number;
    deplacement: boolean;
    photoUrl: string;
    adresse: Adresse;
    fonction: Fonction;
    specialisation: Specialisation;
}
