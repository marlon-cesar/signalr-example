import { Injectable } from '@angular/core';
import * as signalR from '@microsoft/signalr';

@Injectable({
    providedIn: 'root',
})

export class SignalRService {
    private hubConnection!: signalR.HubConnection;

    startConnection() {
        this.hubConnection = new signalR.HubConnectionBuilder()
            .configureLogging(signalR.LogLevel.Debug)
            .withUrl('https://localhost:7013/Hub/SendMessage', {
                skipNegotiation: true,  // skipNegotiation as we specify WebSockets
                transport: signalR.HttpTransportType.WebSockets  // force WebSocket transport
            })
            .build();

        this.hubConnection
            .start()
            .then(() => console.log('Connected to SignalR'))
            .catch((err) => console.error('Fail to connect to SignalR:', err));
    }

    listenMessage(callback: (mensagem: string) => void) {
        this.hubConnection.on('ReceiveMessage', callback);
    }
}
