import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { User } from '../models/user';

@Injectable({ providedIn: 'root' })
export class AuthService {
	private currentUserSubject!: BehaviorSubject<User | null>;
	public currentUser: Observable<User | null>;

	constructor(private http: HttpClient) {
		// tslint:disable-next-line:no-non-null-assertion
		this.currentUserSubject = new BehaviorSubject<User | null>(JSON.parse(localStorage.getItem('currentUser')!));
		this.currentUser = this.currentUserSubject.asObservable();
	}

	public get currentUserValue(): User | null {
		return this.currentUserSubject.value;
	}

	login(login: string, password: string): Observable<any> {
		return this.http
			.post<any>(`${environment.apiUrl}/auth`, { login, password })
			.pipe(
				map((user) => {
					// store user details and jwt token in local storage to keep user logged in between page refreshes
					localStorage.setItem('currentUser', JSON.stringify(user));
					this.currentUserSubject.next(user);
					return user;
				})
			);
	}

	logout(): void {
		// remove user from local storage to log user out
		localStorage.removeItem('currentUser');
		this.currentUserSubject.next(null);
	}
}
