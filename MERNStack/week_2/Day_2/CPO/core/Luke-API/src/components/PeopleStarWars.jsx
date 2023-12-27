import React from 'react'
import axios from 'axios'
import { useState, useEffect } from 'react'
import { useParams } from 'react-router-dom';

function PeopleStarWars() {
    const [people, setPeople] = useState(null);
    const { id } = useParams();

    useEffect(() => {
        axios.get("https://swapi.dev/api/people/" + id + "/" )
            .then(res => { 
                setPeople(res.data); 
            })
            .catch(error => {
                console.log("Error fetching data:", error);
            });
    }, [id]);
    
    if (people == null) {
        return "loading..."
    }
    return (
        <div>
            
            <h1>{people.name}</h1>
            <p>Height : {people.height}</p>
            <p>Hair Color : {people.hair_color}</p>
            <p>Eye Color : {people.eye_color}</p>
            <p>Skin Color : {people.skin_color}</p>

        </div>
    )
}

export default PeopleStarWars