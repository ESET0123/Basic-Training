import React, { useEffect, useState } from 'react'
import axios from 'axios'

export default function UseFetch(url) {
    const [loading, setLoading] = useState(false);
    const [error, setError] = useState(false);
    const [data, setData] = useState(false);

    const getData = async () => {
        try{
            setLoading(true)
            const response = await axios.get(url)
            setData(response.data)
        }
        catch(error){
            console.log((error));
        }
        finally{
            setLoading(false)
        }
    }

    useEffect(() => {
        getData()
    },[])
        

  return [loading, data, error]
}
