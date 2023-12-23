
import './App.css';
import BoxDisplay from './components/BoxDisplay';
import { useState } from 'react';

function App() {
  const[box,setBox]= useState("");
  const[bar,setBar]= useState([]);
  console.log(box)
  const handleSubmit =(e)=> {
      e.preventDefault();
      setBar([...bar,box])
      setBox('')
  };
  return (
  <form className='form' onSubmit={handleSubmit}>
      <h1>Color</h1>
      <input type="color" onChange={(e)=>{setBox(e.target.value)}}/>
    <button>Add</button>
    <BoxDisplay boxs={bar} />
  </form>
)
}

export default App;

// *import './App.css';
// import BoxDisplay from './components/BoxDisplay';
// import { useState } from 'react';

// function App() {
//   const[box,setBox]= useState("");
//   const[bar,setBar]= useState([]);
//   console.log(box)
//   const handleSubmit =(e)=> {
//       e.preventDefault();
//       setBar([...bar,box])
//       setBox('')
//   };
//   return (
//   <form className='form' onSubmit={handleSubmit}>
//       <h1>Color</h1>
//       <input type="color" onChange={(e)=>{setBox(e.target.value)}}/>
//     <button>Add</button>
//     <BoxDisplay boxs={bar} />
//   </form>
// )
// }

// export default App;
// import React from 'react';

// const BoxDisplay = ({ boxs }) => {
//   console.log(boxs);

//   return (
//     <div>
//       {boxs.map((element, idx) => (
//         <div key={idx} style={{ backgroundColor: ${element}, width: "100px", height: "100px" }}>
//           <h2>{idx}</h2>
//         </div>
//       ))}
//     </div>
//   );
// };

// export default BoxDisplay;