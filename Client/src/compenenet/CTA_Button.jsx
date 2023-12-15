import React from 'react'
import './styles.css'

const CTA_button = ({text,onclick}) => {
  return (
       <button onClick={onclick} className='CTA-button'>{text} </button>
  )
}
export default CTA_button
