import React from 'react'
import { useState } from 'react'

function Displayform() {
    const [firstname , setFirstname] = useState("")
    const [lastname, setlastName] = useState("")
    const [email , setEmail] = useState("")
    const [password , setPassword] = useState("")
    const [confirmpassword , setConfirm] = useState("")

    const dataUser = (e)=>{
        e.preventDefault();

    const user={
        firstname :firstname , 
        lastname :lastname , 
        email :email,
        password :password ,
        confirmpassword:confirmpassword
    }
    }

  return (
    <div>
        <form  onSubmit={dataUser}>
            <label >First name :</label>
            <input type="text" onChange={ (e) => setFirstname(e.target.value) }   /><br />
            <label >last name :</label>
            <input type="text"  onChange={ (e) => setlastName(e.target.value) } /><br />
            <label >Email:</label>
            <input type="text" onChange={ (e) => setEmail(e.target.value) }  /><br />
            <label >Password :</label>
            <input type="password" onChange={ (e) => setConfirm(e.target.value) }  /><br />
            <label >Confirm password:</label>
            <input type="password" /><br />
            <button>Submit</button>

            
        </form>
        <h1>Your Form Data</h1>
        <p>{firstname}</p>
        <p>{lastname}</p>
        <p>{email}</p>
        <p>{password}</p>
        <p>{confirmpassword}</p>
    </div>
  );
}

export default Displayform