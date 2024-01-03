const productController= require('../controllers/product.controllers');

module.exports =app=>{
    app.post("/api/products",productController.createProduct);
    app.get("/api/products",productController.showAllProducts);

}

