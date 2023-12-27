import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';

function SearchBar() {
  const [formstate, setFormstate] = useState({
    option: "people",
    id: ""
  });

  const navigate = useNavigate();

  const onSubmitHandler = (e) => {
    e.preventDefault();

    setFormstate({
      ...formstate,
      id: "",
    });

    navigate("/" + formstate.option + "/" + formstate.id);
  };

  return (
    <div>
      <form onSubmit={onSubmitHandler}>
        <label>Search For</label>
        <select
          name="option"
          value={formstate.option}
          onChange={(e) => {
            setFormstate({
              ...formstate,
              option: e.target.value,
            });
          }}
        >
          <option value="people">People</option>
          <option value="planets">Planet</option>
        </select>
        <label>ID : </label>
        <input
          type="number"
          name="id"
          value={formstate.id}
          onChange={(e) => {
            setFormstate({
              ...formstate,
              id: e.target.value,
            });
          }}
        />
        <button type="submit">Search</button>
      </form>
    </div>
  );
}

export default SearchBar;
