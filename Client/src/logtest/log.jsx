import './log.css'

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

export default function() {

  return (

    <div className="signin">
      <h1>Become a member</h1>
      <form>
      <Inputfield label='Full name' />
      <Inputfield label='Email' />
      <Inputfield label='Password' />
      <input className='submit' type='submit' value='Sign up'></input>
      </form>
      <Horizontal />
      <button classN>Continue with google</button>
    </div>

  )

}