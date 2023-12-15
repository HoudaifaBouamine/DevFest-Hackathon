import { BrowserRouter, Routes, Route } from "react-router-dom" 
import SingIn from "./pages/singIn/singInPage.jsx"
import SingForAssociation from "./pages/singupPage/singForAssocaition.jsx"
import SingForMember from "./pages/singupPage/singForMember.jsx"
import Home from './pages/Homepage/home.jsx'
import Projects from './pages/projects/project.jsx'
import ChooseIdantity from "./pages/singupPage/chooseIdantity.jsx"
import LandingPage from "./pages/landingPage/landingPage.jsx"
import Pageone from "./pages/landingPage/pageone.jsx"

import Pagetwo from "./pages/landingPage/pagetwo.jsx"



function App() {
  return (
    <BrowserRouter>
    <Routes>
      <Route path="/" element={<LandingPage />}></Route>
      <Route path="/home" element={<Home />}></Route>
    </Routes>
    </BrowserRouter>
  )
}

export default App