import React, { useState } from 'react'
import "./style/LogInForm.css"
import InputField from '../compenenet/InputField'
import GoogleButton from '../compenenet/SecondaryButtonIcon'
import CTA_button from '../compenenet/BigCTA_Button'
import icon from "../../assets/googleIcon.svg"
  
import { API_URL } from '../compenenet/urll'
import { Navigate, useNavigate } from 'react-router-dom'

const LogInForm =  () => {
  const setValue = ()=>{

  }
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const loginClickHandler = async (e) => {
    e.preventDefault();
    try{
    const response = await fetch(`${API_URL}/login`,{
      method: "POST",
      headers : new Headers( { 'ngrok-skip-browser-warning' : '1', 'content-type' : 'application/json' } ),
      body: JSON.stringify({
        email: username,
        password: password,
      }),
    })
    const data = await response.json() ; 
     if (data){
      console.log(data); 
     /* Navigate(`/home/${data.user_Id}`);*/
     }
    }catch (e) { 
      const Navigate=useNavigate("");
      Navigate("");
      console.log("hello mother fucker");
    }
  };
  return (
    <div className='Hero-logIn-singInPage'>
      <h1 className='Hero-title-singInPage'>Welcome Back!</h1 >
    <div className='userName-singInPage'>
      <p className='usernameParagraph-singInPage'>Username</p>     
      <input onChange={(event)=>setUsername(event.target.value)}  placeholder={"moh riad"} />
    </div>    
      <div className='Password-singInPage'>
        <p className='PasswordParagraph-singInPage'>Password</p>
        <input onChange={(event)=>setPassword(event.target.value)} placeholder={"Password"}  className="input" />
      </div> 
     <button onClick={loginClickHandler} className="big-CTA-button-singInPage">log in </button>
     <div className='forgotPasSection-singInPage'>
     <a className='forgotPas-singInPage'>Forgot Password ?</a>
     </div>

  <section className='container-singInPage'>
   <div className='horizontal-line1-singInPage'></div>
   <p className='or-singInPage'>Or</p>
  <div className='horizontal-line1-singInPage'></div>  
  </section>
  <GoogleButton text={"Continue with Google"} Icon={icon}></GoogleButton>
  <div className='noAccount-singInPage'>
  <p className='noAccountParagraph-singInPage'>Don't have an account</p>
 <a className='noAccountParagraph2-singInPage'>Log In</a>
  </div>
    </div>
  )
}
export default LogInForm