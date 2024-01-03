const express = require("express");
const app = express();
const cors = require("cors")
require('dotenv').config();
const PORT = process.env.PORT;
    
require("./config/mongoose.config");
    
app.use(express.json(), express.urlencoded({ extended: true }),cors());
    
const AllMyJokesRoutes = require("./routes/jokes.routes");
AllMyJokesRoutes(app);
    
app.listen(PORT, () => console.log(`Listening on port: ${PORT}`) );
