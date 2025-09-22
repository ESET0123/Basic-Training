import {useState, useRef} from 'react'
import './ColorBoxHighlighter.css'

export default function ColorBoxHighlighter() {
    const boxRef = [useRef(null), useRef(null), useRef(null)];
    const [highlightedBoxIndex, setHighlightedBoxIndex] =useState(-1);

    const highlightNextHandler = () => {
        if(highlightedBoxIndex !== -1 && boxRef[highlightedBoxIndex].current){
            boxRef[highlightedBoxIndex].current.style.border = '12px solid yellow'
            if(highlightedBoxIndex-1>=0){
                boxRef[(highlightedBoxIndex-1) % boxRef.length].current.style.border = 'none'
            }
            if(highlightedBoxIndex==0){
                boxRef[(boxRef.length-1) ].current.style.border = 'none'
            }
        }

        const nextIndex = (highlightedBoxIndex + 1) % boxRef.length;

        setHighlightedBoxIndex(nextIndex);
    }
  return (
    <div style={{display: ' flex', flexDirection: 'column', alignItems: 'center'}}>
        <div style={{display: 'flex'}}>
            <div ref={boxRef[0]} className="color-box" style={{background: 'red'}}></div>
            <div ref={boxRef[1]} className="color-box" style={{background: 'green'}}></div>
            <div ref={boxRef[2]} className="color-box" style={{background: 'blue'}}></div>
        </div>
        <div>
            <button onClick={highlightNextHandler}>Highlight Next Box</button>
        </div>
    </div>
  )
}
