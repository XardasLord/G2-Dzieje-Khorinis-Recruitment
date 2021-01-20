import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CharactersListComponent } from './components/characters-list/characters-list.component';
import { CharactersComponent } from './components/characters/characters.component';

const routes: Routes = [
	{
		path: '',
		component: CharactersComponent,
		children: [
			{
				path: '',
				component: CharactersListComponent,
			},
		],
	},
];

@NgModule({
	imports: [RouterModule.forChild(routes)],
	exports: [RouterModule],
})
export class CharactersRoutingModule {}
