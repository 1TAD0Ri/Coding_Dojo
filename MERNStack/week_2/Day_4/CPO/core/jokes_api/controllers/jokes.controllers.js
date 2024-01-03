const Jokes= require('../models/jokes.models')
//Create a joke
module.exports.createJoke=(req,res)=>{
    Jokes.create(req.body)
    .then(joke=>res.json(joke))
    .catch(err=>res.json(err))
};
//See all joke
module.exports.showAllJokes=(req,res)=>{
    Jokes.find().sort({ name: 1 }).then(jokes=>res.json(jokes))
    .catch(err=>res.json(err))
};
//See one joke
module.exports.showOneJoke = (req,res)=>{
    Pirates.findById({_id:req.params.id}).then(joke=>res.json(joke))
    .catch(err=>res.json(err))
};
//delete one joke
module.exports.deleteOneJoke = (req,res)=>{
    Jokes.deleteOne({_id:req.params.id}).then(result=>res.json(result))
    .catch(err=>res.json(err))
};
//Updare a joke
module.exports.updateJoke=(req,res)=>{
    Jokes.findByIdAndUpdate({_id:req.params.id},req.body,{new:true,runValidators:true})
    .then(result=>res.json(result))
    .catch(err=>res.json(err))
}
