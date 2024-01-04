import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { Link } from 'react-router-dom';

const AllAuthors = () => {
  const [authors, setAuthors] = useState(null);
  
  useEffect(() => {
    axios.get("http://localhost:8000/api/authors")
      .then(res => setAuthors(res.data))
      .catch(err => console.log(err));
  }, []);

  const handleDelete = (id) => {
    // Send a DELETE request to remove the author
    axios.delete(`http://localhost:8000/api/authors/${id}`)
      .then(() => {
        // Update the authors list after successful deletion
        setAuthors(authors.filter(author => author._id !== id));
      })
      .catch(err => console.error(err));
  };

  return (
    <div>
      <h2>Favorite authors</h2>
      <Link to='/authors/new'> Add author</Link>
      <h2>We have quotes by:</h2>

      {authors && (
        <table>
          <thead>
            <tr>
              <th>Author</th>
              <th>Actions Available</th>
            </tr>
          </thead>
          <tbody>
            {authors.map((author) => (
              <tr key={author._id}>
                <td>{author.name}</td>
                <td>
                  <button>
                    <Link to={`/authors/${author._id}`}>Edit</Link>
                  </button>
                  <button onClick={() => handleDelete(author._id)}>Delete</button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </div>
  );
};

export default AllAuthors;
