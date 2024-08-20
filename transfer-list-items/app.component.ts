import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TransferListItemsComponent } from './transfer-list-items/transfer-list-items.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,TransferListItemsComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'TrialProject';
}
