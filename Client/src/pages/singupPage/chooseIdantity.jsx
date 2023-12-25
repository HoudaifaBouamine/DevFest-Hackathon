import React,{useState} from 'react'
import "./style/chooseIdantity.css"
import InputField from '../compenenet/InputField'
import GoogleButton from '../compenenet/SecondaryButtonIcon'
import CTA_button from '../compenenet/BigCTA_Button'
import icon from "../../assets/googleIcon.svg"
import { API_URL } from '../compenenet/urll'
import { useNavigate } from 'react-router-dom'
const chooseIdantity = () => {
    const [userIdantity,setuserIdantity]=useState("")
const loginClickHandler =(e)=>{
    e.preventDefault();
setuserIdantity(e.target.innerHTML);

//we get th id from th navigate section 
 }

  return (
    <div className="split-container-chooseIdantity"> 
    <div className="image-side-chooseIdantity">
    </div>
    <div className="color-side-chooseIdantity">
     <div className='hero-page-chooseIdantity'> 
     <div className='main-div-chooseIdantity'>
       <h1 className='main-title-chooseIdantity'>Tell us about your Job</h1>
       <p className='paragraph-chooseIdantity'>Please select one of the following roles that would be beneficial to you</p>
       </div>
       <div className='divTwo-chooseIdantity'>
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
