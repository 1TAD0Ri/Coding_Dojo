const jokeController = require('../controllers/jokes.controllers');

module.exports = app => {
    app.get("/api/jokes", jokeController.showAllJokes);
    app.post("/api/jokes", jokeController.createJoke);
    app.get('/api/jokes/:id', jokeController.showOneJoke);
    app.delete("/api/jokes/:id", jokeController.deleteOneJoke);
    app.put("/api/jokes/:id", jokeController.updateJoke);
}
