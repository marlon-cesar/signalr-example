# SignalR .NET + Angular 

Este projeto é um exemplo simples de comunicação em tempo real utilizando **SignalR** com **ASP.NET Core (Minimal APIs)** no backend e **Angular** no frontend.

## 📚 Tecnologias utilizadas

- [.NET 9](https://learn.microsoft.com/aspnet/core)
- [SignalR](https://learn.microsoft.com/aspnet/core/signalr)
- [Angular 19](https://angular.io/)

---

### ✅ Funcionalidade
O backend expõe um Hub SignalR em /Hub/SendMessage.

Um endpoint HTTP (/sendMessage) permite disparar uma mensagem para todos os clientes conectados.

O Angular se conecta ao Hub e exibe mensagens em tempo real.

---

## 🔔Angular

O Angular utiliza o pacote oficial `@microsoft/signalr` para se conectar ao Hub exposto no backend.
Ao receber uma nova mensagem enviada pelo backend, o SignalR aciona o método ReceiveMessage, que adiciona a mensagem na lista renderizada na tela.
