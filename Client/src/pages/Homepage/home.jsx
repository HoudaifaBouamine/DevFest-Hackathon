import { Link, Routes, Route } from 'react-router-dom'
import img from './image.jpg'
import './home.css'
import Post from './postdetail'
import Panel from './panel'
import Project from '../projects/project.jsx'
import Userposts from '../Userposts.jsx'
import Userprojects from '../Userprojects.jsx'

function Navbar() {

  return (
    <nav className="homenavbar">
      <h1>
        <svg width="40" height="41" viewBox="0 0 40 41" fill="none" xmlns="http://www.w3.org/2000/svg">
        <g clip-path="url(#clip0_163_2989)">
        <path d="M33.74 10.779C46.3834 34.4252 16.8876 37.0613 0 40.5L15.7302 18.9325C15.8732 18.6002 16.1054 18.3065 16.4052 18.0786C16.705 17.8507 17.0626 17.6961 17.445 17.6291L22.8529 17.5314L19.9596 13.0168C19.7468 12.3568 19.8415 11.7983 20.1181 11.3765V11.3697C24.4793 4.83304 27.1386 -0.769249 35.1367 0.751902C37.0641 0.947171 39.5128 2.91451 40.0053 4.52939C37.9148 6.61227 35.8263 8.69547 33.74 10.779Z" fill="#00BFFF"/>
        <path d="M15.1185 11.9623L9.43613 12.4729L12.5358 16.5404C13.4836 18.4589 11.2115 20.4536 9.25105 18.8963L3.88779 11.8666C3.11978 10.4997 3.99416 9.25782 5.21956 9.01959L5.28338 8.99909L14.4962 8.177C16.7822 8.36348 17.5587 11.1597 15.1185 11.9623Z" fill="#00BFFF"/>
        </g>
        <defs>
        <clipPath id="clip0_163_2989">
        <rect width="40" height="40" fill="white" transform="translate(0 0.5)"/>
        </clipPath>
        </defs>
        </svg>
      </h1>
      <div className="links">
        <Link to='/home'>Home</Link><a>Ideas</a><Link to='/projects'>Projects</Link>
      </div>
      <div className="right">
      <svg width="24" height="25" viewBox="0 0 24 25" fill="none">
      <path d="M3 11.5C3 7.72876 3 5.84315 4.17157 4.67157C5.34315 3.5 7.22876 3.5 11 3.5H13C16.7712 3.5 18.6569 3.5 19.8284 4.67157C21 5.84315 21 7.72876 21 11.5V13.5C21 17.2712 21 19.1569 19.8284 20.3284C18.6569 21.5 16.7712 21.5 13 21.5H11C7.22876 21.5 5.34315 21.5 4.17157 20.3284C3 19.1569 3 17.2712 3 13.5V11.5Z" stroke="#00BFFF" stroke-width="2"/>
      <path d="M12 8.5L12 16.5" stroke="#00BFFF" strokeWidth="2" strokeLinecap="square" strokeLinejoin="round"/>
      <path d="M16 12.5L8 12.5" stroke="#00BFFF" strokeWidth="2" strokeLinecap="square" strokeLinejoin="round"/>
      </svg>
      <svg width="24" height="25" viewBox="0 0 24 25" fill="none">
      <path d="M6.44784 8.46942C6.76219 5.64032 9.15349 3.5 12 3.5V3.5C14.8465 3.5 17.2378 5.64032 17.5522 8.46942L17.804 10.7356C17.8072 10.7645 17.8088 10.779 17.8104 10.7933C17.9394 11.9169 18.3051 13.0005 18.8836 13.9725C18.8909 13.9849 18.8984 13.9973 18.9133 14.0222L19.4914 14.9856C20.0159 15.8599 20.2782 16.297 20.2216 16.6559C20.1839 16.8946 20.061 17.1117 19.8757 17.2668C19.5971 17.5 19.0873 17.5 18.0678 17.5H5.93223C4.91268 17.5 4.40291 17.5 4.12434 17.2668C3.93897 17.1117 3.81609 16.8946 3.77841 16.6559C3.72179 16.297 3.98407 15.8599 4.50862 14.9856L5.08665 14.0222C5.10161 13.9973 5.10909 13.9849 5.11644 13.9725C5.69488 13.0005 6.06064 11.9169 6.18959 10.7933C6.19123 10.779 6.19283 10.7645 6.19604 10.7356L6.44784 8.46942Z" stroke="#333333" stroke-width="2"/>
      <path d="M9.10222 18.1647C9.27315 19.1215 9.64978 19.967 10.1737 20.5701C10.6976 21.1731 11.3396 21.5 12 21.5C12.6604 21.5 13.3024 21.1731 13.8263 20.5701C14.3502 19.967 14.7269 19.1215 14.8978 18.1647" stroke="#333333" stroke-width="2" stroke-linecap="round"/>
      </svg>
      <div>
        <img src={img}></img>
        <svg width="24" height="25" viewBox="0 0 24 25" fill="none">
        <path d="M18 9.5L12 15.5L6 9.5" stroke="#333333" strokeWidth="2"/>
        </svg>
      </div>
      </div>
    </nav>
  )

}

function Createpost() {

  return (
    <div className='crepost'>
      <input type='text' className='left'/>
      <a>
      <svg width="24" height="24" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
      <path fill-rule="evenodd" clip-rule="evenodd" d="M17.2038 10.7959L18.9998 8.99994C19.545 8.45469 19.8176 8.18207 19.9634 7.88797C20.2407 7.32842 20.2407 6.67146 19.9634 6.11191C19.8176 5.81782 19.545 5.54519 18.9998 4.99994C18.4545 4.45469 18.1819 4.18207 17.8878 4.03633C17.3282 3.75905 16.6713 3.75905 16.1117 4.03633C15.8176 4.18207 15.545 4.45469 14.9998 4.99994L13.1811 6.8186C14.145 8.4692 15.5311 9.84476 17.2038 10.7959ZM11.7267 8.27305L4.85615 15.1436C4.43109 15.5686 4.21856 15.7812 4.07883 16.0422C3.93909 16.3033 3.88015 16.5981 3.76226 17.1875L3.14686 20.2645C3.08034 20.5971 3.04708 20.7634 3.14168 20.858C3.23629 20.9526 3.4026 20.9194 3.73521 20.8529L6.81219 20.2375C7.40164 20.1196 7.69637 20.0606 7.95746 19.9209C8.21856 19.7812 8.43109 19.5686 8.85615 19.1436L15.7456 12.2542C14.1239 11.2385 12.7522 9.87622 11.7267 8.27305Z" fill="white"/>
      </svg>
      <span>Create post</span>
      </a>
    </div>
  )

}

export default function() {

  return (
    <>
    <Navbar />
    <Createpost />
    <Routes>
      <Route path='/home' element={<Post />}></Route>
      <Route path='/projects' element={<Project />}></Route>
      <Route path='/user/:id' element={<Userposts />}></Route>
      <Route path='/userprojects/:id' element={<Userprojects />}></Route>
    </Routes>
    <Panel />
    </>
  )

}