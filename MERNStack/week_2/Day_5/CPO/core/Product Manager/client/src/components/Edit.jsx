import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { useNavigate, useParams, Link } from 'react-router-dom';

const Edit = () => {
    const { id } = useParams();
    const [title, setTitle] = useState("");
    const [price, setPrice] = useState(0);
    const [description, setDescription] = useState("");
    const navigate = useNavigate();

    useEffect(() => {
        // Fetch existing author details when the component mounts
        axios.get(`http://localhost:8000/api/people/${id}`)
            .then(response => {
                setTitle(response.data.title);
            })
            .catch(error => {
                console.error('Error fetching title details:', error);
            });
    }, [id]);

    const onSubmit = (e) => {
        e.preventDefault();

        // Send a PATCH request to update the author
        axios.patch(`http://localhost:8000/api/people/${id}`, { title , price , description })
            .then(response => {
                // Handle successful update
                console.log('Product updated:', response.data);
                // Redirect to the '/authors' page after successful update
                navigate('/people');
            })
            .catch(error => {
                // Handle update error
                console.error('Error updating author:', error);
            });
    };

    const onCancel = () => {
        // Redirect to the '/authors' page when cancel button is clicked
        navigate('/people');
    };

    return (
        <div>
            <h2>Edit Author</h2>
            <Link to="/people">Home</Link>

            <form onSubmit={onSubmit}>
                <label>Title</label>
                <input type="text" onChange={(e) => setTitle(e.target.value)} value={title} />
                <label>Price</label>
                <input type="number" onChange={(e) => setPrice(e.target.value)} value={price} />
                <label>Description</label>
                <input type="text" onChange={(e) => setDescription(e.target.value)} value={description} />
                <button type="submit">Update</button>
                <button type="button" onClick={onCancel}>Cancel</button>
            </form>
        </div>
    );
};

export default Edit