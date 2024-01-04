import React from 'react'
import axios from "axios";
import { useState } from "react"
import { useNavigate } from "react-router-dom";
import { Link } from 'react-router-dom';

const CreateAuthor = () => {
    const [name, setName] = useState('');
    const navigate = useNavigate();
    const [errors, setErrors] = useState([]); 

    const onSubmit = (e) => {
        e.preventDefault();
        
        // Change the axios post URL to the correct endpoint for creating authors
        axios.post('http://localhost:8000/api/authors', { name })
            .then(res => {
                console.log(res.data); // Log the response if needed
                // Redirect to the '/authors' page after successful submission
                navigate('/authors');
            })
            .catch((err)=>{
                const errorResponse = err.response.data.errors;

                const errorArr = [];
                for(const Key of Object.keys(errorResponse)) {
                    errorArr.push(errorResponse[Key].message)
                }

                setErrors(errorArr)
            })
            // .catch(err => console.error(err)); and we stop here usual

            
        // Clear the name state after submission
        setName('');
    }
    
    const onCancel = () => {
        // Redirect to the '/authors' page when cancel button is clicked
        navigate('/authors');
    };

    return (
        <div>
            <h2>Favorites Authors</h2>
            <Link to="/authors">Home</Link>

            <form onSubmit={onSubmit}>
            {errors.map((err, index) => <p style={{ color:"red" }} key={index}>{err}</p>)}

                <label>Name</label>
                {/* Remove the unnecessary use of name.name */}
                <input type="text" onChange={(e) => setName(e.target.value)} value={name} />
                <button type="submit">Submit</button>
                <button type="button" onClick={onCancel}>Cancel</button>
            </form>
        </div>
    )
}


export default CreateAuthor