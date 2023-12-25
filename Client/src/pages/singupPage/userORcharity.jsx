import React,{useState} from 'react'   
import { NavLink, Navigate } from 'react-router-dom';
import  Member from "./assets/member.svg" ; 
import Associative  from "./assets/associative.svg";
import "./style/userORcharity.css"
import Input from "./assets/Input.svg"
import { FormControlLabel, Radio, RadioGroup } from '@mui/material';
import { useNavigate } from 'react-router-dom';
const userORcharity = () => {
const Navigate = useNavigate("");
const [selectedOption, setSelectedOption] = useState('member');
const buttonGetClicked=()=>{
  if (selectedOption==="member"){
    Navigate("/SingUp/Member");
  }
  else if (selectedOption==="association"){
    Navigate("/SingUp/Association");
 }
}
const handleChange = (value) => {
  setSelectedOption(value);
  
};
    
  return (
    <div className='page-userORcharity'>
    <div className='Hero-page-userORcharity'>
      <div className='tite-userORcharity'>join us as user or association</div>
      <div className='input-field-userORcharity'>
      <div className='input-field1-userORcharity'>
      <div className="inside-userORcharity">
      <img src={Member} className='img-userORcharity'/>
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
        <p className='hero-paragraph-userORcharity'>Join as a member</p>
      </div>
     <div className='input-field2-userORcharity'>
      <div className="inside-userORcharity">
      <img src={Associative}  className='img-userORcharity'/>
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
      <p className='hero-paragraph-userORcharity'>Join as a association</p>
      </div>
      </div>
    <button className='big-CTA-button-userORcharity' onClick={buttonGetClicked}>Create account</button>
    <div className='paragraphs-userORcharity'>
    <p className='parag-userORcharity'>Alredy have account ?</p>
    <span className='span'> Login</span> 
    </div>
      </div>
 </div>
  )
 
};


export default userORcharity