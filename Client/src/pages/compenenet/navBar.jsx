import React from 'react'
import Logo from "../../assets/logo.svg"
import "./styles.css"
const navBar = () => {
  const GoToLogIn = (e)=>{
    e.preventDefault()
   
    //the path
  }
  const  GoToSinUp = (e)=>{
    e.preventDefault()
    
    // the path
  }
  return (
    <div className='hero-navbar'>
      <img src={Logo} className='logo'/>
       <div className='frame1'>
       <button onClick={GoToLogIn} className='secondary-button'  >Log In</button>
       <button onClick={GoToSinUp} className='CTA-button'  >Get Started</button>
       </div>
    </div>
  )
}

export default navBar
