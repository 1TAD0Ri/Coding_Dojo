const productController = require('../controllers/product.controllers');

module.exports = app => {
    app.post("/api/people/new", productController.createProduct);
    app.get('/api/people', productController.getAllPeople);
    app.get('/api/people/:id', productController.getPerson);
    app.patch("/api/people/:id",productController.updateProduct);
    app.delete("/api/people/:id",productController.deleteOneProduct);


}

