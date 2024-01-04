const express = require('express');
const app = express();
require('dotenv').config();
const port = process.env.Port; // Corrected from process.env.port to process.env.PORT
const cors = require("cors");

app.use(express.json(), express.urlencoded({ extended: true }), cors());

// Grab the config
require("./config/product.config");

// Grab the routes
require("./routes/product.routes")(app);

app.listen(port, () => console.log(`Listening to port ${port}`));
