import './postdetail.css'
import avatar from './image.jpg'

export default function() {
  
  return (
    <div className='post'>
      <h1>

      </h1>
      <div className='owner'>
        <img className='avatar' src={avatar} />
        <h2>
        lorem ipsum
        </h2>
        <h3>
          13-janvier-2004
        </h3>
        <span>
          Status
        </span>
        <p></p>
      </div>
      <p>
      Imagine a web app designed to tackle bullying head-on. 💻✨ Picture a safe online space where users can access resources, report incidents, and find support. 🌈🤝 Together, we can create a virtual community that stands up to bullying!
      </p>
      <div className='tags'>
        <a>Start</a>
      </div>
    </div>
  )

}