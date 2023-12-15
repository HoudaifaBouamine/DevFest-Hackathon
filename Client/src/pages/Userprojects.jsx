import './Homepage/postdetail.css'
import { useParams } from 'react-router-dom'
import { useState, useEffect } from 'react'
import avatar from './Homepage/image.jpg'

export default function() {

  let {id} = useParams()
  console.log(id)
  
  let [projects,setProjects] = useState([])

  useEffect( () => {
    fetch( 'https://cd50-154-121-47-102.ngrok-free.app/projects' , {
      headers : new Headers( { 'ngrok-skip-browser-warning' : '1', 'content-type' : 'application/json' } )
    } )
    .then( result => result.json() )
    .then ( result => setProjects(result) )
  },
  []
  )

  return null


}