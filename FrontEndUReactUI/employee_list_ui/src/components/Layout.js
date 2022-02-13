import { Outlet, Link } from "react-router-dom";

const Layout = () => {
    return (
      <>
        <nav>
          <ul>
            <li>
              <Link to="/">Home</Link>
            </li>
            <li>
              <Link to="/add">Add</Link>
            </li>
            <li>
              <Link to="/modify">Modify</Link>
            </li>
            <li>
              <Link to="/delete">Delete</Link>
            </li>
          </ul>
        </nav>

        <div>
            
        </div>
  
        <Outlet />
      </>
    )
  };
  
  export default Layout;