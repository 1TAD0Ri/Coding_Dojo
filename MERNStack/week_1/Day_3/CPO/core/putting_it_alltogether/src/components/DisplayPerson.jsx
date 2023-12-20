//RFCe
import React from 'react'
import { useState } from 'react';



const DisplayPerson = (props) => {
    const {prop1}=props;
    const [age,ageconst]=useState(prop1.age)
    const addAge=()=>{
        ageconst(age+1)

    
    }
    return (
        <div>
            <h1>{prop1.first} {prop1.last}</h1>
            <h4>age :{age}</h4>
            <button onClick={addAge}>Birthday Button for {prop1.first} {prop1.last}</button>
        </div>
    )
}

export default DisplayPerson
