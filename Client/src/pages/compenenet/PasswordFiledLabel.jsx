import React from 'react'
import './styles.css'
import InputField from './InputField'
// import PasswordField from './PasswordField'

const PasswordFieldLabel= ({labelText})=>{
    return (
        <div className='input-label'>
            <label htmlFor="">{labelText}</label>
    
        </div>
    )
}

export default PasswordFieldLabel