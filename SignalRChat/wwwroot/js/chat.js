"use strict";

// Hub için bağlantı değişkeni tanımlıyoruz
var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

// İşlemleri gerçekleştiren butonumuzu yakalıyoruz
document.getElementById("sendButton").disabled = true;

// Hub'ın bize gönderdiği parametreleri yakalıyoruz
connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    li.textContent = `${user} says ${message}`;
});

// Hub'a bağlantı açıldığında butonu tıklanılabilir yapıyoruz
connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

// Mesajı hub'a gönderiyoruz
document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});