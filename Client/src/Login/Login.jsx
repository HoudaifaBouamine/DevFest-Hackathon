import './Login.css'

function Inputarea({label}) {

  return (
    <div className="input">
    <label htmlFor={label} >User name</label>
    <input name={label} id={label} type='text' placeholder="User name" ></input>
    </div>
  )

}

export default function() {

  return (
    <form className="login">
      <h1>
        Become a member
      </h1>
      <Inputarea label={'user name'} />
    </form>
  )

}