import React, { useState } from 'react'
import "./style/LogInForm.css"
import InputField from '../../compenenet/InputField'
import GoogleButton from '../../compenenet/SecondaryButtonIcon'
import CTA_button from '../../compenenet/BigCTA_Button'
import icon from "../../assets/googleIcon.svg"
import "../../compenenet/styles.css"
import { API_URL } from '../../compenenet/urll'
import { Navigate } from 'react-router-dom'

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
      console.log("hello mother fucker");
    }
  };
  return (
    <div className='Hero-logIn'>
      <h1 className='Hero-title'>Welcome Back!</h1 >
    <div className='userName'>
      <p className='usernameParagraph'>Username</p>     
      <input onChange={(event)=>setUsername(event.target.value)}  placeholder={"moh riad"} />
    </div>    
      <div className='Password'>
        <p className='PasswordParagraph'>Password</p>
        <input onChange={(event)=>setPassword(event.target.value)} placeholder={"Password"}  className="input" />
      </div> 
     <button onClick={loginClickHandler} className="big-CTA-button">log in </button>
     <div className='forgotPasSection'>
     <a className='forgotPas'>Forgot Password ?</a>
     </div>

  <section className='container'>
   <div className='horizontal-line1'></div>
   <p className='or'>Or</p>
  <div className='horizontal-line1'></div>  
  </section>
  <GoogleButton text={"Continue with Google"} Icon={icon}></GoogleButton>
  <div className='noAccount'>
  <p className='noAccountParagraph'>Don’t have an account</p>
 <a className='noAccountParagraph2'>Log In</a>
  </div>
    </div>
  )
}
export default LogInForm