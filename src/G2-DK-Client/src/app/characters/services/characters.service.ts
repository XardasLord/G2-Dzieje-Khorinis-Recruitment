import { Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Character } from '../models/character.model';
import { environment } from 'src/environments/environment';
import { AddCharacterCommand } from '../models/add-character.command';

@Injectable({ providedIn: 'root' })
export class CharactersService {
	constructor(private httpClient: HttpClient) {}

	public getCharacters(): Observable<Character[]> {
		return this.httpClient.get<Character[]>(environment.charactersApiEndpoint);
	}

	public addCharacter(command: AddCharacterCommand): Observable<number> {
		return this.httpClient.post<number>(environment.charactersApiEndpoint, command);
	}
}
