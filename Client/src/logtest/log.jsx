import './log.css'
import SVG from './Vector.svg'

function Inputfield({label}) {
  return (
    <div className="inputfield">
    <label htmlFor={label.slice(0,3)}>{label}</label>
    <input type="text" id={label.slice(0,3)} name={label.slice(0,3)} placeholder={label} ></input>
    </div>
  )
}

function Horizontal() {

  return (
    <div className='horizontal'>
      <div></div>
      <p>Or</p>
      <div></div>
    </div>
  )
  
  }

  function handleclick(e) {
    e.preventDefault()
    let nom = document.getElementById('Ful').value
    let email = document.getElementById('Ema').value
    let password = document.getElementById('Pas').value

    fetch("https://cd50-154-121-47-102.ngrok-free.app/login" , {
        method : 'post',
        body : JSON.stringify({   
          "email" : "john.doe@example.com",
          "password" : "123"
      }),
        headers : new Headers( { 'ngrok-skip-browser-warning' : '1', 'content-type' : 'application/json' } )
      })
    .then( result => result.json() )
    .then ( result => console.log(result))
  }

export default function() {

  return (

    <div className="signin">
      <h1>Become a member</h1>
      <form>
      <Inputfield label='Full name' />
      <Inputfield label='Email' />
      <Inputfield label='Password' />
      <input className='submit' type='submit' value='Sign up' onClick={handleclick}></input>
      </form>
      <Horizontal />
      <button classN><svg width="24" height="25" viewBox="0 0 24 25" fill="none" xmlns="http://www.w3.org/2000/svg">
<path d="M12.2405 10.3864V14.9716H18.7731C17.9209 17.75 15.5984 19.7401 12.2405 19.7401C8.24331 19.7401 5.00041 16.4972 5.00041 12.5C5.00041 8.50284 8.23905 5.25994 12.2405 5.25994C14.0388 5.25994 15.6794 5.92045 16.945 7.0071L20.32 3.62784C18.1893 1.68466 15.3513 0.5 12.2405 0.5C5.60978 0.5 0.236206 5.87358 0.236206 12.5C0.236206 19.1264 5.60978 24.5 12.2405 24.5C22.3143 24.5 24.5388 15.0781 23.5501 10.4034L12.2405 10.3864Z" fill="#00BFFF"/>
</svg>
Continue with google</button>
    </div>

  )

}