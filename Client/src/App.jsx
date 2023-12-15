import { BrowserRouter, Routes, Route } from "react-router-dom" 
import SingIn from "./pages/singIn/singInPage.jsx"
import SingForAssociation from "./pages/singupPage/singForAssocaition.jsx"
import SingForMember from "./pages/singupPage/singForMember.jsx"
import Home from './Homepage/home.jsx'

function App() {
  return (

    <BrowserRouter>
      <Home />
    </BrowserRouter>

  )
}

export default App