import React,{useState} from 'react'
import "./style/singForMember.css"
import InputField from '../compenenet/InputField'
import GoogleButton from '../compenenet/SecondaryButtonIcon'
import CTA_button from '../compenenet/BigCTA_Button'
import icon from "../../assets/googleIcon.svg"
import "../compenenet/styles.css"
import { API_URL } from '../compenenet/urll'
import { Navigate } from 'react-router-dom'


const singup = () => {
  const [userName, setUser] = useState("");
  const [email,setemail] = useState("");
  const [password,setPassword] = useState("");
  const loginClickHandler = async (e) => {
    e.preventDefault();
    try{      
    const response = await fetch(`${API_URL}/sign_in`,{
      method: "POST",
      headers : new Headers( { 'ngrok-skip-browser-warning' : '1', 'content-type' : 'application/json' } ),
      body: JSON.stringify({
        fullName:userName ,
        email:email,
        password: password,
        identity: "association"
      }),
    })
    const data = await response.json() ; 
     if (data){
      console.log(data); 
     /* Navigate(`/home/${data.user_Id}`);*/
     }
    }catch(e){ 
      console.log("hello mother fucker");
    }
  };


  return (
    <div className="split-container-SingUp"> 
    <div className="image-side-SingUp">
    </div>
    <div className="color-side-SingUp">
    <div className='Hero-logIn-SingUp'>
    <h1 className='Hero-title-SingUp'>Become a memeber !</h1 >
  <div className='userName-SingUp'>
    <p className='usernameParagraph-SingUp'>Association name</p>     
    <input onChange={(event)=>setUser(event.target.value)}  placeholder={"Amine Mazari"} className="input" />
  </div>    
  <div className='userName-SingUp'>
    <p className='usernameParagraph-SingUp'>Email</p>     
    <input onChange={(event)=>setemail(event.target.value)}  placeholder={"exmple@email.com"} className="input" />
  </div>    
    <div className='Password-SingUp'>
      <p className='PasswordParagraph-SingUp'>Password</p>
      <input onChange={(event)=>setPassword(event.target.value)} placeholder={"Password"} type='password' className="input" />
    </div> 
   <button onClick={loginClickHandler} className="big-CTA-button-SingUp">log in </button>
   <div className='forgotPasSection-SingUp'>
   <a className='forgotPas-SingUp'>Forgot Password ?</a>
   </div>

<section className='container-SingUp'>
 <div className='horizontal-line1-SingUp'></div>
 <p className='or-SingUp'>Or</p>
<div className='horizontal-line1-SingUp'></div>  
</section>
<GoogleButton text={"Continue with Google"} Icon={icon}></GoogleButton>
<div className='noAccount-SingUp'>
<p className='noAccountParagraph-SingUp'>Don’t have an account</p>
<a className='noAccountParagraph2-SingUp'>Log In</a>
</div>
  </div>
  </div>
</div>
  )
}

export default singup
