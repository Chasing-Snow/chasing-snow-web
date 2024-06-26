import React from 'react';
import logo from './logo.svg';
import './App.css';
import { BrowserRouter as Router, Route, Routes, Link } from "react-router-dom";
import Home from "./Home/Home";
import Products from "./Products/Products";
import Orders from "./Orders/Orders"
import OrderDetail from './Orders/OrderDetail';
import CheckoutSteps from './Payment/CheckoutSteps';
export function App() {
  const openMenu = () => {
    document.querySelector("sidebar")?.classList.add("open");
  }
  const closeMenu = () => {
    document.querySelector("sidebar")?.classList.remove("open");
  }
  return (
    <Router>
    <div className = "grid-container">
    <header className ="header">
        <div className="brand">
            <button onClick={openMenu}>#9776;</button>
            <a href="index.html">Chasing Snow</a>
        </div>
        <div className = "header-links">
            <Link to="/">Home</Link>
            <Link to="/catalog">Catalog</Link>
            <Link to="/orders">Orders</Link>
        </div>
    </header>
<head>
    <link rel="stylesheet" href="style.css">
      </link>
    <title>Chasing Snow</title>
</head>
<body>
    <div>
        <header>
            Chasing Snow
        </header>
        <aside className="sidebar">
            <h3>Shopping Categories</h3> 
            <button className="sidebar-close-button" onClick={closeMenu}>x</button>
            <ul className="products">
                {data.products.map((products)  =>  (
                <li>
                 <div className="product">
                 <img 
                  className="product-image"
                  src={Products.imageUrl}
                  alt="product"
                 /> 
                 <div className="product-name">
                    <a href="product.html">{products.name}</a>
                 </div>   
                 <div className="product-brand">{products.brand}</div>
                 <div className="product-price">{products.price}</div>
                 <div className="product-rating">
                    {products.rating} Stars ({products.numberOfReviews} reviews)
                 </div>
                 </div>
                </li>
                ))}
                ;
            </ul>
            
        <main className='main'>
            <Routes>
                <Route path="/" element={<Home />} />
                <Route path= "/catalog" element={<Products />} />
                <Route path="orders" element={<Orders />}></Route>
                <Route path="/order/:id" element={<OrderDetail />}></Route>
            </Routes>
        </main>
        
    
</body>
</div>
</Router>
  );
}

export default App;
