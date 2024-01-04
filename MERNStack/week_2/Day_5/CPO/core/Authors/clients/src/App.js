import logo from './logo.svg';
import './App.css';
import {Routes, Route} from 'react-router-dom';
import AllAuthors from './components/AllAuthors';
import EditAuthor from './components/EditAuthor';
import CreateAuthor from './components/CreateAuthor';

function App() {
  return (
    <div className="App">
      <Routes>
      <Route path='/' Component={AllAuthors}/>
        <Route path='/authors' Component={AllAuthors}/>
        <Route path='/authors/new' Component={CreateAuthor}/>
        <Route path='/authors/:id' Component={EditAuthor}/>


      </Routes>

    </div>
  );
}

export default App;
