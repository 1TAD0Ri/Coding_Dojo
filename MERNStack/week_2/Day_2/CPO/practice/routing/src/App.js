import React from 'react';
import { Routes, Route, Link } from 'react-router-dom';
import WelcomePage from './components/WelcomePage';
import Hello from './components/Hello';
import Home from './components/Home';
import Number from './components/Number';
import ColorHelloPage from './components/ColorHelloPage';








const App = () => {
  return (
    <div>
    

      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/welcome" element={<WelcomePage />} />
        <Route path="/:word" element={<Hello />} />
        <Route path="/:number" element={<Number />} />
        <Route path="/:word/:textcolor/:bgcolor" element={<ColorHelloPage />} />
      </Routes>
    </div>

  );
};

export default App;
