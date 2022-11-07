import React, { useEffect, useState } from 'react';
import PostBlock from '../Components/PostBlock';
import TitleBlock from '../Components/TitleBlock';

import {useRouteMatch,Switch,Route,useParams} from 'react-router-dom';
// import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';

export default function Posts({home=false,count='10'})
{
  const _posts = home ? (<VariousPosts count={count}/>) : (<PostsRecents count={count}/>);

  return(
    <div className="flex flex-col">
      <TitleBlock title='Postagens' icon='file-alt'/>
      {_posts}
    </div>
  )
}

function PostsRecents({count='10'})
{
  return (
    <div className="flex flex-row _posts">
      <Switch>
        <Route path={`posts/:postId`}>
          <SinglePost/>
        </Route>
        <Route path="/posts">
          <VariousPosts count={count} link='true'/>
            {/* <PostBlock index='-1' id='1' link={`${match.url}/1`} title='random title' content='Mollit irure dolor sint deserunt velit duis reprehenderit amet dolore adipisicing.'/>
            <PostBlock index='-1' id='1' link={`${match.url}/1`} title='random title' content='Mollit irure dolor sint deserunt velit duis reprehenderit amet dolore adipisicing.'/>
            <PostBlock index='-1' id='1' link={`${match.url}/1`} title='random title' content='Mollit irure dolor sint deserunt velit duis reprehenderit amet dolore adipisicing.'/>
            <PostBlock index='-1' id='1' link={`${match.url}/1`} title='random title' content='Mollit irure dolor sint deserunt velit duis reprehenderit amet dolore adipisicing.'/>
            <PostBlock index='-1' id='1' link={`${match.url}/1`} title='random title' content='Mollit irure dolor sint deserunt velit duis reprehenderit amet dolore adipisicing.'/> */}
        </Route>
      </Switch>
    </div>
  )
}

function VariousPosts({count=10,link=false})
{
  const match = useRouteMatch();

  const [posts,setPosts] = useState([]);
  useEffect(()=>{
    fetch('https://jsonplaceholder.typicode.com/posts')
    .then(response => response.json())
    .then((jsonData)=>{
      setPosts(jsonData);
    })
    .catch((error)=>console.error( "Fetch error: "+ error))
  }, []);

  return(
    <div className="flex flex-row _posts">
      {posts
        .slice(0,count)
        .map((post,index)=>
          (<PostBlock index={index} id={post.id} title={post.title} content={post.body} link={link ? `${match.path}/${post.id}` : `post/${post.id}`}/>))
      }
    </div>
  )
}

function SinglePost()
{
  let postId = useParams();
  const match = useRouteMatch();


  return (
    <PostBlock index={postId} type='0' id={postId} link={`${match.url}/1`} title='random title' content='Mollit irure dolor sint deserunt velit duis reprehenderit amet dolore adipisicing.'/>
  )
}