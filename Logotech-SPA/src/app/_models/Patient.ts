import { Adresse } from './adresse';
import { Lateralite } from './Lateralite';

export interface Patient {
    id: number;
    nom: string;
    prenom: string;
    dateNaissance: Date;
    email: string;
    telFixe: number;
    gsm: number;
    personneContact: string;
    telContact: number;
    anamnese: string;
    commentaire: string;
    adresse: Adresse;
    lateralite: Lateralite;
}
