import React from 'react'
import NavBar from '../compenenet/navBar'
import "./style/pageone.css"
import Ellipse167 from "./assets/Ellipse 167.svg"
import Ellipse168 from "./assets/Ellipse 168.svg"
import Ellipse170 from "./assets/Ellipse 170.svg"
import Ellipse171 from "./assets/Ellipse 171.svg"
import Ellipse172 from "./assets/Ellipse 172.svg"
import frame1 from "./assets/Frame-1.svg"
import frame from "./assets/Frame.svg"
import stare from "./assets/stare shape.svg"
import Hero from "./assets/Mask group.svg"
import Pagetwo from "./pagetwo"
import { useNavigate } from 'react-router-dom'
const pageone = () => {
  const Navigate = useNavigate("");
  const  GoToSinUp = (e)=>{
    e.preventDefault()
    Navigate("/SingUp")
    // the path
  }
  return (
   
    <div className='section1'>
      <NavBar/>
      <img src={stare} className='stare' />
      <img src={Ellipse172} className='Ellipse172'/>
      <img src={Ellipse170} className='Ellipse170'/>
      <img src={Ellipse171} className='Ellipse171'/>
      <img src={Ellipse167} className='Ellipse167'/>
      <img src={Ellipse168} className='Ellipse168'/>
      <img src={frame1} className='framll'/>
      
  <div className='heroPage1'>
  <div className='hero-text'>
            <h1 className='hero-text1'>Develop <span className='hero-text2'> Peaceful</span> Solutions</h1>
            <p className='hero-paragraph1'>Collaborate, Donate, and Share Your Ideas! Be a Developer and Contribute to Projects for Peace</p>        
             <button onClick={GoToSinUp} className='CTA-button'>Get Started</button>
          </div>
          <img src={Hero} className='hero-imag'></img>
        </div>
      
    </div>
  
 
  )
}

export default pageone
