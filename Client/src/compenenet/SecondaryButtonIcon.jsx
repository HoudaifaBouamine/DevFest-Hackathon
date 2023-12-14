import React from 'react'
import './styles.css'
import  GoogleIcon  from '../assets/googleIcon.svg';
const SecondaryButtonIcon = ({text,onclick}) => {
  return (
      <button onclick={onclick} className='secondary-button-icon'>
    <img className='GoogleImg' src={GoogleIcon}></img>
      {text}</button>
  )
}

export default SecondaryButtonIcon  
