import React from 'react'
import axios from 'axios'
import { useState, useEffect } from 'react'
import { useParams } from 'react-router-dom';


function Planets() {
    const [planet, setPlanet] = useState(null);
    const { id } = useParams();

    useEffect(() => {
        axios.get("https://swapi.dev/api/planets/" + id + "/" )
            .then(res => { 
                setPlanet(res.data); 
            })
            .catch(error => {
                console.log("Error fetching data:", error);
            });
    }, [id]);
    
    if (planet == null) {
        return "loading..."
    }
    return (
        <div>
            
            <h1>{planet.name}</h1>
            <p>Rotation period : {planet.rotation_period}</p>
            <p>Orbital period: {planet.orbital_period}</p>
            <p>Diameter : {planet.diameter}</p>
            <p>Climate: {planet.climate}</p>
            <p>Gravity: {planet.gravity}</p>
            <p>Terrain : {planet.terrain}</p>
            <p>Surface water : {planet.surface_water}</p>
            <p>Population : {planet.population}</p>

        </div>
    )
}

export default Planets