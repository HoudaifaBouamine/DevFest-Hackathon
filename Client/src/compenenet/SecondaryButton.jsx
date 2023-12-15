import React from 'react'
import './styles.css'

const SecondaryButton = ({text,onclick}) => {
  return (
      <button onClick={onclick}  className='secondary-button'>{text}</button>
  )
}

export default SecondaryButton
