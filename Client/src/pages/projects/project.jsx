import './project.css'
import avatar from '../Homepage/image.jpg'
import { useEffect , useState } from 'react'

export default function() {

  let [projects,setprojects] = useState([])

  useEffect( () => {
    fetch( 'https://cd50-154-121-47-102.ngrok-free.app/projects' , {
      headers : new Headers( { 'ngrok-skip-browser-warning' : '1', 'content-type' : 'application/json' } )
    } )
    .then( result => result.json() )
    .then ( result => setprojects(result) )
  },
  []
  )

  let conts = project => project.contributors.map(
    (item) => (
      <div key={item.user_Id} className='cosubcont'>
        <img src={avatar}></img>
        <span>{item.identity}</span>
      </div>
    )
  )

  let items = projects.map(
    item => (
      <li key={item.project_Id} className='post'>
        <div className='k'>
        <h1>
          {item.title}
        </h1>
        </div>
        <p>
        {item.description}
        </p>
        <div className='co'>
          <h2>Collaborators</h2>
          <div className='cocont'>
            {conts(item)}
          </div>
        </div>
        <div className='tags'>
        <a>Collaborate</a>
        </div>
        <p>github rep link :</p>
        <a>{item.githubRepoLink}</a>
      </li>
    )
  )

  console.log('items are',items)

  return (
    <ul>
      {items}
    </ul>
  )

}