import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import React, { useEffect, useState } from 'react';
import TitleBlock from '../Components/TitleBlock';

export default function AllAlbuns({count=8})
{
  const [allAlbuns,setAllAlbuns] = useState ([]);
  useEffect(()=>{
    fetch('https://jsonplaceholder.typicode.com/albums')
    .then(response => response.json())
    .then((jsonData)=> {setAllAlbuns(jsonData)})
  }, [])

  return (
    <div className="flex flex-col">
      <TitleBlock title="Albuns" icon="compact-disc"/>
      <div className="flex flex-row flex-wrap _albuns-blocks">
        {allAlbuns
          .slice(0,count)
          .map((_album,index)=>
          (<Album title={_album.title} index={index}/>))}
      </div>
    </div>
  )
}

function Album({title,index})
{
  return (
    <div className="p-2" key={index}>
      <div 
        // href="album=0" 
        // onClick={(e)=>e.preventDefault()}
        className="flex flex-col border border-gray-700 p-2 py-4"
        style={{backgroundColor: '#131313'}}>
          <div className="flex justify-center text-6xl">
            <FontAwesomeIcon icon="compact-disc"/>
          </div>
          <div className="pt-2 text-center">
            <span>{title}</span>
          </div>
        </div>
    </div>
  )
}