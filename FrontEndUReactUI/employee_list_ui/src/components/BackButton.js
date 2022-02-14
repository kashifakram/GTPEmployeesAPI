import React from 'react'
import { Link } from "react-router-dom";
import '../styles/main.scss';

export const BackButton = () => {
  return (
    <Link to="/" className='backLink'> &lt; Back </Link>
  )
}
