import './App.css';
import AllProducts from './components/AllProducts';
import Form from './components/Form';
import { Routes, Route } from 'react-router-dom';
import PersonList from './components/PersonList';
import FormComponent from './components/Form';
import Edit from './components/Edit';


function App() {
  return (
    <div className="App">
      <Routes>
        <Route path='/people' element={<AllProducts />} />
        <Route path='/people/new' element={<FormComponent />} />
        <Route path='/people/:id' element={<Edit />} />


        {/* <Route path='/products' Component={AllProducts} /> */}
        <Route path='/people/:id' element={<PersonList />} />

      </Routes>
    </div>
  );
}

export default App;
