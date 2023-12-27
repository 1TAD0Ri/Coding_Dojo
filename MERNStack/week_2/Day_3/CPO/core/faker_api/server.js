const express = require("express");
const app = express();
const { faker } = require('@faker-js/faker');
const port = 8000;
const {v4:uuidv4} = require('uuid')

app.get("/api/users/new", (req, res) => {
    const newUser = createUser();
    res.json(newUser);
});

app.get("/api/companies/new", (req, res) => {
    const newCompany = createCompany();
    res.json(newCompany);
});

app.get("/api/user/company", (req, res) => {
    const newUser = createUser();
    console.log(newUser);
    const newCompany = createCompany();
    res.json({ user: newUser, company: newCompany });
});

function createUser() {
    return {
        id: uuidv4(),
        name: faker.person.firstName(),
        email: faker.internet.email(),
        age: faker.number.int({ min: 50, max: 200 }),
    };
}

function createCompany() {
    return {
        name: faker.company.name(),
        industry: faker.company.name(),
        employees: faker.number.int({ min: 50, max: 200 }),
    };
}

app.listen(port, () => {
    console.log(`Server is running on port ${port}`);
});
