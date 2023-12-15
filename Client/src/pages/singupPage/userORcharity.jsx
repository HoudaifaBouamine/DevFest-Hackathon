import React,{useState} from 'react'   
import { NavLink, Navigate } from 'react-router-dom';
import  Member from "./assets/member.svg" ; 
import Associative  from "./assets/associative.svg";
import "./style/userORcharity.css"
import Input from "./assets/Input.svg"
import { FormControlLabel, Radio, RadioGroup } from '@mui/material';

const userORcharity = () => {
const [selectedOption, setSelectedOption] = useState('member');
const handleChange = (value) => {
  setSelectedOption(value);
  
};
    
  return (
    <div className='page'>
    <div className='Hero-page'>
      <div className='tite'>join us as user or association</div>
      <div className='input-field'>
      <div className='input-field1'>
      <div className="inside">
      <img src={Member} className='img'/>
      <FormControlLabel
        value="member"
        control={
          <Radio
            checked={selectedOption === 'member'}
            onChange={() => handleChange('member')}
            color="default"
            style={{ color: '#00BFFF', padding: '0' }}
          />
        }
      />
      
        </div>
        <p className='hero-paragraph'>Join as a member</p>
      </div>
     <div className='input-field2'>
      <div className="inside">
      <img src={Associative}  className='img'/>
      <FormControlLabel
        value="association"
        control={
          <Radio
            checked={selectedOption === 'association'}
            onChange={() => handleChange('association')}
            color="default"
            style={{ color: '#00BFFF', padding: '0' }}
          />
        }
      />    
   
        </div>
      <p className='hero-paragraph'>Join as a association</p>
      </div>
      </div>
    <button className='big-CTA-button'>Create account</button>
    <div className='paragraphs'>
    <p className='parag'>Alredy have account ?</p>
    <span className='span'> Login</span> 
    </div>
      </div>
 </div>
  )
 
};


export default userORcharity
