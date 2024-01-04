import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import axios from 'axios';

const AllProducts = () => {
    const [peoples, setPeoples] = useState(null);

    useEffect(() => {
        axios.get("http://localhost:8000/api/people")
            .then(res => setPeoples(res.data))
            .catch(err => console.log(err));
    }, []);

    const handleDelete = (id) => {
        // Send a DELETE request to remove the people
        axios.delete(`http://localhost:8000/api/people/${id}`)
            .then(() => {
                // Update the peoples list after successful deletion
                setPeoples(peoples.filter(people => people._id !== id));
            })
            .catch(err => console.error(err));
    };

    return (
        <div>

            {peoples && (
                <div>
                    {peoples.map((people) => (

                        <div key={people._id}>
                            <h1>Title</h1>
                            <h2 >{people.title}</h2>
                            <h1>Price</h1>
                            <h2 >{people.price}</h2>
                            <h1>Description</h1>
                            <h2 >{people.description}</h2>
                            <button> <Link to={`/people/${people._id}`}>Edit</Link></button>
                            <button onClick={() => handleDelete(people._id)}>Delete</button>
                        </div>
                    ))}
                </div>
            )}
        </div>
    );
};

export default AllProducts;
