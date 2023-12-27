import React from 'react'
import { useParams } from 'react-router-dom'

function Number() {
    const { number } = useParams();

    return (
        <h1>This number is : {number}</h1>

    )
}




export default Number