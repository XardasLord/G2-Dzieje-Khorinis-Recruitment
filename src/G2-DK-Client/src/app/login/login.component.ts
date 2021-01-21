import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { first } from 'rxjs/operators';
import { AuthService } from '../core/auth/auth.service';

@Component({
	selector: 'app-login',
	templateUrl: './login.component.html',
	styleUrls: ['./login.component.scss'],
})
export class LoginComponent implements OnInit {
	loginForm!: FormGroup;
	loading = false;
	submitted = false;
	error = '';

	constructor(
		private formBuilder: FormBuilder,
		private route: ActivatedRoute,
		private router: Router,
		private authService: AuthService
	) {
		if (this.authService.currentUserValue) {
			this.router.navigate(['/']);
		}
	}

	ngOnInit(): void {
		this.loginForm = this.formBuilder.group({
			login: ['', Validators.required],
			password: ['', Validators.required],
		});
	}

	// convenience getter for easy access to form fields
	get f() {
		return this.loginForm.controls;
	}

	onSubmit(): void {
		this.submitted = true;

		if (this.loginForm.invalid) {
			return;
		}

		this.loading = true;
		this.authService
			.login(this.f.login.value, this.f.password.value)
			.pipe(first())
			.subscribe({
				next: () => {
					const returnUrl = this.route.snapshot.queryParams['returnUrl'] || '/';
					this.router.navigate([returnUrl]);
				},
				error: (error) => {
					this.error = error?.Message ?? error;
					this.loading = false;
				},
			});
	}
}
