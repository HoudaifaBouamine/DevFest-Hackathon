import React from 'react'
import "./style/pagetwo.css"
import Logo from "./assets/Vector (1).svg"
import P from "./assets/Vector (2).svg"
import  D from "./assets/Vector (3).svg"
import G from "./assets/Vector (4).svg"
import Vector from "./assets/Vector (5).svg"
const pagetwo = () => {
  return (
    <div className='section2'>
      <div className='countainer'>
        <div className='Logo'>
        
         <img src={Logo} className='lo9o'></img>
        
         </div>
         <div>
         <img src={P} className='P'></img>
         <img src={D} className='D'></img>
         <img src={G} className='G'></img>
         </div>
       <h1 className='paragraph2'>What Is PDG ?</h1>
       <p className='paragraph3'>PDG, a non-profit organization, galvanizes volunteer developers worldwide to wield technology for peace and social change. In our inclusive and empowering community, guided by transparency and collaboration, user-suggested projects serve associations, emphasizing ethical development</p>

      </div>
    </div>
  )
}

export default pagetwo
