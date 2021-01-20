import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ToolbarComponent } from './core/toolbar/toolbar.component';

const routes: Routes = [
	{
		path: '',
		component: ToolbarComponent,
		// loadChildren: () => import('../../home/home.module').then((m) => m.HomeModule),
		children: [
			{
				path: 'characters',
				loadChildren: () => import('../app/characters/characters.module').then((m) => m.CharactersModule),
			},
			{ path: '', redirectTo: 'home', pathMatch: 'full' },
		],
	},
	{ path: '**', redirectTo: '' },
];

@NgModule({
	imports: [RouterModule.forRoot(routes)],
	exports: [RouterModule],
})
export class AppRoutingModule {}
