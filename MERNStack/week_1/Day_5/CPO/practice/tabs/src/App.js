// import { useState } from 'react';
// import './App.css';

// function App() {



//   const [state , setstate] = useState(1);

//   const action = (index)=> {

//     setstate(index)
//     console.log(index) 

//   }




//   return (
//     <div className="App">
//         <div className="box">

//             <div className='tabs'>
//               <div onClick={() => action(1)} className={`${state===1 ? 'tab active-tab':'tab'}`}>
//                 tab 1
//               </div>
//               <div onClick={() => action(2)}  className={`${state===2 ? 'tab active-tab':'tab'}`}>
//                 tab 2
//               </div>
//               <div onClick={() => action(3)}  className={`${state===3 ? 'tab active-tab':'tab'}`}>
//                 tab 3
//               </div>
//             </div>

//             <div className="contents">
//               <div className={`${state ===1 ? 'content active-content': 'content'}`}>
//                 this is content 1
//               </div>
//               <div  className={`${state ===2 ? 'content active-content': 'content'}`}>
//                 this is content 2
//               </div>
//               <div  className={`${state ===3 ? 'content active-content': 'content'}`}>
//                 this is content 3
//               </div>


//             </div>


//           </div>




//         </div>

//   );
// }

// export default App;


import React from 'react';
import Tabs from './components/Tabs';
import './App.css';


const App = () => {
  const tabsItems = [
    { label: 'Tab 1', content: 'Tab 1 content is showing here.' },
    { label: 'Tab 2', content: 'Tab 2 content is showing here.' },
    { label: 'Tab 3', content: 'Tab 3 content is showing here.' },
  ];

  return (
    <div className="App">
      <Tabs items={tabsItems} />
    </div>
  );
};

export default App;
