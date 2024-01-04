const AuthorController= require('../controllers/authors.controllers');

module.exports =app=>{
    app.get("/api/authors",AuthorController.showAllAuthors);
    app.post("/api/authors",AuthorController.createAuthor);
    app.get('/api/authors/:id',AuthorController.showOneAuthor);
    app.delete("/api/authors/:id",AuthorController.deleteOneAuthor);
    app.patch("/api/authors/:id",AuthorController.updateAuthor);
}
