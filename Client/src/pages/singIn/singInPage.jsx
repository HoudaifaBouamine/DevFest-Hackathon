import React from 'react'
import Form from './form'
const singIn = () => {
  return (
    <div class="split-container">
      
    <div class="image-side">
      <img  className="TheX" src={TheX}></img>

      <h1 className='hero-title'>Hear from experienced individuals</h1>
      <h1 className='hero-title1'>LOGO</h1>
    </div>
    <div class="color-side">
      <div className='LogInForm'> 
    <Form></Form>
    </div>
    <img  className="Sagittarius" src={Sagittarius}></img>
      <img  className="Vector" src={Vector}></img>
      
    </div>

</div>
  )
}

export default singIn




