import React from 'react'
import './styles.css'

const BigCTA_Button = ({text,onclick}) => {
  return (
       <button className='big-CTA-button' onClick={onclick}>{text}</button>
  )
}
export default BigCTA_Button
