import React from 'react'
import Logo from "../../assets/logo.svg"
import "./styles.css"
import { useNavigate } from 'react-router-dom'

const navBar = () => {
  const Navigate = useNavigate("");
  const GoToLogIn = (e)=>{
    e.preventDefault()
   Navigate("/singIn")
    //the path
  }
  const  GoToSinUp = (e)=>{
    e.preventDefault()
    Navigate("/SingUp")
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
