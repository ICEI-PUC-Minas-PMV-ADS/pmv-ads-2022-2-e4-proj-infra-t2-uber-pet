import React from 'react';
import {Link} from 'react-router-dom';

export default function MainMenu()
{
  const _links = [
    {link:'/',title:'Home'},
    {link:'/posts',title:'Postagens'},
    {link:'/todos',title:'TO-DO\'s'},
    {link:'/albuns',title:'Albuns'}
  ]
  return(
    <nav className="flex h-12 z-10 fixed left-0 right-0 top-0 backdrop-filter backdrop-blur-sm">
      <ul className="flex flex-1 flex-row justify-start w-full h-full mr-20">
        {_links.map((_link,index)=> (
          <MenuLink title={_link.title} link={_link.link} index={index}/>
        ))}
      </ul>
    </nav>
  )
}

function MenuLink({title,link,index})
{
  const _linkClass = "px-2 flex flex-col justify-center";
  const _first = index === 0 ? "mr-auto flex ml-2" : "flex mx-2"; 
  return(
    <li className={_first} key={index}>
      <Link className={_linkClass} to={link}>
        <span className="float-left">{title}</span>
      </Link>
    </li>
  )
}