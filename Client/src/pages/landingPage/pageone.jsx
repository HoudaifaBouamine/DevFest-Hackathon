import React from 'react'
import NavBar from '../../compenenet/navBar'
import "./style/pageone.css"
import Ellipse167 from "./assets/Ellipse 167.svg"
import Ellipse168 from "./assets/Ellipse 168.svg"
import Ellipse170 from "./assets/Ellipse 170.svg"
import Ellipse171 from "./assets/Ellipse 171.svg"
import Ellipse172 from "./assets/Ellipse 172.svg"
import frame1 from "./assets/Frame-1.svg"
import frame from "./assets/Frame.svg"
import stare from "./assets/stare shape.svg"
const pageone = () => {
  return (
    <div>
    <div className='Hero-page'>
      <NavBar/>
      <img src={stare} className='stare' />
      <img src={Ellipse172} className='Ellipse172'/>
     {/* <img src={frame1} className='frame1'/>
      <img src={Ellipse172} className='Ellipse172'/>
      <img src={stare} className='stare'/>*/}
  <div className='heroPage'>
        
      </div>
    </div>
    </div>
  )
}

export default pageone
