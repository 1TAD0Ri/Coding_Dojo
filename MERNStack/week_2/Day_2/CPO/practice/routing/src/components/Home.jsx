import React from 'react'
import { Routes, Route, Link } from 'react-router-dom';



function Home() {
    return (
       
            <div>
                <h1>Hello Students Coding Dojo </h1>
                <h2>gO CHECK THIS LINK </h2>

                <Link to="/welcome">click here</Link>

            </div>
       
    )
}

export default Home