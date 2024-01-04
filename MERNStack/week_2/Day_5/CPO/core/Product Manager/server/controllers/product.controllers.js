const Products = require('../models/product.models')

//create a product Manager

module.exports.createProduct=(req,res)=>{
    Products.create(req.body)
    .then(product=>res.json(product))
    .catch(err=>err.json(err))
};

module.exports.getAllPeople = (request, response) => {
    Products.find({})
        .then(persons => response.json(persons))
        .catch(err => response.json(err))
}

module.exports.getPerson = (request, response) => {
    Products.findOne({_id:request.params.id})
        .then(person => response.json(person))
        .catch(err => response.json(err))
}

module.exports.updateProduct = (req, res) => {
    Products.findByIdAndUpdate({ _id: req.params.id }, req.body, { new: true, runValidators: true })
        .then(result => res.json(result))
        .catch(err => res.json(err));
};

module.exports.deleteOneProduct = (req,res)=>{
    Products.deleteOne({_id:req.params.id}).then(result=>res.json(result))
    .catch(err=>res.json(err))
};

