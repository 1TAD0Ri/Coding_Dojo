import React from 'react';
import { useParams } from 'react-router-dom';

const ColoredWordPage = () => {
  const { word, textcolor, bgcolor } = useParams();

  const style = {
    color: textcolor,
    backgroundColor: bgcolor,
  };

  return (
    <div style={style}>
      {isNaN(word) ? (
        <h1>This Number is: {word}</h1>
      ) : (
        <h1>This word is: {word}</h1>
      )}
    </div>
  );
};

export default ColoredWordPage;
