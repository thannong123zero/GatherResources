let connection = new signalR.HubConnectionBuilder()
    .withUrl("/notificationHub")
    .build();

connection.on("ReceiveNotification", function (message) {
    console.log("New notification: " + message);
});

connection.start().then(function () {
    console.log("Connected!");
}).catch(function (err) {
    return console.error(err.toString());
});

await _hubContext.Clients.Group(groupName).SendAsync("ReceiveNotification", message);