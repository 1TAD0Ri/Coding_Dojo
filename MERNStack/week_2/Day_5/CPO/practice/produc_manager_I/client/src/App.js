import './App.css';
import Form from './components/Form';

function App() {
  return (
    <div className="App">
       <Routes>
        <Route path='/products' Component={AllProducts} />
        <Route path='/products' Component={Form}/>
        
      </Routes>
    </div>
  );
}

export default App;
