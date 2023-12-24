import { useState } from "react"
// const Form = ({updatePosts}) 
const Form = ({ posts ,  setPost}) => {
    const [title , setTitle] = useState("");
    const [body , SetBody] = useState("");

    


    //handleSubmit
    const handleSubmit = (e)=>{
        e.preventDefault();
        //condition for no add emty posts 
        if(!body && !title){
            return ;
        }
        const newPost = {
            title,
            body,
        };
        // setTitle("");
        // SetBody("");
        setPost([...posts,newPost])
        setTitle("");
        SetBody("");  
        // updatePosts(newPost);
    }

    return (
        <fieldset>

            <legend>Form.jsx</legend>
            <div>
                <form  onSubmit={handleSubmit}>
                        {/* <p>{JSON.stringify(title)}</p>
                        <p>{JSON.stringify(body)}</p> */}
                        {/* <p>{title == ""?"":title.length<4?"invalid":"" }</p> */}
                    <input type="text" placeholder='Title' onChange={(e)=>{setTitle(e.target.value)}} value={title} />
                    <textarea placeholder='Body' onChange={(e)=>{SetBody(e.target.value)}} value={body}  ></textarea>
                    <button>Add Post</button>



                </form>
            </div>
        </fieldset>


    )
}

export default Form