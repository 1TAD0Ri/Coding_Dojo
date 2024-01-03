const mongoose = require('mongoose');

const JokeSchema = new mongoose.Schema({
    setup:{
        type:String,
        required:[true,"{PATH} is required"],
        minLength:[3,"{PATH} must be at least three characters"],
    },
    punchline:{ type:String,
        required:[true,"{PATH} is required"],
        minLength:[3,"{PATH} must be at least three characters"],
    },
},{timestamps:true})

const Joke = mongoose.model("Pirate",JokeSchema);
module.exports= Joke;

