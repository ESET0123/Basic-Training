import React from 'react'
import {BrowserRouter, Route, Routes} from 'react-router-dom';
import Navbar from './components/Navbar'
import HomePage from './pages/HomePage'
import AboutPage from './pages/AboutPage'
import ApiPage from './pages/ApiPage'

export default function App() {
  return (
    <div>
      <BrowserRouter>
      <Navbar/>
        <Routes>
          <Route path="/" element={<HomePage/>}></Route>
          <Route path="/About" element={<AboutPage/>}></Route>
          <Route path="/ApiPage" element={<ApiPage/>}></Route>
        </Routes>
      </BrowserRouter>
    </div>
  )
}
