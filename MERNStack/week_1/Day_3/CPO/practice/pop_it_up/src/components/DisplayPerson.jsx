//RFCe
import React from 'react'

const DisplayPerson = (props) => {
    return (
        <div>
            <h1>{props.name} {props.lastName}</h1>
            <p>age : {props.age}</p>
            <p>hair color : {props.hairColor}</p>
        </div>
    )
}

export default DisplayPerson
