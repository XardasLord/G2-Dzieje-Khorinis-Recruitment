import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CharactersRoutingModule } from './characters-routing.module';
import { CharactersListComponent } from './components/characters-list/characters-list.component';
import { CharactersComponent } from './components/characters/characters.component';
import { AddNewCharacterDialogComponent } from './components/add-new-character-dialog/add-new-character-dialog.component';

@NgModule({
	declarations: [CharactersComponent, CharactersListComponent, AddNewCharacterDialogComponent],
	imports: [CommonModule, CharactersRoutingModule, FormsModule, ReactiveFormsModule],
	schemas: [CUSTOM_ELEMENTS_SCHEMA],
	entryComponents: [AddNewCharacterDialogComponent],
})
export class CharactersModule {}
