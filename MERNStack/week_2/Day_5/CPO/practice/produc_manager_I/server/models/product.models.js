const mongoose = require('mongoose');

const ProductSchema = new mongoose.Schema({
    title:{
        type:String,
        required:[true,"{PATH} is required"],
        minLength:[3,"{PATH} must be at least three characters"],
    },
    price:{
        type:Number,
        required:[true,"{PATH} is required"],
        min: [0, "{PATH} must be a positive value"],
        // max: [1000, "{PATH} cannot exceed 1000"] // Adjust the maximum value as per your needs
    },
    description:{
        type:String,
        required:[true,"{PATH} is required"],
        minLength:[3,"{PATH} must be at least three characters"],
    }
    },{timestamps:true})

const Product = mongoose.model("Product",ProductSchema);
module.exports= Product;