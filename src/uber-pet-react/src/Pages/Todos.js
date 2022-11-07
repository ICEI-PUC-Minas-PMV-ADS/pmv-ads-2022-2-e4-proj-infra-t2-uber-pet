import React, { useEffect, useState } from 'react';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'

import TitleBlock from '../Components/TitleBlock';

export default function Todos({count='1'})
{
  const [todos,setTodos] = useState([]);
  useEffect (()=> {
    fetch('https://jsonplaceholder.typicode.com/todos')
    .then(response => response.json())
    .then((jsonData)=>{
      setTodos(jsonData);
    })
  }, []);

  return(
    <div className="flex flex-col">
      <TitleBlock title="To Do's" icon="clipboard-check"/>
      <div className="mx-2">
        {todos.slice(0,count).map((todo,index)=>(<TodoBlock complete={todo.completed} title={todo.title} index={index}/>))}
      </div>
    </div>
  )
}


function TodoBlock({title,complete=false,index})
{
  const _checked = complete ? ['far','square'] : ['far','check-square'];
  return (
    <div>
      <a 
        href={`todo=${index}` }
        onClick={(e)=>e.preventDefault()}
        className="flex text-lg border border-gray-700 my-2"
        style={{backgroundColor: '#131313'}}>
        <div className="flex flec-row py-2 px-2">
          <div className="pr-4 pl-2"><FontAwesomeIcon icon={_checked}/></div>
          <div>
            <span>{title}</span>
          </div>
        </div>
      </a>
    </div>
  )
}