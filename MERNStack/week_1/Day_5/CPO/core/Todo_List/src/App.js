import './App.css';
import Display from './components/Display';
import Form from './components/Form';
import { useState } from 'react';


function App() {

  // we did fake data 
  const PostList = [
    {
      title : "Get Mern Black Belt",
      
      read : true ,
    },
    {
      title : "Get Python Black belt",
      
      read : false,
    },
    {
      title : "Get Java Black belt",
    
      read : false,
    },

  ]
  // we did const usestate for posts and in the usestate ins gonna 
  // be tne name const of the fake date  
  const [posts , setPost] = useState(PostList);

  // const updatePosts = (newpost)=>{
  //   setPost([...posts, newpost]) 


  // };

  //delete post 
  const deletePost = (postId)=> {
    // console.log("hellooo" , postId)
    const updatedPost = posts.filter((element, idx) =>{
      console.log(idx)
      return idx != postId ; 
    }) ;
    // console.log(updatedPost)
    // we confirm our delete function  !->
    setPost(updatedPost);
    // console.log(setPost)
  }

  //check watched post 

  const checkWatched = (postId)=>{
    //we do copy fom poslit mte3i
    const copyPosts = [...posts];
    copyPosts[postId].read = !copyPosts[postId].read 
    setPost(copyPosts);

  }
  return(


    <fieldset>
      <legend>App.js</legend>
      <div className="App">
        <h1>Lifting state  </h1>
        {posts.length>0 ? <h4>{posts.length}Belts </h4> : <h4>Nothing found</h4>}
      </div>
      {/* <Form updatePosts = {updatePosts} /> */}
      <Form setPost = {setPost} posts={posts} />
      <Display posts = {posts} deletePost = {deletePost} checkWatched={checkWatched}  />

      </fieldset>
  ); 




  
  };

export default App;
