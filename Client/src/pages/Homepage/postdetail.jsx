import './postdetail.css'
import avatar from './image.jpg'
import { useEffect , useState } from 'react'
import { Link } from 'react-router-dom'

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
      <Link to={`/user/${item.suggester.user_Id}`}>
      <h2>
      {item.suggester.fullName}
      </h2>
      </Link>
      <h3>
        13-janvier-2004
      </h3>
      <span>
        {item.status}
      </span>
      </div>
      <h1>{item.title}</h1>
      <p>
      {item.description}
      </p>
      <div className='tags'>
      <a>Contact user</a>
      </div>
      </li>
  ) )

  return (
    <ul className='post'>
      {items}
    </ul>
  )

}