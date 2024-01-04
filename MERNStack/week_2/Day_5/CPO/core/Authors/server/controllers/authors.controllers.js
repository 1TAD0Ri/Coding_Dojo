const Authors= require('../models/authors.models')



//Create a 
module.exports.createAuthor=(req,res)=>{
    Authors.create(req.body)
    .then(author=>res.json(author))
    .catch(err=>res.status(400).json(err))
};



//See all s
module.exports.showAllAuthors=(req,res)=>{
    Authors.find().sort({ name: 1 }).then(authors=>res.json(authors))
    .catch(err=>res.json(err))
};



//See one 
module.exports.showOneAuthor = (req,res)=>{
    Authors.findById({_id:req.params.id}).then(author=>res.json(author))
    .catch(err=>res.json(err))
};



//delete one 
module.exports.deleteOneAuthor = (req,res)=>{
    Authors.deleteOne({_id:req.params.id}).then(result=>res.json(result))
    .catch(err=>res.json(err))
};




//Updare a we use here put 
// module.exports.updateAuthor=(req,res)=>{
//     Authors.findByIdAndUpdate({_id:req.params.id},req.body,{new:true,runValidators:true})
//     .then(result=>res.json(result))
//     .catch(err=>res.json(err))
// }

module.exports.updateAuthor = (req, res) => {
    Authors.findByIdAndUpdate({ _id: req.params.id }, req.body, { new: true, runValidators: true })
        .then(result => res.json(result))
        .catch(err => res.status(400).json(err));
};
