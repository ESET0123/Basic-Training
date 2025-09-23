import React from 'react'
import { Link } from 'react-router-dom'

export default function Navbar() {
  return (
    <div>
        Navbar &nbsp;
        <Link to="/"> Home</Link> &nbsp;
        <Link to="/About"> About</Link>
        <Link to="/ApiPage"> Api</Link>
    </div>
  )
}
