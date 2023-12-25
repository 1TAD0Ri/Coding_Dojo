import './App.css';
import { useState } from 'react';
import axios from 'axios';

function App() {
  const [pokemon, setPokemon] = useState([]);
  const fetchPokemons = () => {
    console.log("yooooooooooooo");
    axios.get("https://pokeapi.co/api/v2/pokemon").then(res => setPokemon(res.data.results)).catch(error => console.log("Somthing went wrong", error))

  }
  return (
    <div className="App">

      <button onClick={fetchPokemons}>Fetch Pokemon</button>
      <ul>
        {pokemon.map((onepokemon,idx)=>(
          <li key={idx}>
            {onepokemon.name}
          </li>
        ))}
      </ul>

    </div>
  );
      }

export default App;
