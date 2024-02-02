import './Homepage/postdetail.css'
import { useParams } from 'react-router-dom'
import { useState, useEffect } from 'react'
import avatar from './Homepage/image.jpg'

export default function() {

  let {id} = useParams()
  console.log(id)
  
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

  let items = ideas.filter(
    item => item.suggester.user_Id === id
  )

  items = items.map ( item => (
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
      {item.description}
      </p>
      <div className='tags'>
      <a>Contact user</a>
      </div>
      </li>
  ) )

  return (
    <ul>
      {items}
    </ul>
  )



}