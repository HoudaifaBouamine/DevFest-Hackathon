import React,{useState} from 'react'
import "./style/chooseIdantity.css"
import InputField from '../../compenenet/InputField'
import GoogleButton from '../../compenenet/SecondaryButtonIcon'
import CTA_button from '../../compenenet/BigCTA_Button'
import icon from "../../assets/googleIcon.svg"
import "../../compenenet/styles.css"
import { API_URL } from '../../compenenet/urll'
import { Navigate } from 'react-router-dom'
const chooseIdantity = () => {
    const [userIdantity,setuserIdantity]=useState("")
const loginClickHandler =(e)=>{
    e.preventDefault();
setuserIdantity(e.target.innerHTML);

//we get th id from th navigate section 
 }

  return (
    <div className="split-container"> 
    <div className="image-side">
    </div>
    <div className="color-side">
     <div className='hero-page'> 
     <div className='main-div'>
       <h1 className='main-title'>Tell us about your Job</h1>
       <p className='paragraph'>Please select one of the following roles that would be beneficial to you</p>
       </div>
       <div className='divTwo'>
      <button onClick={loginClickHandler} className="secondary-button-icon">Front-end Developer</button>
      <button onClick={loginClickHandler} className="secondary-button-icon">Back-end Developer</button>
      <button onClick={loginClickHandler} className="secondary-button-icon">UI/UX Designer</button>
      <button onClick={loginClickHandler} className="secondary-button-icon">Others</button>
      </div>
     </div>
  </div>
</div>
  )
}

export default chooseIdantity
