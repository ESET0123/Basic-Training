import {useState, useEffect} from 'react'

export default function MouseTracker() {
    const [mousePosition, setMousePosition] = useState({x:0, y:0});

    useEffect(()=>{
        const mouseHandler = (e) => {
            setMousePosition({x: e.clientX, y: e.clientY});
        }
        window.addEventListener('mousemove', mouseHandler);

        return()=>{
            window.removeEventListener('mousemove', mouseHandler);
        }
    },[])
  return (
    <div>
        <h1> Mouse Tracker </h1>
        <p>Mouse X: {mousePosition.x}</p>
        <p>Mouse y: {mousePosition.y}</p>
    </div>
  )
}
