import './App.css';
import React from 'react';
import DisplayPerson from './components/DisplayPerson';
// import React, { useState } from 'react';



function App() {
  const person1={
    first:'Doe',
    last:'Jane',
    age:45,
    color:"Black"
  }
  const person2={
    first:'Smith',
    last:'John',
    age:88,
    color:"Brown"
  }
  const person3={
    first:'Fillmore',
    last:'Millard',
    age:50,
    color:"Brown"
  }
  const person4={
    first:'Smith',
    last:'Maria',
    age:62,
    color:"Brown"
  }
  return (
      <div className="App">
          <DisplayPerson prop1={ person1} />
          <DisplayPerson prop1={ person2} />
          <DisplayPerson prop1={ person3} />
          <DisplayPerson prop1={ person4} />
      </div>
  );
}




export default App;
