import { Outlet, Link } from "react-router-dom";
import { BackButton } from "./BackButton";
import React, { useState, createContext } from 'react'

export const EmployeeContext = createContext();

const Layout = () => {

    const [totalCartItems, setTotalCartItems] = useState(0);
    const [country, setCountry] = useState("aud");
    const [cartItems, setCartItems] = useState([]);
    const [allProducts, setAllProducts] = useState([]);
    const [shippingCost, setShippingCost] = useState(0);
    const [conversion, setConversion] = useState(1);

    return (
        <EmployeeContext.Provider value={{
            cartData: {
                totalCartItems,
                country, 
                cartItems, allProducts, setAllProducts,
                shippingCost, setShippingCost,
                conversion, setConversion,
                setTotalCartItems, setCountry, setCartItems
            }
        }}>
            <div>
                <div className="container mt-3">
                    <div className="mt-4 p-5 bg-light text-black rounded">
                        <BackButton />
                        <h2>Employees' list</h2>
                    </div>
                </div>
            </div>
            <Outlet />
        </EmployeeContext.Provider>
    )
};

export default Layout;