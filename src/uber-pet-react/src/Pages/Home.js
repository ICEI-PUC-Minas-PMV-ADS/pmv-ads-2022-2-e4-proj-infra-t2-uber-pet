
import React from 'react';
// import TitleBlock from '../Components/TitleBlock';
import AllAlbuns from './AllAlbuns';
import Posts from './Posts';
import Todos from './Todos';


export default function Home()
{
  return(
    <div className="flex flex-col">
      {/* <TitleBlock title="Início" icon="home"/> */}
      <Todos count='1'/>
      <AllAlbuns count='4'/>
      <Posts home='true' count='3'/>
    </div>
  )
}