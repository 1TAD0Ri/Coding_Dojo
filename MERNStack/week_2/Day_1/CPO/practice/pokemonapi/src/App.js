import './App.css';
import { useState } from 'react';

function App() {
  const [pokemon, setPokemon] = useState([]);
  const fetchPokemons = () => {
    console.log("yooooooooooooo");
    fetch("https://pokeapi.co/api/v2/pokemon").then(res => res.json()).then(data => setPokemon(data.results)).catch(error => console.log("Somthing went wrong", error))

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
