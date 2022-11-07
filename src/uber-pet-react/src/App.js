import React from 'react';
import {library} from '@fortawesome/fontawesome-svg-core';
import {far} from '@fortawesome/free-regular-svg-icons';
import {faCheckSquare, faClipboardCheck, faSquare, faFileAlt, faCompactDisc, faHome} from '@fortawesome/free-solid-svg-icons';

import MainMenu from './Pages/MainMenu';
import AllAlbuns from './Pages/AllAlbuns';
import Posts from './Pages/Posts';
import Todos from './Pages/Todos';
import Home from './Pages/Home';

import Tree01 from './Images/tree_01.png';
import ElipseSVG from './Images/BG_elipse_SVG.svg';

import {
  BrowserRouter as Router,
  Route,
  Switch,
  // useLocation
} from 'react-router-dom';


import './Styles/style.css';


library.add(far, faCheckSquare, faClipboardCheck, faSquare, faFileAlt, faCompactDisc, faHome);

function App() {
  return (
    <div 
      className="main-screen relative w-full h-full text-white flex flex-col overflow-y-auto" 
      style={{backgroundImage: `url(${ElipseSVG})` }}>
      <img src={Tree01} alt="Tree" className="fixed image-blur bottom-0 right-0 w-1/2 z-0" width="727" height="857"/>
      <Router>
        <MainMenu/>
        <Routes/>
      </Router>
    </div>
  );
}

function Routes()
{
  return(
    <div className="lg:w-1/2 md:w-3/4 w-auto my-auto z-4 mt-14">
      <div className="mx-4 h-full">
        <Switch>
          <Route path="/albuns">{/** its path, not pack... :p */}
            <AllAlbuns/>
          </Route>
          <Route path="/posts">
            <Posts/>
          </Route>
          <Route path="/todos">
            <Todos count='10'/>
          </Route>

          <Route path="/">
            <Home/>
          </Route>
        </Switch>
      </div>
    </div>
  )
}


export default App;