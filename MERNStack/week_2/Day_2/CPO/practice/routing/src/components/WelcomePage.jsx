import React from 'react'
import { Routes, Route, Link } from 'react-router-dom';


function WelcomePage() {
    return (

        <div>
            <h1>  Welcome</h1>
            <p>Hello Come check us </p>
            <Link to="/hello">Hellooo</Link>

        </div>

    )
}

export default WelcomePage