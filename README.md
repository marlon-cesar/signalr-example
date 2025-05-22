# SignalR .NET + Angular

This project is a simple example of real-time communication using **SignalR** with **ASP.NET Core (Minimal APIs)** on the backend and **Angular** on the frontend.

---

## 📚 Technologies Used

- .NET 9  
- SignalR  
- Angular 19

---

## ✅ Functionality

- The backend exposes a **SignalR Hub** at `/Hub/SendMessage`.
- An HTTP endpoint (`/sendMessage`) allows sending a message to all connected clients.
- Angular connects to the Hub and displays messages in real time.

---

## ⚠️ Angular

Angular uses the official `@microsoft/signalr` package to connect to the backend Hub.

When a new message is sent from the backend, SignalR triggers the `ReceiveMessage` method, which adds the message to the rendered list on the screen.
