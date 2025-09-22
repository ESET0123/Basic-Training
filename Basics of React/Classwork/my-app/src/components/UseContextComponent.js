import React from 'react'
import {useContext} from 'react'
import { Context } from '../App'

export default function UseContextComponent() {
    const {theme} = useContext(Context)
  return (
    <div>
        use context component {theme}
    </div>
  )
}
