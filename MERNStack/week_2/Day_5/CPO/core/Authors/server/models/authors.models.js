const mongoose = require('mongoose');

const AuthorSchema = new mongoose.Schema({
    name:{
        type:String,
        required:[true,"{PATH} is required"],
        minLength:[3,"{PATH} must be at least three characters"],
    },
},{timestamps:true})

const Author = mongoose.model("Author",AuthorSchema);
module.exports= Author;