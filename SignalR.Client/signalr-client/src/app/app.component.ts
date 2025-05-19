import { Component, OnInit } from '@angular/core';
import { SignalRService } from '../services/signalr.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  imports: [CommonModule], // ⬅️ Aqui!
})
export class AppComponent implements OnInit{

   messages: string[] = [];


  constructor(private signalRService: SignalRService){
  }

  ngOnInit(): void {
    this.signalRService.startConnection();
    this.signalRService.listenMessage((msg: string) => {
      this.messages.push(msg);      
    });

  }
  
}
