var express = require("express");
var app = express();
var server = require("http").createServer(app);
var io = require("socket.io")(server);
var users = [];
var connections = [];

server.listen(3000);

app.get("/", function (req, res) {
    res.sendFile(__dirname + "/index.html");
});

io.sockets.on("connection", function (socket) {
    connections.push(socket);

    socket.on("disconnect", function (data) {
        connections.splice(connections.indexOf(socket), 1);
    });

    socket.on("send message", function (data) {
        console.log(data);
        io.sockets.emit("new message", { id: Date.now(), msg: data, sender: socket.id });
    });
});
