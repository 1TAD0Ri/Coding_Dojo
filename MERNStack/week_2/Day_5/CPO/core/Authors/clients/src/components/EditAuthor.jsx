import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { useNavigate, useParams, Link } from 'react-router-dom';

const EditAuthor = () => {
    const { id } = useParams();
    const navigate = useNavigate();
    const [name, setName] = useState('');
    const [errors, setErrors] = useState([]);

    useEffect(() => {
        // Fetch existing author details when the component mounts
        axios.get(`http://localhost:8000/api/authors/${id}`)
            .then(response => {
                setName(response.data.name);
            })
            .catch(error => {
                console.error('Error fetching author details:', error);
            });
    }, [id]);

    const onSubmit = (e) => {
        e.preventDefault();

        // Send a PATCH request to update the author
        axios.patch(`http://localhost:8000/api/authors/${id}`, { name })
            .then(response => {
                // Handle successful update
                console.log('Author updated:', response.data);
                // Redirect to the '/authors' page after successful update
                navigate('/authors');
            })
            .catch(err => {
                const errorResponse = err.response.data.errors;

                const errorArr = []; // Define a temp error array to push the messages in

                for (const key of Object.keys(errorResponse)) { // Loop through all errors and get the messages

                    errorArr.push(errorResponse[key].message)


                }

                setErrors(errorArr);
            })

    }
    // Handle update error
    //             console.error('Error updating author:', error);
    //         });
    // };

    const onCancel = () => {
        // Redirect to the '/authors' page when cancel button is clicked
        navigate('/authors');
    };

    return (
        <div>
            <h2>Edit Author</h2>
            <Link to="/authors">Home</Link>

            <form onSubmit={onSubmit}>
            {errors.map((err, index) => <p style={{ color:"red" }} key={index}>{err}</p>)}
                <label>Name</label>
                <input type="text" onChange={(e) => setName(e.target.value)} value={name} />
                <button type="submit">Update</button>
                <button type="button" onClick={onCancel}>Cancel</button>
            </form>
        </div>
    );
};

export default EditAuthor;
