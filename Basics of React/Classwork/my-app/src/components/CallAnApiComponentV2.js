import {useEffect, useState} from 'react'


const useFetch = (url)=>{

    const [data,setData] = useState([])
    const [error,setError]= useState(null)
    const [loading,setLoading] = useState(false)

    const getData = ()=>{
        setLoading(true)
        fetch(url)
        .then((data)=>data.json())
        .then((jsonData)=>setData(jsonData))
        .catch((error)=>setError(error))
        .finally(()=>{setLoading(false)})
    }

    useEffect(getData,[])

    return [loading, data, error]
}

export default function CallAnApiComponent() {



    const [loading, data, error] = useFetch("https://jsonplaceholder.typicode.com/posts")

  return (
    <div>
      {
          error && <>{error.message}</>
      }
      {
          loading && <>loading....</>
      }
      {
        data.map((element)=><div key={element.id}>{element.id}. {element.title}</div>)
      }
    </div>
  )
}