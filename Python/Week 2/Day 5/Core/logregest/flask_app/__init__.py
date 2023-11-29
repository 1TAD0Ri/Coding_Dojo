#and always those two lines XD 
from flask import Flask
app= Flask(__name__)
#we add a secret key hi hi hi h i
app.secret_key = "shhh no secrets on github!"
#we import the database
DATABASE= "log_regb"