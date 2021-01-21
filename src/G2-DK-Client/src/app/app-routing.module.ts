import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthGuard } from './core/auth/auth.guard';
import { ToolbarComponent } from './core/toolbar/toolbar.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';

const routes: Routes = [
	{
		path: '',
		component: ToolbarComponent,
		canActivate: [AuthGuard],
		children: [
			{
				path: '',
				component: HomeComponent,
			},
			{
				path: 'characters',
				loadChildren: () => import('../app/characters/characters.module').then((m) => m.CharactersModule),
			},
			{ path: '', redirectTo: 'home', pathMatch: 'full' },
		],
	},
	{ path: 'login', component: LoginComponent },
	{ path: '**', redirectTo: '' },
];

@NgModule({
	imports: [RouterModule.forRoot(routes)],
	exports: [RouterModule],
})
export class AppRoutingModule {}
