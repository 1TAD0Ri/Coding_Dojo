import React from 'react'
import { useState , useEffect  } from 'react'
import { useNavigate } from "react-router-dom";
const Form = () => {

    const [product , setProduct] = useState({
        title: '',
        price: 0,
        description: ''

    })
    // const navigate = useNavigate();
    // const onSubmit = (e) => {
    //     e.preventDefault();
    //     axios.post('http://localhost:8000/api/products', product).then(res => navigate('/products'))
    //         .catch(err => console.log(err));
    //     setProduct({
    //         title: '',
    //         price: 0,
    //         description: ''
    //     })
    // }
  return (
    <div>

        <form onSubmit={onSubmit}>
            <label>Title</label>
            <input type="text"  onChange={(e) => setProduct({ ...product, title: e.target.value })} value={product.title} />
            <label>Price</label>
            <input type="number" onChange={(e) => setProduct({ ...product, price: e.target.value })} value={product.price} />
            <label>Description</label>
            <input type="text" onChange={(e) => setProduct({ ...product, description: e.target.value })} value={product.description}  />
            <button type='submit'>Create</button>

        </form>


    </div>
  )
}

export default Form