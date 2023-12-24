// Display.jsx

import React from 'react';

const Display = ({ posts, deletePost, checkWatched }) => {
    return (
        <fieldset>
            <legend>Display.jsx</legend>
            <div>
                <ul>
                    {posts.map((newPost, idx) => {
                        return (
                            <li key={idx}>
                                <button onClick={() => deletePost(idx)}>Delete</button>
                                <p>
                                    <span className={newPost.read ? 'checked' : ''}>{newPost.title}</span>
                                    <span>{newPost.read && ": We did it"}</span>
                                </p>
                                <input type="checkbox" onChange={(e) => { checkWatched(idx) }} checked={newPost.read} /> <label> Done</label>
                            </li>
                        );
                    })}
                </ul>
            </div>
        </fieldset>
    );
};

export default Display;


// import React from 'react'

// const Display = ({posts , deletePost , checkWatched}) => {
//     // const { posts } = props;
//     return (
//         <fieldset>
//             <legend>Display.jsx</legend>
//             <div>

//                 <ul>
//                     {posts.map((newPost , idx) => {
//                         return <li key={idx}>
//                             <button onClick={()=> deletePost(idx)}>Delete</button>
//                             <p>{newPost.title} <span>{newPost.read && ": We did it"} </span> </p>
                            
//                             <input type="checkbox" onChange={(e)=> {checkWatched(idx)}} checked={newPost.read} /> <label> Done</label>
//                             </li>
                            
//                     })}
//                 </ul>
//             </div>
//         </fieldset>
//     )
// }

// export default Display
