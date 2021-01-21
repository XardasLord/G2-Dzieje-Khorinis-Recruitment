import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Observable } from 'rxjs';
import { AddCharacterCommand } from '../../models/add-character.command';
import { Character } from '../../models/character.model';
import { CharactersService } from '../../services/characters.service';
import { AddNewCharacterDialogComponent } from '../add-new-character-dialog/add-new-character-dialog.component';

@Component({
	selector: 'app-characters-list',
	templateUrl: './characters-list.component.html',
	styleUrls: ['./characters-list.component.scss'],
})
export class CharactersListComponent implements OnInit {
	public characters$!: Observable<Character[]>;
	public closedSuccessAlert = true;

	constructor(private charactersService: CharactersService, private modalService: NgbModal) {}

	ngOnInit(): void {
		this.characters$ = this.charactersService.getCharacters();
	}

	addCharacter(): void {
		this.modalService.open(AddNewCharacterDialogComponent).result.then((result: AddCharacterCommand) => {
			this.charactersService.addCharacter(result).subscribe(() => {
				setTimeout(() => (this.closedSuccessAlert = false), 1);
				setTimeout(() => (this.closedSuccessAlert = true), 5000);
				this.characters$ = this.charactersService.getCharacters();
			});
		});
	}
}
