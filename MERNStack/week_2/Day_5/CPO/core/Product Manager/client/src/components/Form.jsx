import React, { useState } from 'react';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';

const FormComponent = () => {
    const [title, setTitle] = useState("");
    const [price, setPrice] = useState(0);
    const [description, setDescription] = useState("");
    const navigate = useNavigate();
    const onSubmitHandler = (e) => {
        e.preventDefault();

        axios.post('http://localhost:8000/api/people/new', {
            title,
            price,
            description
        })
        .then(res => {
            console.log(res);
            setTitle("");
            setPrice(0);
            setDescription("");
            navigate('/people');
        })
        .catch(err => console.log(err));
    }

    // const navigate = useNavigate();
    // const addToallpeople = () => {
    //     navigate('/people');
    // }

    return (
        <form onSubmit={onSubmitHandler}>
            <p>
                <label>Title</label><br/>
                <input type="text" onChange={(e) => setTitle(e.target.value)} value={title}/>
            </p>
            <p>
                <label>Price</label><br/>
                <input type="number" onChange={(e) => setPrice(e.target.value)} value={price}/>
            </p>
            <p>
                <label>Description</label><br/>
                <input type="text" onChange={(e) => setDescription(e.target.value)} value={description}/>
            </p>
            <input type="submit" />
        </form>
    );
}

export default FormComponent;
