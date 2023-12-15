import React from 'react'
import "./style/logInpage.css"
import LogInForm from "./form"
const SingInPage = () => {
  return (
    <div>
      <div class="split-container"> 
      <div class="image-side">

        <h1 className='hero-title'>Hear from experienced individuals</h1>
        <h1 className='hero-title1'>LOGO</h1>
      </div>
      <div class="color-side">
       
      <LogInForm></LogInForm>
      </div>    
      </div>
  </div>
  )
}

export default SingInPage
