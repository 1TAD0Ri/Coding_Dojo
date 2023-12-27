import './App.css'
import React from 'react';
import { Routes, Route, Link } from 'react-router-dom';
import axios from 'axios';
import Planets from './components/Planets';
import PeopleStarWars from './components/PeopleStarWars';
import SearchBar from './View/SearchBar';









const App = () => {
  return (
    <div>
      <SearchBar/>
    <Routes>
      <Route path='/people/:id' element={<PeopleStarWars/>}/>
      <Route path='/planets/:id' element={<Planets/>}/>
    

    </Routes>

    
    </div>

  );
};

export default App;
