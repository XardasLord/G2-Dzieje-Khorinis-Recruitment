import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
	selector: 'app-add-new-character-dialog',
	templateUrl: './add-new-character-dialog.component.html',
	styleUrls: ['./add-new-character-dialog.component.scss'],
})
export class AddNewCharacterDialogComponent {
	public addCharacterForm = new FormGroup({
		name: new FormControl(null, [Validators.required]),
		description: new FormControl(null, [Validators.required]),
	});

	constructor(public activeModal: NgbActiveModal) {}

	onSubmit(): void {
		if (this.addCharacterForm.invalid) {
			return;
		}

		this.activeModal.close(this.addCharacterForm.value);
	}
}
