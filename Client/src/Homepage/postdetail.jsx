import './postdetail.css'
import avatar from './image.jpg'
import { useEffect , useState } from 'react'

export default function() {
  
  let [ideas,setIdeas] = useState([])

  useEffect( () => {
    fetch( 'https://cd50-154-121-47-102.ngrok-free.app/ideas' , {
      headers : new Headers( { 'ngrok-skip-browser-warning' : '1', 'content-type' : 'application/json' } )
    } )
    .then( result => result.json() )
    .then ( result => setIdeas(result) )
  },
  []
  )

  let items = ideas.map ( item => (
    <li key={item.idea_Id} className='post'>
    <div className='owner'>
      <img className='avatar' src={avatar} />
      <h2>
      {item.suggester.fullName}
      </h2>
      <h3>
        13-janvier-2004
      </h3>
      <span>
        {item.status}
      </span>
      </div>
      <h1>{item.title}</h1>
      <p>
      Imagine a web app designed to tackle bullying head-on. 💻✨ Picture a safe online space where users can access resources, report incidents, and find support. 🌈🤝 Together, we can create a virtual community that stands up to bullying!
      </p>
      <div className='tags'>
      <a>Start</a>
      </div>
      </li>
  ) )

  return (
    <ul>
      {items}
    </ul>
  )

}