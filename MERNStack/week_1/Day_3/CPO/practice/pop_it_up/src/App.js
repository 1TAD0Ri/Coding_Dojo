import './App.css';
import React from 'react';
import DisplayPerson from './components/DisplayPerson';


function App() {

  return (
    <div className='App'>
      <DisplayPerson name="illo"
      lastName = "illouuuuuu"
      age = "22"
      hairColor = "black"
      />

<DisplayPerson name="anis"
      lastName = "boosss"
      age = "22"
      hairColor = "red"
      />

<DisplayPerson name="souleim"
      lastName = "msi"
      age = "70"
      hairColor = "yellow"
      />

<DisplayPerson name="aziz"
      lastName = "ZIZOOUU"
      age = "22"
      hairColor = "Red"
      />

    </div>
  );

}

export default App;
