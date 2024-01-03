const Products = require('../models/product.models')

//create a product Manager

module.exports.createProduct=(req,res)=>{
    Products.create(req.body)
    .then(product=>res.json(product))
    .catch(err=>err.json(err))
};

module.exports.showAllProducts=(req,res)=>{
    Products.find().sort({ name: 1 }).then(products=>res.json(products))
    .catch(err=>res.json(err))
};