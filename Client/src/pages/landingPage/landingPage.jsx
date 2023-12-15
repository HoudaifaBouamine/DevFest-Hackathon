import React from 'react'
import NavBar from '../compenenet/navBar'
import "./style/landingPage.css"
import Pageone from './pageone'
import  Pagetwo from './pagetwo'
import Section3 from './assets/feature1.svg'
import Section4 from "./assets/Frame 100.svg"
import Section5 from "./assets/Frame 120.svg"
const landingPage = () => {
  return (
    <div>
    <Pageone/>
    <Pagetwo/>
     <div>
      <img src={Section3} className='section3' ></img>
     </div>
      <div className='section4'>
      <img src={Section4} className='section3' />
      </div>
      <div className='section5'>
      <img src={Section5} className='section3'/>
      </div>

 
    </div>
  )
}

export default landingPage
