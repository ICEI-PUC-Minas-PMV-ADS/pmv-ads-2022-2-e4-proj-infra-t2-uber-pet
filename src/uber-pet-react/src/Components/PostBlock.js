
import React from 'react';
import {Link} from 'react-router-dom';

export default function PostBlock({type=1,id,userId,link,title,content})
{
  // const _start = index==='-1'? 
  //   (<div to={link} className="flex flex-col m-2 py-2 border border-gray-800 shadow-md ring-gray-600 z-0" style={{backgroundColor: '#131313'}}>): 
  //   (<Link to={link} className="flex flex-col m-2 py-2 border border-gray-800 shadow-md ring-gray-600 z-0" style={{backgroundColor: '#131313'}}>);

  const _content = (<ContentContent content={content} title={title}/>)
  const ShowThis = (<NoLinkContent content={_content}/>)

  return(
    <div>
      {ShowThis}
    </div>
  )
}

function ContentContent({title,content})
{
  return (
    <div className="flex flex-col ">
      <div className="text-lg font-bold text-center p-2">
        <span>{title}</span>
      </div>
      <div className="px-4 py-2 text-sm">
        <span>{content}</span>
      </div>
    </div>
  )
}

function LinkContent({content,link})
{
  return(
    <Link 
      to={link} 
      className="flex flex-col m-2 py-2 border border-gray-800 shadow-md ring-gray-600 z-0" 
      style={{backgroundColor: '#131313'}}
    >
      {content}
    </Link>
  )
}

function NoLinkContent({content})
{
  return(
    <div 
      // to={link} 
      className="flex flex-col m-2 py-2 border border-gray-800 shadow-md ring-gray-600 z-0" 
      style={{backgroundColor: '#131313'}}
    >
      {content}
    </div>
  )
}