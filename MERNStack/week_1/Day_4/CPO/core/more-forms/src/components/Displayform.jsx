import React from 'react'
import { useState } from 'react'

function Displayform() {
    const [firstname, setFirstname] = useState("")
    const [lastname, setlastName] = useState("")
    const [email, setEmail] = useState("")
    const [password, setPassword] = useState("")
    const [confirmpassword, setConfirm] = useState("")
    const [error, setError] = useState("")


    const [firsterror,setFirstNameError] = useState('')

    const dataUser = (e) => {
        e.preventDefault();

        const user = {
            firstname: firstname,
            lastname: lastname,
            email: email,
            password: password,
            confirmpassword: confirmpassword,
            error: error
        }


    }
    // const checkfirstname = (value) => {
    //     setFirstname(value)
    //     if(value==""){
    //         setFirstNameError('')
    //     }else{
    //         if (value.length < 2) {
    //             console.log("**********", value)
    //             setFirstNameError("First name must be at least 2 characters")
    //         } else {
    //             setFirstNameError("")
    //         }
    //     }
    //     }


    // }
    // const checklastname = (value) => {
    //     setlastName(value)
    //     if (value.length < 2) {
    //         console.log("**********", value)
    //         setError("Last name must be at least 2 characters")
    //     } else {
    //         setError("")
    //     }
    // }

    return (
        <div>
            <form onSubmit={dataUser}>
                <label >First name :</label>
                {/* <input type="text" onChange={(e) => checkfirstname(e.target.value)} /><br /> */}
                {/* <h3>{firsterror}</h3> */}
                {/* first just set the first name  */}
                <input type="text" onChange={(e) => setFirstname(e.target.value)} /><br />
                <h3>{firstname==""?"":firstname.length<2?"First Nmae must conatin at least 2 characters ":""}</h3>
                <label >last name :</label>
                <input type="text" onChange={(e) => setlastName(e.target.value)} /><br />
                <h3>{lastname==""?"":lastname.length<2?"Last Nmae must conatin at least 2 characters  ":""}</h3>
                <label >Email:</label>
                <input type="text" onChange={(e) => setEmail(e.target.value)} /><br />
                <h3>{email==""?"":email.length<2?"Email must conatin must conatin at least 2 characters  ":""}</h3>
                <label >Password :</label>
                <input type="password" onChange={(e) => setPassword(e.target.value)} /><br />
                <h3>{password==""?"":password.length<9?"password must conatin must conatin at least 8 characters  ":""}</h3>
                <label >Confirm password:</label>
                <input type="password" onChange={(e) => setConfirm(e.target.value)} /><br />
                {confirmpassword==""?"":confirmpassword!==password?"Password must be match ":""}
                <button type='submit'>Submit</button>


            </form>
    
        </div>
    );
}


export default Displayform