import { Route, BrowserRouter, Router, Routes } from 'react-router-dom'; 
import LandingPage from "./pages/landingPage/landingPage.jsx"
import SingInPage from './pages/singIn/singInPage.jsx';
import ChooseIdantity from "./pages/singupPage/chooseIdantity.jsx"
import UserORcharity from "./pages/singupPage/userORcharity.jsx"
import Association from "./pages/singupPage/singForAssocaition.jsx"
import Member from "./pages/singupPage/singForMember.jsx"
function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<LandingPage/>}/>
        <Route path="/SingIn" element={<SingInPage/>}/>
        <Route path="/SingUp" element={<UserORcharity/>}/>
        <Route path="/SingUp/Association" element ={<Association/>}/>
        <Route path="/SingUp/Member" element ={<Member/>}/>

        <Route path="/SingUp/Member/ChooseIdantity" element={<ChooseIdantity/>}/>

         </Routes>
    </BrowserRouter>
   
  )
}

export default App