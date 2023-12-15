import './panel.css'
import avatar from './image.jpg'

export default function() {

  return (
    <div className='panel'>
      <div className='d1'>
        <h1>
          Popular projects
        </h1>
        <div className='example'>
          <img src={avatar}></img>
          <div className='rexample'>
          <h2>
            Name
          </h2>
          <span>
            123 contributions
          </span>
          </div>
        </div>
        <div className='example'>
          <img src={avatar}></img>
          <div className='rexample'>
          <h2>
            Name
          </h2>
          <span>
            123 contributions
          </span>
          </div>
        </div>
      </div>
      <div className='d1 d2'>
      <h1>
          Active members
        </h1>
        <div className='example'>
          <img src={avatar}></img>
          <div className='rexample'>
          <h2>
            Name
          </h2>
          <span>
            123 contributions
          </span>
          </div>
        </div>
        <div className='example'>
          <img src={avatar}></img>
          <div className='rexample'>
          <h2>
            Name
          </h2>
          <span>
            123 contributions
          </span>
          </div>
        </div>
      </div>
    </div> 
  )

}