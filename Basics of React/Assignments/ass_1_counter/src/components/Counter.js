import  {useState} from 'react'
import Button from './Button';

export default function Counter() {
    const [count, setCount] = useState(0);
    const increamentHandler = () =>{
        setCount(prev=>prev+1);
        console.log("Increament clicked");
        
    }
    const decreamentHandler = () =>{
        setCount(prev=>prev-1);
        console.log("Decreament clicked");
    }
  return (
    <div>
      <div>Count: {count}</div>
      <Button label="Increament" onClick={increamentHandler}/>
      <Button label="Decreament" onClick={decreamentHandler}/>
    </div>
  )
}
