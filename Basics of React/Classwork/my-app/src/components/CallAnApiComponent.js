import React, { useEffect, useState } from 'react'

export default function CallAnApiComponent() {
    const [data, seData] = useState([])
    const [error, setError] = useState(null)
    const [loading, setLoading] = useState(false)
    const getData = () =>{
        let a = fetch("https://jsonplaceholder.typicode.com/posts")
        .then((data)=>data.json())
        .then((jsonData)=>seData(jsonData))
        .catch((error)=> setError(error))
        .finally(()=>{setLoading(false)})
    }
    useEffect(getData,[])    

  return (
    <div>

        {
            error && <>{error.message}</>
        }
      {/* <button onClick={()=>{getData()}}>fetch data</button> */}
      {
        data.map((e)=><div key={e.id}> {e.id }. {e.title}</div>)
      }
    </div>
  )
}
