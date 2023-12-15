import React from 'react'
import "./style/LogInForm.css"
import InputField from '../../compenenet/InputField'
import GoogleButton from '../../compenenet/SecondaryButtonIcon'
import CTA_button from '../../compenenet/BigCTA_Button'
import icon from "../../assets/googleIcon.svg"
const LogInForm = () => {
  return (
    <div className='Hero-logIn'>
      <h1 className='Hero-title'>Welcome Back!</h1 >
    <div className='userName'>
      <p className='usernameParagraph'>Username</p>     
      <InputField placeHolder={"moh riad"}/>
    </div>    
      <div className='Password'>
        <p className='PasswordParagraph'>Password</p>
        <InputField placeHolder={"Password"}/>
      </div> 
     <CTA_button  text={"Log In"}/>
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