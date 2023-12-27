import React from 'react'
import { Routes, Route, Link } from 'react-router-dom';
import { useParams } from 'react-router-dom';


function Hello() {
    const { word } = useParams();
    return (
        <div >
            {isNaN(word) ? (
                <h1>This Number is: {word}</h1>
            ) : (
                <h1>This word is: {word}</h1>
            )}
        </div>
    );
}

export default Hello