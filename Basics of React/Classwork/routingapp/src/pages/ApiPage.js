import React from 'react'
import UseFetch from '../hooks/UseFetch'

export default function ApiPage() {
    const [loading, data, error] = UseFetch("https://jsonplaceholder.typicode.com/posts")
  return (
    <div>
        {
            loading && <>loading...</>
        }
        {
            !loading && error && <>{error.message}</>
        }
        {
            !loading && !error && data && data.map((element)=><div key={element}>{element.id}. {element.title}</div>)
        }
      
    </div>
  )
}
